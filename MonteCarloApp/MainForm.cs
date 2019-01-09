using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MonteCarloApp
{
	public partial class MainForm : Form
	{
		private Bitmap originImage;

		private MaskForm maskForm = new MaskForm();

		private CollectionPoint collectionPoints = new CollectionPoint();

		public MainForm()
		{
			InitializeComponent();

			Action OnFinished = new Action(() =>
			{
				SetProgressBar(0, 0);
				RefreshImage();
				RefreshStatus();
			});

			collectionPoints.ProgressHandler = new Progress<CollectionProgressData>(pg =>
			{
				SetProgressBar(pg.value - 1, pg.maxValue);
				SetProgressBar(pg.value, pg.maxValue);
			});

			collectionPoints.FinishedEvent += OnFinished;
			maskForm.FinishedEvent += OnFinished;
		}

		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
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
					SetImage(null);

					originImage = new Bitmap(openFileDialog.OpenFile());

					if(collectionPoints.InProgress)
					{
						collectionPoints.Cancel();
					}
					collectionPoints.Clear();

					maskForm.FillDataAsync(originImage);

					UseWaitCursor = true;
				}
			}
		}

		private void OnFinishCalculate(List<Point> inside, List<Point> outside)
		{
			originImage = maskForm.Maps.Bitmap;

			RefreshImage();

			SetProgressBar(0, 0);
			RefreshStatus();
		}

		private void RefreshStatus()
		{
			Invoke(new Action(() =>
			{
				ApplyBtn.Enabled = maskForm.IsCompleted;
				ClearBtn.Enabled = maskForm.IsCompleted && (collectionPoints.OutsidePoints.Count > 0 || collectionPoints.InsidePoints.Count > 0);

				if (collectionPoints.InProgress)
				{
					UseWaitCursor = true;
					ApplyBtn.Text = Properties.Resources.Cancel;
					CancelMenuItem.Enabled = ApplyBtn.Enabled;
				}
				else
				{
					UseWaitCursor = false;
					ApplyBtn.Text = Properties.Resources.ApplyShow;
					CancelMenuItem.Enabled = false;
				}

				if (originImage != null)
				{
					ResolutionTextBox.Text = originImage.Width * originImage.Height + " pxl.  (" + originImage.Width + "x" + originImage.Height + ")";

					float ratio = collectionPoints.GetInsideRatio();

					if (ratio > 0 && originImage != null)
					{
						SquarePrcTextBox.Text = (ratio * 100) + "%";
						SquarePxlTextBox.Text = ratio * originImage.Width * originImage.Height + " pxl.";
					}
					else
					{
						SquarePrcTextBox.Text = "";
						SquarePxlTextBox.Text = "";
					}
				}
				else
				{
					ResolutionTextBox.Text	= "";
					SquarePrcTextBox.Text	= "";
					SquarePxlTextBox.Text	= "";
				}

				Refresh();
			}));
		}

		private void RefreshImage()
		{
			if (originImage != null)
			{
				DirectBitmap directmap = new DirectBitmap(originImage);

				using (var g = Graphics.FromImage(directmap.Bitmap))
				{
					foreach (Point p in collectionPoints.InsidePoints)
					{
						int radius = (int)sizePointNumeric.Value;
						g.FillEllipse(Brushes.Green, p.X - radius, p.Y - radius, radius * 2, radius * 2);
					}

					foreach (Point p in collectionPoints.OutsidePoints)
					{
						int radius = (int)sizePointNumeric.Value;
						g.FillEllipse(Brushes.Red, p.X - radius, p.Y - radius, radius * 2, radius * 2);
					}

					g.Save();
				};

				SetImage(directmap.Bitmap);
			}
			else
			{
				SetImage(null);
			}
		}

		private void GeneratePoints()
		{
			if (maskForm.IsCompleted)
			{
				if (collectionPoints.InProgress)
				{
					collectionPoints.Cancel();
				}
				else
				{
					collectionPoints.Clear();

					int amount = (int)pointsNumeric.Value;
					collectionPoints.GeneratePointAsync(maskForm, amount);

					RefreshStatus();
					RefreshImage();
				}
			}
		}

		private void ApplyBtn_Click(object sender, EventArgs e)
		{
			GeneratePoints();
		}

		private void SetProgressBar(int cur, int max)
		{
			Invoke(new Action(() =>
			{
				if (max >= 0)
				{
					progressBar.Maximum = max;
				}
				else
				{
					progressBar.Maximum = 0;
				}

				if (cur >= 0)
				{
					progressBar.Value = cur;
				}
				else
				{
					progressBar.Value = 0;
				}
			}));
		}

		private void SetImage(Image img)
		{
			Invoke(new Action(() =>
			{
				pictureBox.Image = img;
			}));
		}

		private void sizePointNumeric_ValueChanged(object sender, EventArgs e)
		{
			RefreshImage();
		}

		private void CencelMenuItem_Click(object sender, EventArgs e)
		{
			if (collectionPoints.InProgress)
			{
				collectionPoints.Cancel();
			}
		}

		private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
		{
			AboutForm af = new AboutForm();
			af.ShowDialog(this);
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			RefreshStatus();
		}

		private void ClearBtn_Click(object sender, EventArgs e)
		{
			collectionPoints.Clear();

			RefreshImage();
			RefreshStatus();
		}
	}
}
