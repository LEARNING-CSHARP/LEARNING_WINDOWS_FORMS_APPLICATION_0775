﻿namespace LEARNING_WINDOWS_FORMS_APPLICATION
{
	partial class MainForm
	{
		private System.ComponentModel.IContainer components = null;

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
			this.changeFormBackColorbutton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// changeFormBackColorbutton
			// 
			this.changeFormBackColorbutton.Location = new System.Drawing.Point(12, 12);
			this.changeFormBackColorbutton.Name = "changeFormBackColorbutton";
			this.changeFormBackColorbutton.Size = new System.Drawing.Size(355, 51);
			this.changeFormBackColorbutton.TabIndex = 0;
			this.changeFormBackColorbutton.Text = "Change Form BackColor";
			this.changeFormBackColorbutton.UseVisualStyleBackColor = true;
			this.changeFormBackColorbutton.Click += new System.EventHandler(this.ChangeFormBackColorbutton_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.SteelBlue;
			this.ClientSize = new System.Drawing.Size(379, 321);
			this.Controls.Add(this.changeFormBackColorbutton);
			this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Main";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button changeFormBackColorbutton;
	}
}
