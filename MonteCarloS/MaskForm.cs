using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;

namespace MonteCarloS
{
	class MaskForm
	{
		public DirectBitmap Maps { private set; get; }

		public bool IsCompleted { get; private set; }

		public int Width { get => Maps.Width; }

		public int Height { get => Maps.Height; }

		public event Action FinishedEvent;

		private Task task { set; get; }

		public MaskForm()
		{
			IsCompleted = false;
		}

		public async void FillDataAsync(Bitmap bmp)
		{
			IsCompleted = false;

			if (task != null)
			{
				await task;
			}

			task = Task.Run(() => FillData(bmp.Clone() as Bitmap));

			await task;
			task.Dispose();
			task = null;

			IsCompleted = true;

			FinishedEvent();
		}

		private void FillData(Bitmap bmp)
		{
			Maps = new DirectBitmap(bmp);

			int tolorance = 50;

			Floodfill(Maps, new Point(0, 0), Color.FromArgb(255, 0, 0, 0), tolorance);
			Floodfill(Maps, new Point(bmp.Width - 1, bmp.Height - 1), Color.FromArgb(255, 0, 0, 0), tolorance);
			Floodfill(Maps, new Point(0, bmp.Height - 1), Color.FromArgb(255, 0, 0, 0), tolorance);
			Floodfill(Maps, new Point(bmp.Width - 1, 0), Color.FromArgb(255, 0, 0, 0), tolorance);
		}

		public void Wait()
		{
			task.Wait();
		}

		public bool IsInForm(Point pt)
		{
			return Maps.GetPixel(pt.X, pt.Y).GetBrightness() > 0.5;
		}

		private void Floodfill(DirectBitmap bmp, Point pt, Color colour, int tolorance)
		{
			Queue<Point> points = new Queue<Point>();

			points.Enqueue(pt);

			while(points.Count > 0)
			{
				Point curPt = points.Dequeue();
				Color curCol = bmp.GetPixel(curPt.X, curPt.Y);

				if (!AreColorSimilar(curCol, colour, tolorance))
				{
					bmp.SetPixel(curPt.X, curPt.Y, colour);

					Point newpoint = new Point(curPt.X - 1, curPt.Y);
					if (newpoint.X != -1)
					{
						Color col = bmp.GetPixel(newpoint.X, newpoint.Y);
						if (!AreColorSimilar(col, colour, tolorance))
						{
							points.Enqueue(newpoint);
						}
					}

					newpoint = new Point(curPt.X + 1, curPt.Y);
					if (newpoint.X != bmp.Width)
					{
						Color col = bmp.GetPixel(newpoint.X, newpoint.Y);
						if (!AreColorSimilar(col, colour, tolorance))
						{
							points.Enqueue(newpoint);
						}
					}

					newpoint = new Point(curPt.X, curPt.Y - 1);
					if (newpoint.Y != -1)
					{
						Color col = bmp.GetPixel(newpoint.X, newpoint.Y);
						if (!AreColorSimilar(col, colour, tolorance))
						{
							points.Enqueue(newpoint);
						}
					}

					newpoint = new Point(curPt.X, curPt.Y + 1);
					if (newpoint.Y != bmp.Height)
					{
						Color col = bmp.GetPixel(newpoint.X, newpoint.Y);
						if (!AreColorSimilar(col, colour, tolorance))
						{
							points.Enqueue(newpoint);
						}
					}
				}
			}
		}

		private bool AreColorSimilar(Color c1, Color c2, int tolerance)
		{
			return	Math.Abs(c1.R - c2.R) < tolerance &&
					Math.Abs(c1.G - c2.G) < tolerance &&
					Math.Abs(c1.B - c2.B) < tolerance;
		}
	}
}
