using System;
using System.Drawing;
using System.Windows.Forms;

namespace MonteCarloApp
{
	public partial class AboutForm : Form
	{
		public AboutForm()
		{
			InitializeComponent();
		}

		private void AboutForm_Load(object sender, EventArgs e)
		{
			AboutTheProgramText.Text = Properties.Resources.AboutTheProgram;
			AboutTheProgramText.BackColor = Color.White;

			AboutTheAuthorText.Text = Properties.Resources.AboutTheAuthor;
		}
	}
}
