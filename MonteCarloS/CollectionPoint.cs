﻿using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace MonteCarloS
{
	struct CollectionProgressData
	{
		public int value;
		public int maxValue;
	}

	class CollectionPoint
	{
		public HashSet<System.Drawing.Point> InsidePoints { get; private set; }
		public HashSet<System.Drawing.Point> OutsidePoints { get; private set; }

		public IProgress<CollectionProgressData> ProgressHandler { get; set; }

		public event Action FinishedEvent;

		private Task task;

		private CancellationTokenSource cancellationSource;

		public CollectionPoint()
		{
			InsidePoints = new HashSet<System.Drawing.Point>();
			OutsidePoints = new HashSet<System.Drawing.Point>();
		}

		public async void GeneratePointAsync(MaskForm mf, int amount)
		{
			if (task != null)
			{
				await task;
			}

			cancellationSource = new CancellationTokenSource();

			task = Task.Run(() => GeneratePointImpl(mf, amount), cancellationSource.Token);

			await task;
			task.Dispose();
			task = null;

			cancellationSource.Dispose();
			cancellationSource = null;

			FinishedEvent();
		}

		private void GeneratePointImpl(MaskForm mf, int amount)
		{
			int current = 0;

			Task progressTask = Task.Run(() =>
			{
				while (current < amount && !cancellationSource.Token.IsCancellationRequested)
				{
					ProgressHandler?.Report(new CollectionProgressData { value = current, maxValue = amount });
					Thread.Sleep(100);
				}
			}, cancellationSource.Token);

			Random rnd = new Random();

			HashSet<System.Drawing.Point> tempInsidePoints = new HashSet<System.Drawing.Point>();
			HashSet<System.Drawing.Point> tempOutsidePoints = new HashSet<System.Drawing.Point>();

			while (current < amount && !cancellationSource.Token.IsCancellationRequested)
			{
				System.Drawing.Point pt = new System.Drawing.Point(rnd.Next(0, mf.Width), rnd.Next(0, mf.Height));

				if (mf.IsInForm(pt))
				{
					tempInsidePoints.Add(pt);
				}
				else
				{
					tempOutsidePoints.Add(pt);
				}

				++current;
			}

			if (!cancellationSource.Token.IsCancellationRequested)
			{
				InsidePoints = tempInsidePoints;
				OutsidePoints = tempOutsidePoints;
			}

			progressTask.Wait();
			progressTask.Dispose();
		}

		public void Clear()
		{
			InsidePoints.Clear();
			OutsidePoints.Clear();
		}

		public float GetInsideRatio()
		{
			return InsidePoints.Count / (float)(InsidePoints.Count + OutsidePoints.Count);
		}

		public bool InProgress
		{
			get
			{
				return task != null && !task.IsCompleted;
			}
		}

		public void Cancel()
		{
			if(InProgress)
			{
				cancellationSource.Cancel();
			}
		}
	}
}