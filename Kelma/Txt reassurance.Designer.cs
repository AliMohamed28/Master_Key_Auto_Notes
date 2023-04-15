using System.Collections;
using System.Collections.Generic;
/*
 * Created by SharpDevelop.
 * User: Ali Khattab
 * Date: 13/05/2018
 * Time: 21:42
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Kelma
{
	partial class Zodiac
	{
		
			long day;
			 long month;
			
	
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.label16 = new System.Windows.Forms.Label();
			this.dd = new System.Windows.Forms.RichTextBox();
			this.mm = new System.Windows.Forms.RichTextBox();
			this.label17 = new System.Windows.Forms.Label();
			this.label18 = new System.Windows.Forms.Label();
			this.Find = new System.Windows.Forms.Button();
			this.result = new System.Windows.Forms.RichTextBox();
			this.advice = new System.Windows.Forms.RichTextBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Trajan Pro 3", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Navy;
			this.label1.Location = new System.Drawing.Point(13, 262);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(116, 28);
			this.label1.TabIndex = 0;
			this.label1.Text = "Aries";
			this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.label1.Click += new System.EventHandler(this.Label1Click);
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Trajan Pro 3", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.Navy;
			this.label2.Location = new System.Drawing.Point(419, 291);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(129, 29);
			this.label2.TabIndex = 1;
			this.label2.Text = "Scorpio";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Trajan Pro 3", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.Navy;
			this.label3.Location = new System.Drawing.Point(23, 131);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(121, 54);
			this.label3.TabIndex = 2;
			this.label3.Text = "Gemnai";
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Trajan Pro 3", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.Navy;
			this.label4.Location = new System.Drawing.Point(422, 258);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(123, 33);
			this.label4.TabIndex = 3;
			this.label4.Text = "Cancer";
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Trajan Pro 3", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.Navy;
			this.label5.Location = new System.Drawing.Point(8, 301);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(136, 43);
			this.label5.TabIndex = 4;
			this.label5.Text = "Leo";
			this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Trajan Pro 3", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.Color.Navy;
			this.label6.Location = new System.Drawing.Point(13, 174);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(138, 43);
			this.label6.TabIndex = 5;
			this.label6.Text = "Aquaris";
			this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("Trajan Pro 3", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.ForeColor = System.Drawing.Color.Navy;
			this.label7.Location = new System.Drawing.Point(419, 329);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(123, 27);
			this.label7.TabIndex = 6;
			this.label7.Text = "Pisces";
			this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// label8
			// 
			this.label8.Font = new System.Drawing.Font("Trajan Pro 3", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.ForeColor = System.Drawing.Color.Navy;
			this.label8.Location = new System.Drawing.Point(8, 88);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(136, 43);
			this.label8.TabIndex = 7;
			this.label8.Text = "Libra";
			this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// label9
			// 
			this.label9.Font = new System.Drawing.Font("Trajan Pro 3", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.ForeColor = System.Drawing.Color.Navy;
			this.label9.Location = new System.Drawing.Point(416, 174);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(136, 43);
			this.label9.TabIndex = 8;
			this.label9.Text = "Virgo";
			this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// label10
			// 
			this.label10.Font = new System.Drawing.Font("Trajan Pro 3", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.ForeColor = System.Drawing.Color.Navy;
			this.label10.Location = new System.Drawing.Point(442, 88);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(94, 43);
			this.label10.TabIndex = 9;
			this.label10.Text = "Tarus";
			this.label10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// label11
			// 
			this.label11.Font = new System.Drawing.Font("Trajan Pro 3", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.ForeColor = System.Drawing.Color.Navy;
			this.label11.Location = new System.Drawing.Point(410, 131);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(170, 28);
			this.label11.TabIndex = 10;
			this.label11.Text = "Capricorn";
			this.label11.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// label12
			// 
			this.label12.Font = new System.Drawing.Font("Trajan Pro 3", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.ForeColor = System.Drawing.Color.Navy;
			this.label12.Location = new System.Drawing.Point(-4, 344);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(180, 33);
			this.label12.TabIndex = 11;
			this.label12.Text = "Sagittarius";
			this.label12.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// label13
			// 
			this.label13.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label13.ForeColor = System.Drawing.Color.Black;
			this.label13.Location = new System.Drawing.Point(8, 51);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(136, 37);
			this.label13.TabIndex = 12;
			this.label13.Text = "Air";
			this.label13.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// label14
			// 
			this.label14.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label14.ForeColor = System.Drawing.Color.Black;
			this.label14.Location = new System.Drawing.Point(42, 227);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(64, 37);
			this.label14.TabIndex = 13;
			this.label14.Text = "Fire";
			this.label14.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// label15
			// 
			this.label15.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label15.ForeColor = System.Drawing.Color.Black;
			this.label15.Location = new System.Drawing.Point(416, 227);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(136, 37);
			this.label15.TabIndex = 14;
			this.label15.Text = "Water";
			this.label15.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// label16
			// 
			this.label16.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label16.ForeColor = System.Drawing.Color.Black;
			this.label16.Location = new System.Drawing.Point(413, 48);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(136, 37);
			this.label16.TabIndex = 15;
			this.label16.Text = "Earth";
			this.label16.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// dd
			// 
			this.dd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dd.ForeColor = System.Drawing.Color.Blue;
			this.dd.Location = new System.Drawing.Point(237, 56);
			this.dd.Name = "dd";
			this.dd.Size = new System.Drawing.Size(36, 32);
			this.dd.TabIndex = 16;
			this.dd.Text = "";
			this.dd.TextChanged += new System.EventHandler(this.DdTextChanged);
			// 
			// mm
			// 
			this.mm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.mm.ForeColor = System.Drawing.Color.Blue;
			this.mm.Location = new System.Drawing.Point(237, 94);
			this.mm.Name = "mm";
			this.mm.Size = new System.Drawing.Size(36, 32);
			this.mm.TabIndex = 17;
			this.mm.Text = "";
			this.mm.TextChanged += new System.EventHandler(this.MmTextChanged);
			// 
			// label17
			// 
			this.label17.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label17.ForeColor = System.Drawing.Color.Black;
			this.label17.Location = new System.Drawing.Point(157, 60);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(74, 17);
			this.label17.TabIndex = 18;
			this.label17.Text = "Day";
			this.label17.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// label18
			// 
			this.label18.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label18.ForeColor = System.Drawing.Color.Black;
			this.label18.Location = new System.Drawing.Point(157, 98);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(74, 17);
			this.label18.TabIndex = 19;
			this.label18.Text = "Month";
			this.label18.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// Find
			// 
			this.Find.BackColor = System.Drawing.Color.Black;
			this.Find.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.Find.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Find.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.Find.Location = new System.Drawing.Point(280, 69);
			this.Find.Name = "Find";
			this.Find.Size = new System.Drawing.Size(117, 45);
			this.Find.TabIndex = 20;
			this.Find.Text = "Find!";
			this.Find.UseVisualStyleBackColor = false;
			this.Find.Click += new System.EventHandler(this.FindClick);
			// 
			// result
			// 
			this.result.BackColor = System.Drawing.Color.PaleTurquoise;
			this.result.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.result.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.result.Location = new System.Drawing.Point(197, 142);
			this.result.Name = "result";
			this.result.Size = new System.Drawing.Size(200, 36);
			this.result.TabIndex = 21;
			this.result.Text = "How to handle";
			// 
			// advice
			// 
			this.advice.BackColor = System.Drawing.Color.PaleTurquoise;
			this.advice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.advice.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.advice.Location = new System.Drawing.Point(182, 184);
			this.advice.Name = "advice";
			this.advice.Size = new System.Drawing.Size(234, 265);
			this.advice.TabIndex = 22;
			this.advice.Text = "";
			// 
			// Zodiac
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.MediumAquamarine;
			this.ClientSize = new System.Drawing.Size(584, 461);
			this.Controls.Add(this.advice);
			this.Controls.Add(this.result);
			this.Controls.Add(this.Find);
			this.Controls.Add(this.label18);
			this.Controls.Add(this.label17);
			this.Controls.Add(this.mm);
			this.Controls.Add(this.dd);
			this.Controls.Add(this.label16);
			this.Controls.Add(this.label15);
			this.Controls.Add(this.label14);
			this.Controls.Add(this.label13);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Zodiac";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Zodiac";
			this.Load += new System.EventHandler(this.ZodiacLoad);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.RichTextBox advice;
		private System.Windows.Forms.RichTextBox result;
		private System.Windows.Forms.Button Find;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.RichTextBox mm;
		private System.Windows.Forms.RichTextBox dd;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		
	
		
		void FindClick(object sender, System.EventArgs e)
		{	
			// MONTHS HARDCODE SHIT
		   if(mm.Text=="1")
			{
				month=1;
			}
		    if(mm.Text=="2")
			{
				month=2;
			}
		     if(mm.Text=="3")
			{
				month=3;
			}
		   if(mm.Text=="4")
			{
				month=4;
			}
		   if(mm.Text=="5")
			{
				month=5;
			}
		   
		   if(mm.Text=="6")
			{
				month=6;
			}
		   if(mm.Text=="7")
			{
				month=7;
			}
		   if(mm.Text=="8")
			{
				month=8;
			}
		   if(mm.Text=="9")
			{
				month=9;
			}
		   if(mm.Text=="9")
			{
				month=9;
			}
		   if(mm.Text=="9")
			{
				month=9;
			}
		   if(mm.Text=="10")
			{
				month=10;
			}
		   
		      if(mm.Text=="11")
			{
				month=11;
			}
		      if(mm.Text=="12")
			{
				month=12;
			}  
		   // MONTHS HARDCODE SHIT
		   
		   
		   //Days
		   if(dd.Text=="1")
			{
				day=1;
			}  
		   if(dd.Text=="2")
			{
				day=2;
			}  
		   if(dd.Text=="3")
			{
				day=3;
			}  
		   if(dd.Text=="4")
			{
				day=4;
			}  
		   if(dd.Text=="5")
			{
				day=5;
			}  
		   if(dd.Text=="6")
			{
				day=6;
			}  
		   if(dd.Text=="7")
			{
				day=7;
			}  
		   if(dd.Text=="8")
			{
				day=8;
			}  
		   if(dd.Text=="9")
			{
				day=9;
			}  
		   if(dd.Text=="10")
			{
				day=10;
			}  
		   if(dd.Text=="11")
			{
				day=11;
			}  
		   if(dd.Text=="12")
			{
				day=12;
			}  
		   if(dd.Text=="13")
			{
				day=13;
			}  
		   if(dd.Text=="14")
			{
				day=14;
			}  
		   if(dd.Text=="15")
			{
				day=15;
			}  
		   if(dd.Text=="16")
			{
				day=16;
			}  
		   if(dd.Text=="17")
			{
				day=17;
			}  
		   if(dd.Text=="18")
			{
				day=18;
			}  
		   if(dd.Text=="19")
			{
				day=19;
			}  
		   if(dd.Text=="20")
			{
				day=20;
			}  
		   if(dd.Text=="21")
			{
				day=21;
			}  
		   if(dd.Text=="22")
			{
				day=22;
			}  
		   if(dd.Text=="23")
			{
				day=23;
			}  
		   if(dd.Text=="24")
			{
				day=24;
			}  
		   if(dd.Text=="25")
			{
				day=25;
			}  
		   if(dd.Text=="26")
			{
				day=26;
			}  
		   if(dd.Text=="27")
			{
				day=27;
			}  
		   if(dd.Text=="28")
			{
				day=28;
			}  
		   if(dd.Text=="29")
			{
				day=29;
			}  
		   if(dd.Text=="30")
			{
				day=30;
			}  
		   
		   //Days

			
			if(month==1) // Aquaris
			{
				if(day<=20)
				{
					result.Clear();
					result.Text+="Aquaris";
					advice.Clear();
					advice.Text+="keep up with their very fast and broad mind , you need to have general knowledge and wisdom , and to be able to be out of the box creative individual ,Be quirky <<having or characterized by peculiar or unexpected traits or aspects.>>, be a loyal friend ,carfeul they are extremly unpredictable ";
					
					
				}
			}
			
			if(month==2) // Aquaris
			{
				if(day<=18)
				{
					result.Clear();
					result.Text+="Aquaris";
					advice.Clear();
					advice.Text+="keep up with their very fast and broad mind , you need to have general knowledge and wisdom , and to be able to be out of the box creative individual ,Be quirky <<having or characterized by peculiar or unexpected traits or aspects.>>, be a loyal friend ,carfeul they are extremly unpredictable ";
				}
			}
			
			
			
			if(month==2) // Pisces
			{
				if(day>18)
				{
					if(day<=28)
					{
					result.Clear();
					result.Text+="Pisces";
					advice.Clear();
					advice.Text+="Be senstive , compassionate,don tell the truth in harsh way,show vulnerable side, be different pisces like everything that doesn't fit in a box ";
					}
				}
			}
			
			if(month==3) // Pisces
			{
				if(day<=20)
				{
					result.Clear();
					result.Text+="Pisces";
										advice.Clear();
					advice.Text+="Be senstive , compassionate,don tell the truth in harsh way,show vulnerable side, be different pisces like everything that doesn't fit in a box ";
				}
			}
			
			if(month==3) // Aries
			{
				if(day>20)
				{
					if(day<=30)
					{
					result.Clear();
					result.Text+="Aries";
					advice.Clear();
					advice.Text+="Be brutally honest with Aries ,be distant , make them try , the more they do the more they like you ,engage them and make them work with you ,be their friend";
					}
				}
			}
			
			if(month==4) // Aries
			{
				if(day<=19)
				{
					result.Clear();
					result.Text+="Aries";
					advice.Clear();
					advice.Text+="Be brutally honest with Aries ,be distant , make them try , the more they do the more they like you ,engage them and make them work with you ,be their friend";
				}
			}
			
			if(month==4) // Taurus
			{
				if(day>19)
				{
					if(day<=30)
					{
					result.Clear();
					result.Text+="Taurus";
					advice.Clear();
					advice.Text+="be proactive they are shy, you need to be the one who take actions, and be depenaple ,be fun , be lovable";
					}
				}
			}
			
			if(month==5) // Taurus
			{
				if(day<=20)
				{
					result.Clear();
					result.Text+="Taurus";
					advice.Clear();
					advice.Text+="be proactive they are shy, you need to be the one who take actions, and be depenaple ,be fun , be lovable";
				}
			}
			
			if(month==5) // Gemini
			{
				if(day>20)
				{
					if(day<=31)
					{
					result.Clear();
					result.Text+="Gemini";
					advice.Clear();
					advice.Text+="Show pleasentness, and keep the conversation bouncing , be spontaneous and witty , be critical yet carfeul still advocate , show them you can interest them , talk about new offers , Be Deep ";
					}
				}
			}
			
			if(month==6) // Gemini
			{
				if(day<=20)
				{
					result.Clear();
					result.Text+="Gemini";
					advice.Clear();
					advice.Text+="Show pleasentness, and keep the conversation bouncing , be spontaneous and witty , be critical yet carfeul still advocate , show them you can interest them , talk about new offers , Be Deep ";
				}
			}
			
		
			if(month==6) // Cancer
			{
				if(day>20)
				{
					if(day<=31)
					{
					result.Clear();
					result.Text+="Cancer";
					advice.Clear();
					advice.Text+="Be familiy orianted , don't make them go to the store , they like to chill especially in weeknds , take care of them they are the most emotional signs! ";
					}
				}
			}
			
			if(month==7) // Cancer
			{
				if(day<=22)
				{
					result.Clear();
					result.Text+="Cancer";
					advice.Clear();
					advice.Text+="Be familiy orianted , don't make them go to the store , they like to chill especially in weeknds , take care of them they are the most emotional signs! ";
						
				}
			}			
			
			
			
			if(month==7) // Leo
			{
				if(day>22)
				{
					if(day<=31)
					{
					result.Clear();
					result.Text+="Leo";
					advice.Clear();
					advice.Text+="you need to sound good ,you need to have a nice image, appreciate yourself ,and have self confidence , you need to appreciate them, you shouldn't critise them , show respect for what they've done,you need to be fun ";
						
					}
				}
			}
			
			if(month==8) // Leo
			{
				if(day<=22)
				{
					result.Clear();
					result.Text+="Leo";
					advice.Clear();
					advice.Text+="you need to sound good ,you need to have a nice image, appreciate yourself ,and have self confidence , you need to appreciate them, you shouldn't critise them , show respect for what they've done,you need to be fun ";
				}
			}		

			if(month==8) // Virgo
			{
				if(day>22)
				{
					if(day<=31)
					{
					result.Clear();
					result.Text+="Virgo";
					advice.Clear();
					advice.Text+="accept their critisim even if they are bitchy , because they are right , they like neat and organised conversations, they are perfectionist , they love details , if they really care they critisie ,don't impose your opionions on them and careful don't give them negative vibe, "; 
					}
				}
			}
			
			if(month==9) // Virgo
			{
				if(day<=22)
				{
					result.Clear();
					result.Text+="Virgo";
					advice.Clear();
					advice.Text+="accept their critisim even if they are bitchy , because they are right , they like neat and organised conversations, they are perfectionist , they love details , if they really care they critisie ,don't impose your opionions on them and careful don't give them negative vibe, "; 
						
				}
			}		

				if(month==9) // Libra
			{
				if(day>22)
				{
					if(day<=31)
					{
					result.Clear();
					result.Text+="Libra";
					advice.Clear();
					advice.Text+="Be attractive in a balanced way, they like harmony ,make them feel good in your presence , they are foucused on dialog and human interaction ,take them to social events , They LOVE compliments ,they are insecure sometimes , so boast their vipe and value  their intellect ";
					}
				}
			}
			
			if(month==10) // Libra
			{
				if(day<=22)
				{
					result.Clear();
					result.Text+="Libra";
					
					advice.Clear();
					advice.Text+="Be attractive in a balanced way, they like harmony ,make them feel good in your presence , they are foucused on dialog and human interaction ,take them to social events , They LOVE compliments ,they are insecure sometimes , so boast their vipe and value  their intellect ";
							}
			
			
			}	
			if(month==10) // Scorpio
			{
				if(day>22)
				{
					if(day<=31)
					{
					result.Clear();
					result.Text+="Scorpio";
					advice.Clear();
					advice.Text+="The Whole trick they can read you , so be genuine and nice ,you need to be honest , Care ,  ";
					}
				}
			}
			
			if(month==11) // Scorpio
			{
				if(day<=21)
				{
					result.Clear();
					result.Text+="Scorpio";
					advice.Clear();
					advice.Text+="The Whole trick they can read you , so be genuine and nice ,you need to be honest , Care ,  ";
				}
				
			}
				
				if(month==11) // Sagittarius
			{
				if(day>21)
				{
					if(day<=31)
					{
					result.Clear();
					result.Text+="Sagittarius";
							advice.Clear();
					advice.Text+="be different they love diversity, be exotic , if your are not : be open , Exchange idea ,don't try to control them , ";
					}
				}
			}
			
			if(month==12) // Sagittarius
			{
				if(day<=21)
				{
					result.Clear();
					result.Text+="Sagittarius";
							advice.Clear();
					advice.Text+="be different they love diversity, be exotic , if your are not : be open , Exchange idea ,don't try to control them , ";
					
				}
			}
				if(month==12) // Capricorn
			{
				if(day>21)
				{
					if(day<=31)
					{
					result.Clear();
					result.Text+="Capricorn";
					advice.Clear();
					advice.Text+="Have your own prespective, be decent, show them you need them they love responsiblity , show them your sweet warm hearted, they like surprises ";
					}
				}
			}
			
			if(month==1) // Capricorn
			{
				if(day<=19)
				{
					result.Clear();
					result.Text+="Capricorn";
					advice.Clear();
					advice.Text+="Have your own prespective, be decent, show them you need them they love responsiblity , show them your sweet warm hearted, they like surprises ";
				}
			}
				
				
		}
		
		void DdTextChanged(object sender, System.EventArgs e)
		{	
		}
		
		void MmTextChanged(object sender, System.EventArgs e)
		{
			
		}
	}
}
