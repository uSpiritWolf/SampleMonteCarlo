using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;

namespace MonteCarloS
{
	class MonteCarloMethod
	{
		private Bitmap image;

		public Bitmap Image
		{
			get
			{
				return image;
			}

			private set
			{
				Clear();
				image = value;
			}
		}

		public bool IsCompleted { get; private set; }

		public Action<int, int> ProgressChangeEvent { get; set; }

		public List<Point> ResultInside { get; set; }

		public List<Point> ResultOutside { get; set; }

		public int PointCount { get; private set; }

		private bool InProgress { get; set; }

		public MonteCarloMethod()
		{
			Clear();
		}

		public void Clear()
		{
			PointCount = 0;
			ResultInside = null;
			ResultOutside = null;
			IsCompleted = false;
		}

		public float SquarePrc()
		{
			if (PointCount > 0 && ResultInside != null)
			{
				return ResultInside.Count / (float)PointCount;
			}
			else
			{
				return 0;
			}
		}

		public int SquarePxl()
		{
			return (int)(SquarePrc() * (image.Width * image.Height));
		}

		public Task CalculateAsync(Bitmap img, int amountPoints, Action callback, CancellationToken ct)
		{
			if (InProgress == false)
			{
				InProgress = true;
				return Task.Run(() => Calculate(img, amountPoints, callback, ct), ct);
			}
			else
			{
				throw new Exception("It is impossible to start the second task while the first is still running.");
			}
		}

		public void Calculate(Bitmap img, int amountPoints, Action callback, CancellationToken ct)
		{
			InProgress = true;
			IsCompleted = false;

			Image = new Bitmap(img);

			PointCount = amountPoints;

			List<Point> resultInside;
			List<Point> resultOutside;
			List<Point> randomPoints = GetRandomPoints(amountPoints);

			InitProgress(randomPoints);

			PerformSearchPoints(randomPoints, out resultInside, out resultOutside, ct);

			if(!ct.IsCancellationRequested)
			{
				this.ResultInside = resultInside;
				this.ResultOutside = resultOutside;
				IsCompleted = true;
				callback?.Invoke();
			}

			InProgress = false;
		}

		private List<Point> GetRandomPoints(int amountPoints)
		{
			List<Point> randomPoints = new List<Point>();
			Random rand = new Random();
			for (int idx = 0; idx < amountPoints; idx++)
			{
				randomPoints.Add(new Point
				{
					X = rand.Next(0, Image.Width),
					Y = rand.Next(0, Image.Height)
				});
			}
			return randomPoints;
		}

		private void PerformSearchPoints(List<Point> points, out List<Point> resultInside, out List<Point> resultOutside, CancellationToken ct)
		{
			resultInside = new List<Point>();
			resultOutside = new List<Point>();

			for (int idx = points.Count - 1; idx >= 0; --idx)
			{
				bool inside = false;

				int resultX = Raycast(points[idx], new Point(-1, 0));
				int resultY = Raycast(points[idx], new Point(0, -1));

				if (resultX % 2 != resultY % 2)
				{
					resultX = Raycast(points[idx], new Point(1, 0));
					resultY = Raycast(points[idx], new Point(0, 1));
				}

				inside = resultX % 2 != 0 && resultY % 2 != 0;

				if (inside)
				{
					resultInside.Add(points[idx]);
				}
				else
				{
					resultOutside.Add(points[idx]);
				}

				points.RemoveAt(idx);

				IncreaseProgress();

				if(ct.IsCancellationRequested)
				{
					break;
				}
			}
		}

		private int Raycast(Point position, Point step)
		{
			if (step.X == 0 && step.Y == 0)
			{
				return 0;
			}

			int result = 0;
			bool onedge = false;

			{
				Color color = Image.GetPixel(position.X, position.Y);
				onedge = color.GetBrightness() < 0.8;
			}

			for (Point temp = position; ; temp.Offset(step))
			{
				if(temp.X < 0 || temp.Y < 0)
				{
					break;
				}

				if(temp.X >= Image.Width || temp.Y >= Image.Height)
				{
					break;
				}

				bool onedge_temp = false;

				Color color = Image.GetPixel(temp.X, temp.Y);

				if(color.GetBrightness() < 0.8)
				{
					onedge_temp = true;
				}

				if (onedge != onedge_temp)
				{
					if (onedge_temp)
					{
						++result;
					}

					onedge = onedge_temp;
				}
			}

			return result;
		}

		// Progress Bar
		private void InitProgress(List<Point> randomPoints)
		{
			targetProgress = randomPoints.Count;
			currentProgress = 0;

			if (ProgressChangeEvent != null)
			{
				Task.Run(() =>
				{
					while (InProgress && !IsCompleted)
					{
						ProgressChangeEvent.Invoke(currentProgress, targetProgress);
						Thread.Sleep(50);
					};
				});
			}
		}

		private void IncreaseProgress(int value = 1)
		{
			Interlocked.Add(ref currentProgress, value);

			if(currentProgress > targetProgress)
			{
				targetProgress = currentProgress;
			}
		}

		private int currentProgress;

		private int targetProgress;
	}
}
