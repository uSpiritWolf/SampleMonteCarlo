﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MonteCarloS
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
