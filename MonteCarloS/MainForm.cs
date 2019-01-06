using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MonteCarloS
{
	public partial class MainForm : Form
	{
		private Bitmap originImage;

		private MonteCarloMethod monteCarloMethod = new MonteCarloMethod();

		private CancellationTokenSource cancellationTokensSource;

		private Task taskMonteCarloMethod;

		public MainForm()
		{
			InitializeComponent();
		}

		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (taskMonteCarloMethod != null)
			{
				ClearTasks();
			}

			Application.Exit();
		}

		private void openToolStripMenuItem_Click(object sender, EventArgs e)
		{
			using (OpenFileDialog openFileDialog = new OpenFileDialog())
			{
				openFileDialog.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All files (*.*)|*.*";
				openFileDialog.FilterIndex = 1;
				openFileDialog.RestoreDirectory = true;

				if (openFileDialog.ShowDialog() == DialogResult.OK)
				{
					originImage = new Bitmap(openFileDialog.OpenFile());

					if (taskMonteCarloMethod != null)
					{
						ClearTasks();
					}

					monteCarloMethod.Clear();

					RefreshImage();
					RefreshButton();
				}
			}
		}

		private void OnFinishCalculate()
		{
			RefreshImage();

			SetProgressBar(0, 0);
			RefreshButton();
		}

		private void RefreshButton()
		{
			Invoke(new Action(() =>
			{			
				ApplyBtn.Enabled = taskMonteCarloMethod == null ? true : monteCarloMethod.IsCompleted;
				ApplyBtn.Enabled &= originImage != null;

				ClearBtn.Enabled = ApplyBtn.Enabled;
				ClearBtn.Enabled &= monteCarloMethod.IsCompleted;

				CencelMenuItem.Enabled = taskMonteCarloMethod == null ? false : !taskMonteCarloMethod.IsCompleted;
			}));
		}

		private void RefreshImage()
		{
			if (originImage != null)
			{
				// Draw Points
				Bitmap image = (Bitmap)originImage.Clone();
				if (monteCarloMethod.PointCount > 0)
				{
					DrawPoints(Graphics.FromImage(image), monteCarloMethod.ResultInside, monteCarloMethod.ResultOutside);
				}
				SetImage(image);
				// End Draw

				// Print Info
				Invoke(new Action(() =>
				{
					ResolutionTextBox.Text = image.Width * image.Height + " pxl.  (" + image.Width + "x" + image.Height + ")";

					if (monteCarloMethod.SquarePrc() > 0)
					{
						SquarePrñTextBox.Text = (monteCarloMethod.SquarePrc() * 100) + "%";
						SquarePxlTextBox.Text = monteCarloMethod.SquarePxl() + " pxl.";
					}
					else
					{
						SquarePrñTextBox.Text = "";
						SquarePxlTextBox.Text = "";
					}
				}));
				// End Print
			}
		}

		private void DrawPoints(Graphics g, List<Point> inside, List<Point> outside)
		{
			if (inside != null)
			{
				foreach (Point p in inside)
				{
					if (sizePointNumeric.Value == 1)
					{
						g.FillRectangle(Brushes.Green, p.X, p.Y, 1, 1);
					}
					else
					{
						g.FillEllipse(Brushes.Green, p.X, p.Y, (int)sizePointNumeric.Value, (int)sizePointNumeric.Value);
					}
				}
			}

			if (outside != null)
			{
				foreach (Point p in outside)
				{
					if (sizePointNumeric.Value == 1)
					{
						g.FillRectangle(Brushes.Red, p.X, p.Y, 1, 1);
					}
					else
					{
						g.FillEllipse(Brushes.Red, p.X, p.Y, (int)sizePointNumeric.Value, (int)sizePointNumeric.Value);
					}
				}
			}

			g.Save();
		}

		private async void StartMonteCarloMethod()
		{
			if (taskMonteCarloMethod != null)
			{
				ClearTasks();
			}

			if (originImage != null)
			{
				monteCarloMethod.ProgressChangeEvent = SetProgressBar;

				cancellationTokensSource = new CancellationTokenSource();

				taskMonteCarloMethod = monteCarloMethod.CalculateAsync(originImage, (int)pointsNumeric.Value, OnFinishCalculate, cancellationTokensSource.Token);
			}

			RefreshImage();
			RefreshButton();

			await taskMonteCarloMethod;
			ClearTasks();
		}

		private void ApplyBtn_ClickAsync(object sender, EventArgs e)
		{
			StartMonteCarloMethod();
		}

		private void SetProgressBar(int cur, int max)
		{
			Invoke(new Action(() =>
			{
				if (max >= 0)
				{
					progressBar.Maximum = max;
				}

				if (cur >= 0)
				{
					progressBar.Value = cur;
				}
			}));
		}

		private void SetImage(Image img)
		{
			if (img != null)
			{
				pointsNumeric.Maximum = img.Width * img.Height;

				Invoke(new Action(() =>
				{
					pictureBox.Image = img;
				}));
			}
		}

		private void ClearTasks()
		{
			if (taskMonteCarloMethod != null)
			{
				if (!taskMonteCarloMethod.IsCompleted && cancellationTokensSource != null)
				{
					cancellationTokensSource.Cancel();
				}

				taskMonteCarloMethod.Wait();

				taskMonteCarloMethod.Dispose();
				cancellationTokensSource.Dispose();

				taskMonteCarloMethod = null;
				cancellationTokensSource = null;
			}

			SetProgressBar(0, 0);
			RefreshButton();
		}

		private void sizePointNumeric_ValueChanged(object sender, EventArgs e)
		{
			RefreshImage();
		}

		private void CencelMenuItem_Click(object sender, EventArgs e)
		{
			ClearTasks();
		}

		private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
		{
			AboutForm af = new AboutForm();
			af.ShowDialog(this);
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			RefreshButton();
		}

		private void ClearBtn_Click(object sender, EventArgs e)
		{
			monteCarloMethod.Clear();
			RefreshImage();
			RefreshButton();
		}
	}
}
