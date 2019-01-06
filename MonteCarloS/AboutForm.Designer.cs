namespace MonteCarloS
{
	partial class AboutForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.AboutTheProgramText = new System.Windows.Forms.RichTextBox();
			this.AboutTheProgramTitle = new System.Windows.Forms.Label();
			this.AboutTheAuthorText = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// AboutTheProgramText
			// 
			this.AboutTheProgramText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.AboutTheProgramText.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.AboutTheProgramText.Location = new System.Drawing.Point(2, 24);
			this.AboutTheProgramText.Name = "AboutTheProgramText";
			this.AboutTheProgramText.ReadOnly = true;
			this.AboutTheProgramText.Size = new System.Drawing.Size(780, 105);
			this.AboutTheProgramText.TabIndex = 0;
			this.AboutTheProgramText.Text = "This application demonstrates the Monte Carlo method.\nThe application opens an im" +
    "age with a closed shape then calculates the square through the Monte Carlo metho" +
    "d and shows result";
			// 
			// AboutTheProgramTitle
			// 
			this.AboutTheProgramTitle.AutoSize = true;
			this.AboutTheProgramTitle.Location = new System.Drawing.Point(-1, 8);
			this.AboutTheProgramTitle.Name = "AboutTheProgramTitle";
			this.AboutTheProgramTitle.Size = new System.Drawing.Size(97, 13);
			this.AboutTheProgramTitle.TabIndex = 1;
			this.AboutTheProgramTitle.Text = "About the program:";
			// 
			// AboutTheAuthorText
			// 
			this.AboutTheAuthorText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.AboutTheAuthorText.AutoSize = true;
			this.AboutTheAuthorText.Location = new System.Drawing.Point(512, 135);
			this.AboutTheAuthorText.Name = "AboutTheAuthorText";
			this.AboutTheAuthorText.Size = new System.Drawing.Size(270, 13);
			this.AboutTheAuthorText.TabIndex = 2;
			this.AboutTheAuthorText.Text = "Copyright (c) 2019, Alexey Chernykh. All rights reserved.";
			// 
			// AboutForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(788, 154);
			this.Controls.Add(this.AboutTheAuthorText);
			this.Controls.Add(this.AboutTheProgramTitle);
			this.Controls.Add(this.AboutTheProgramText);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "AboutForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "About";
			this.Load += new System.EventHandler(this.AboutForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.RichTextBox AboutTheProgramText;
		private System.Windows.Forms.Label AboutTheProgramTitle;
		private System.Windows.Forms.Label AboutTheAuthorText;
	}
}