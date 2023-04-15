/*
 * Created by SharpDevelop.
 * User: Ali Khattab
 * Date: 24/04/2018
 * Time: 15:44
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Kelma
{
	partial class notewrap
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.linkat = new System.Windows.Forms.Label();
			this.not = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.tmp = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// linkat
			// 
			this.linkat.BackColor = System.Drawing.Color.MediumTurquoise;
			this.linkat.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.linkat.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.linkat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.linkat.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.linkat.ForeColor = System.Drawing.Color.Black;
			this.linkat.Location = new System.Drawing.Point(121, 170);
			this.linkat.Name = "linkat";
			this.linkat.Size = new System.Drawing.Size(271, 53);
			this.linkat.TabIndex = 19;
			this.linkat.Text = "Agent Links";
			this.linkat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.linkat.Click += new System.EventHandler(this.LinkatClick);
			// 
			// not
			// 
			this.not.BackColor = System.Drawing.Color.DeepSkyBlue;
			this.not.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.not.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.not.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.not.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.not.ForeColor = System.Drawing.Color.Black;
			this.not.Location = new System.Drawing.Point(121, 33);
			this.not.Name = "not";
			this.not.Size = new System.Drawing.Size(271, 53);
			this.not.TabIndex = 20;
			this.not.Text = "Notes and wrap-ups";
			this.not.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.not.Click += new System.EventHandler(this.NotClick);
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.PaleTurquoise;
			this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label2.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.label2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.Black;
			this.label2.Location = new System.Drawing.Point(121, 101);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(271, 53);
			this.label2.TabIndex = 21;
			this.label2.Text = "Text Reasurrance";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.label2.Click += new System.EventHandler(this.Label2Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
			this.label1.Location = new System.Drawing.Point(354, 318);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(114, 51);
			this.label1.TabIndex = 22;
			this.label1.Text = "Powered by :\r\nAli Khattab\r\nCaroline Geirguis";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.label1.Click += new System.EventHandler(this.Label1Click);
			// 
			// tmp
			// 
			this.tmp.BackColor = System.Drawing.Color.LightSeaGreen;
			this.tmp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.tmp.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.tmp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.tmp.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tmp.ForeColor = System.Drawing.Color.Black;
			this.tmp.Location = new System.Drawing.Point(121, 245);
			this.tmp.Name = "tmp";
			this.tmp.Size = new System.Drawing.Size(271, 53);
			this.tmp.TabIndex = 23;
			this.tmp.Text = "Templates";
			this.tmp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.tmp.Click += new System.EventHandler(this.TmpClick);
			// 
			// notewrap
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.BackColor = System.Drawing.Color.PapayaWhip;
			this.BackgroundImage = global::Kelma.Properties.Resources.BK;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(471, 383);
			this.Controls.Add(this.tmp);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.not);
			this.Controls.Add(this.linkat);
			this.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.DoubleBuffered = true;
			this.ForeColor = System.Drawing.Color.Transparent;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Location = new System.Drawing.Point(300, 0);
			this.MaximizeBox = false;
			this.MinimumSize = new System.Drawing.Size(300, 300);
			this.Name = "notewrap";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Master key";
			this.Load += new System.EventHandler(this.Form1Load);
			this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.d);
			this.ResumeLayout(false);
			this.PerformLayout();
        }
		private System.Windows.Forms.Label tmp;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label not;
		private System.Windows.Forms.Label linkat;
		
		void KelmaTextChanged(object sender, System.EventArgs e)
		{

        }

        private System.Windows.Forms.Label label1;
		
		void MailsClick(object sender, System.EventArgs e)
		{
			 System.Diagnostics.Process.Start("emails.docx");				
		}
	}
}
