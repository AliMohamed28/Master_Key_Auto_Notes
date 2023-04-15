/*
 * Created by SharpDevelop.
 * User: Ali Khattab
 * Date: 14/05/2018
 * Time: 13:11
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Kelma
{
	partial class Tarrifupdate
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
			this.body = new System.Windows.Forms.RichTextBox();
			this.billdue = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.pay = new System.Windows.Forms.Button();
			this.shock = new System.Windows.Forms.Button();
			this.dd = new System.Windows.Forms.Button();
			this.service1 = new System.Windows.Forms.Button();
			this.services = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.mig = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.travel = new System.Windows.Forms.Button();
			this.add1gb = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.add3gb = new System.Windows.Forms.Button();
			this.moremins = new System.Windows.Forms.Button();
			this.missingpay = new System.Windows.Forms.Button();
			this.skysports = new System.Windows.Forms.Button();
			this.spotify = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.followup = new System.Windows.Forms.Button();
			this.raisecase = new System.Windows.Forms.Button();
			this.eom = new System.Windows.Forms.Button();
			this.get = new System.Windows.Forms.Button();
			this.in1 = new System.Windows.Forms.Button();
			this.in2 = new System.Windows.Forms.Button();
			this.in3 = new System.Windows.Forms.Button();
			this.in4 = new System.Windows.Forms.Button();
			this.due = new System.Windows.Forms.TextBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.joker = new System.Windows.Forms.TextBox();
			this.r1 = new System.Windows.Forms.RadioButton();
			this.r2 = new System.Windows.Forms.RadioButton();
			this.r3 = new System.Windows.Forms.RadioButton();
			this.rhint = new System.Windows.Forms.Label();
			this.Country = new System.Windows.Forms.TextBox();
			this.rdcnct = new System.Windows.Forms.RadioButton();
			this.rd30 = new System.Windows.Forms.RadioButton();
			this.simplsmart = new System.Windows.Forms.RadioButton();
			this.tup = new System.Windows.Forms.Button();
			this.mavod = new System.Windows.Forms.Button();
			this.radioButton1 = new System.Windows.Forms.RadioButton();
			this.radioButton2 = new System.Windows.Forms.RadioButton();
			this.radioButton3 = new System.Windows.Forms.RadioButton();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.bar = new System.Windows.Forms.Button();
			this.Back = new System.Windows.Forms.Button();
			this.refundd = new System.Windows.Forms.Button();
			this.popayment = new System.Windows.Forms.Button();
			this.Dpo = new System.Windows.Forms.Button();
			this.addresses = new System.Windows.Forms.Label();
			this.unsub = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// body
			// 
			this.body.BackColor = System.Drawing.Color.MintCream;
			this.body.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.body.Location = new System.Drawing.Point(148, 39);
			this.body.Name = "body";
			this.body.Size = new System.Drawing.Size(409, 416);
			this.body.TabIndex = 0;
			this.body.Text = "  ";
			this.body.TextChanged += new System.EventHandler(this.BodyTextChanged);
			// 
			// billdue
			// 
			this.billdue.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.billdue.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.billdue.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.billdue.ForeColor = System.Drawing.Color.Black;
			this.billdue.Location = new System.Drawing.Point(24, 47);
			this.billdue.Name = "billdue";
			this.billdue.Size = new System.Drawing.Size(107, 49);
			this.billdue.TabIndex = 1;
			this.billdue.Text = "Bill Due Date";
			this.billdue.UseVisualStyleBackColor = false;
			this.billdue.Click += new System.EventHandler(this.BilldueClick);
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(46, 20);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(73, 27);
			this.label1.TabIndex = 2;
			this.label1.Text = "Billing";
			// 
			// pay
			// 
			this.pay.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.pay.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.pay.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.pay.ForeColor = System.Drawing.Color.Black;
			this.pay.Location = new System.Drawing.Point(24, 97);
			this.pay.Name = "pay";
			this.pay.Size = new System.Drawing.Size(107, 33);
			this.pay.TabIndex = 3;
			this.pay.Text = "Payment";
			this.pay.UseVisualStyleBackColor = false;
			this.pay.Click += new System.EventHandler(this.PayClick);
			// 
			// shock
			// 
			this.shock.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.shock.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.shock.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.shock.ForeColor = System.Drawing.Color.Black;
			this.shock.Location = new System.Drawing.Point(24, 165);
			this.shock.Name = "shock";
			this.shock.Size = new System.Drawing.Size(107, 33);
			this.shock.TabIndex = 4;
			this.shock.Text = "Bill Shock";
			this.shock.UseVisualStyleBackColor = false;
			this.shock.Click += new System.EventHandler(this.Button3Click);
			// 
			// dd
			// 
			this.dd.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.dd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.dd.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dd.ForeColor = System.Drawing.Color.Black;
			this.dd.Location = new System.Drawing.Point(24, 131);
			this.dd.Name = "dd";
			this.dd.Size = new System.Drawing.Size(107, 33);
			this.dd.TabIndex = 4;
			this.dd.Text = "Direct Debit";
			this.dd.UseVisualStyleBackColor = false;
			this.dd.Click += new System.EventHandler(this.DdClick);
			// 
			// service1
			// 
			this.service1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.service1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.service1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.service1.ForeColor = System.Drawing.Color.Black;
			this.service1.Location = new System.Drawing.Point(24, 411);
			this.service1.Name = "service1";
			this.service1.Size = new System.Drawing.Size(107, 33);
			this.service1.TabIndex = 5;
			this.service1.Text = "End Date";
			this.service1.UseVisualStyleBackColor = false;
			this.service1.Click += new System.EventHandler(this.Service1Click);
			// 
			// services
			// 
			this.services.BackColor = System.Drawing.Color.Transparent;
			this.services.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.services.ForeColor = System.Drawing.Color.Transparent;
			this.services.Location = new System.Drawing.Point(32, 256);
			this.services.Name = "services";
			this.services.Size = new System.Drawing.Size(99, 20);
			this.services.TabIndex = 6;
			this.services.Text = "Contract";
			this.services.Click += new System.EventHandler(this.ServicesClick);
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.ForeColor = System.Drawing.Color.Black;
			this.button1.Location = new System.Drawing.Point(24, 377);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(107, 33);
			this.button1.TabIndex = 7;
			this.button1.Text = "Upgrade";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// mig
			// 
			this.mig.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.mig.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.mig.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.mig.ForeColor = System.Drawing.Color.Black;
			this.mig.Location = new System.Drawing.Point(24, 330);
			this.mig.Name = "mig";
			this.mig.Size = new System.Drawing.Size(107, 46);
			this.mig.TabIndex = 8;
			this.mig.Text = "Prepay Migration";
			this.mig.UseVisualStyleBackColor = false;
			this.mig.Click += new System.EventHandler(this.MigClick);
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.Transparent;
			this.label2.Location = new System.Drawing.Point(583, 20);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(88, 20);
			this.label2.TabIndex = 10;
			this.label2.Text = "Addon";
			// 
			// travel
			// 
			this.travel.BackColor = System.Drawing.Color.White;
			this.travel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.travel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.travel.ForeColor = System.Drawing.Color.Black;
			this.travel.Location = new System.Drawing.Point(571, 493);
			this.travel.Name = "travel";
			this.travel.Size = new System.Drawing.Size(107, 27);
			this.travel.TabIndex = 11;
			this.travel.Text = "Roaming";
			this.travel.UseVisualStyleBackColor = false;
			this.travel.Click += new System.EventHandler(this.TravelClick);
			// 
			// add1gb
			// 
			this.add1gb.BackColor = System.Drawing.Color.White;
			this.add1gb.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.add1gb.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.add1gb.ForeColor = System.Drawing.Color.Black;
			this.add1gb.Location = new System.Drawing.Point(571, 50);
			this.add1gb.Name = "add1gb";
			this.add1gb.Size = new System.Drawing.Size(107, 29);
			this.add1gb.TabIndex = 12;
			this.add1gb.Text = "1 GB addon";
			this.add1gb.UseVisualStyleBackColor = false;
			this.add1gb.Click += new System.EventHandler(this.Add1gbClick);
			// 
			// button3
			// 
			this.button3.BackColor = System.Drawing.Color.White;
			this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button3.ForeColor = System.Drawing.Color.Black;
			this.button3.Location = new System.Drawing.Point(571, 46);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(107, 33);
			this.button3.TabIndex = 12;
			this.button3.Text = "1 GB addon";
			this.button3.UseVisualStyleBackColor = false;
			this.button3.Click += new System.EventHandler(this.Add1gbClick);
			// 
			// add3gb
			// 
			this.add3gb.BackColor = System.Drawing.Color.White;
			this.add3gb.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.add3gb.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.add3gb.ForeColor = System.Drawing.Color.Black;
			this.add3gb.Location = new System.Drawing.Point(571, 80);
			this.add3gb.Name = "add3gb";
			this.add3gb.Size = new System.Drawing.Size(107, 33);
			this.add3gb.TabIndex = 13;
			this.add3gb.Text = "3 GB addon";
			this.add3gb.UseVisualStyleBackColor = false;
			this.add3gb.Click += new System.EventHandler(this.Add3gbClick);
			// 
			// moremins
			// 
			this.moremins.BackColor = System.Drawing.Color.White;
			this.moremins.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.moremins.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.moremins.ForeColor = System.Drawing.Color.Black;
			this.moremins.Location = new System.Drawing.Point(571, 114);
			this.moremins.Name = "moremins";
			this.moremins.Size = new System.Drawing.Size(107, 46);
			this.moremins.TabIndex = 14;
			this.moremins.Text = "Minutes add on";
			this.moremins.UseVisualStyleBackColor = false;
			this.moremins.Click += new System.EventHandler(this.MoreminsClick);
			// 
			// missingpay
			// 
			this.missingpay.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.missingpay.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.missingpay.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.missingpay.ForeColor = System.Drawing.Color.Black;
			this.missingpay.Location = new System.Drawing.Point(24, 199);
			this.missingpay.Name = "missingpay";
			this.missingpay.Size = new System.Drawing.Size(107, 48);
			this.missingpay.TabIndex = 15;
			this.missingpay.Text = "Missing Payment";
			this.missingpay.UseVisualStyleBackColor = false;
			this.missingpay.Click += new System.EventHandler(this.MissingpayClick);
			// 
			// skysports
			// 
			this.skysports.BackColor = System.Drawing.Color.White;
			this.skysports.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.skysports.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.skysports.ForeColor = System.Drawing.Color.Black;
			this.skysports.Location = new System.Drawing.Point(571, 255);
			this.skysports.Name = "skysports";
			this.skysports.Size = new System.Drawing.Size(107, 30);
			this.skysports.TabIndex = 17;
			this.skysports.Text = "Skysports";
			this.skysports.UseVisualStyleBackColor = false;
			this.skysports.Click += new System.EventHandler(this.SkysportsClick);
			// 
			// spotify
			// 
			this.spotify.BackColor = System.Drawing.Color.White;
			this.spotify.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.spotify.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.spotify.ForeColor = System.Drawing.Color.Black;
			this.spotify.Location = new System.Drawing.Point(571, 225);
			this.spotify.Name = "spotify";
			this.spotify.Size = new System.Drawing.Size(107, 29);
			this.spotify.TabIndex = 18;
			this.spotify.Text = "Spotify";
			this.spotify.UseVisualStyleBackColor = false;
			this.spotify.Click += new System.EventHandler(this.SpotifyClick);
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.Transparent;
			this.label3.Location = new System.Drawing.Point(583, 322);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(88, 20);
			this.label3.TabIndex = 19;
			this.label3.Text = "Actions";
			// 
			// followup
			// 
			this.followup.BackColor = System.Drawing.Color.White;
			this.followup.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.followup.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.followup.ForeColor = System.Drawing.Color.Black;
			this.followup.Location = new System.Drawing.Point(571, 466);
			this.followup.Name = "followup";
			this.followup.Size = new System.Drawing.Size(107, 26);
			this.followup.TabIndex = 20;
			this.followup.Text = "Follow up";
			this.followup.UseVisualStyleBackColor = false;
			this.followup.Click += new System.EventHandler(this.FollowupClick);
			// 
			// raisecase
			// 
			this.raisecase.BackColor = System.Drawing.Color.White;
			this.raisecase.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.raisecase.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.raisecase.ForeColor = System.Drawing.Color.Black;
			this.raisecase.Location = new System.Drawing.Point(571, 346);
			this.raisecase.Name = "raisecase";
			this.raisecase.Size = new System.Drawing.Size(107, 30);
			this.raisecase.TabIndex = 22;
			this.raisecase.Text = "Raise case";
			this.raisecase.UseVisualStyleBackColor = false;
			this.raisecase.Click += new System.EventHandler(this.RaisecaseClick);
			// 
			// eom
			// 
			this.eom.BackColor = System.Drawing.Color.White;
			this.eom.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.eom.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.eom.ForeColor = System.Drawing.Color.Black;
			this.eom.Location = new System.Drawing.Point(571, 434);
			this.eom.Name = "eom";
			this.eom.Size = new System.Drawing.Size(107, 31);
			this.eom.TabIndex = 23;
			this.eom.Text = "TL Call Back";
			this.eom.UseVisualStyleBackColor = false;
			this.eom.Click += new System.EventHandler(this.EomClick);
			// 
			// get
			// 
			this.get.BackColor = System.Drawing.Color.Black;
			this.get.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.get.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.get.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.get.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.get.Location = new System.Drawing.Point(233, 607);
			this.get.Name = "get";
			this.get.Size = new System.Drawing.Size(270, 58);
			this.get.TabIndex = 25;
			this.get.Text = "Copy";
			this.get.UseVisualStyleBackColor = false;
			this.get.Click += new System.EventHandler(this.GetClick);
			// 
			// in1
			// 
			this.in1.BackColor = System.Drawing.Color.DarkOrange;
			this.in1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.in1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.in1.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.in1.Location = new System.Drawing.Point(571, 580);
			this.in1.Name = "in1";
			this.in1.Size = new System.Drawing.Size(87, 35);
			this.in1.TabIndex = 40;
			this.in1.Text = "Generate";
			this.in1.UseVisualStyleBackColor = false;
			this.in1.Visible = false;
			this.in1.Click += new System.EventHandler(this.In1Click);
			// 
			// in2
			// 
			this.in2.BackColor = System.Drawing.Color.DarkOrange;
			this.in2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.in2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.in2.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.in2.Location = new System.Drawing.Point(606, 621);
			this.in2.Name = "in2";
			this.in2.Size = new System.Drawing.Size(87, 35);
			this.in2.TabIndex = 42;
			this.in2.Text = "Generate";
			this.in2.UseVisualStyleBackColor = false;
			this.in2.Visible = false;
			this.in2.Click += new System.EventHandler(this.In2Click);
			// 
			// in3
			// 
			this.in3.BackColor = System.Drawing.Color.DarkOrange;
			this.in3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.in3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.in3.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.in3.Location = new System.Drawing.Point(571, 607);
			this.in3.Name = "in3";
			this.in3.Size = new System.Drawing.Size(87, 35);
			this.in3.TabIndex = 43;
			this.in3.Text = "Generate";
			this.in3.UseVisualStyleBackColor = false;
			this.in3.Visible = false;
			this.in3.Click += new System.EventHandler(this.In3Click);
			// 
			// in4
			// 
			this.in4.BackColor = System.Drawing.Color.DarkOrange;
			this.in4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.in4.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.in4.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.in4.Location = new System.Drawing.Point(571, 607);
			this.in4.Name = "in4";
			this.in4.Size = new System.Drawing.Size(87, 35);
			this.in4.TabIndex = 44;
			this.in4.Text = "Generate";
			this.in4.UseVisualStyleBackColor = false;
			this.in4.Visible = false;
			this.in4.Click += new System.EventHandler(this.In4Click);
			// 
			// due
			// 
			this.due.BackColor = System.Drawing.Color.PapayaWhip;
			this.due.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.due.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.due.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.due.Location = new System.Drawing.Point(241, 487);
			this.due.Multiline = true;
			this.due.Name = "due";
			this.due.Size = new System.Drawing.Size(105, 32);
			this.due.TabIndex = 31;
			this.due.Visible = false;
			this.due.TextChanged += new System.EventHandler(this.DueTextChanged);
			// 
			// textBox1
			// 
			this.textBox1.BackColor = System.Drawing.Color.PapayaWhip;
			this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.textBox1.Location = new System.Drawing.Point(365, 487);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(77, 32);
			this.textBox1.TabIndex = 32;
			this.textBox1.Visible = false;
			this.textBox1.TextChanged += new System.EventHandler(this.TextBox2TextChanged);
			// 
			// joker
			// 
			this.joker.BackColor = System.Drawing.Color.MediumAquamarine;
			this.joker.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.joker.Font = new System.Drawing.Font("Myriad Hebrew", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.joker.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.joker.Location = new System.Drawing.Point(243, 465);
			this.joker.Name = "joker";
			this.joker.ReadOnly = true;
			this.joker.Size = new System.Drawing.Size(201, 20);
			this.joker.TabIndex = 41;
			this.joker.Text = "input1                              input2";
			this.joker.Visible = false;
			this.joker.TextChanged += new System.EventHandler(this.JokerTextChanged);
			// 
			// r1
			// 
			this.r1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.r1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.r1.Location = new System.Drawing.Point(317, 461);
			this.r1.Name = "r1";
			this.r1.Size = new System.Drawing.Size(76, 24);
			this.r1.TabIndex = 45;
			this.r1.TabStop = true;
			this.r1.Text = "EU";
			this.r1.UseVisualStyleBackColor = true;
			this.r1.Visible = false;
			this.r1.CheckedChanged += new System.EventHandler(this.R1CheckedChanged);
			// 
			// r2
			// 
			this.r2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.r2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.r2.Location = new System.Drawing.Point(317, 491);
			this.r2.Name = "r2";
			this.r2.Size = new System.Drawing.Size(76, 24);
			this.r2.TabIndex = 46;
			this.r2.TabStop = true;
			this.r2.Text = "2.99";
			this.r2.UseVisualStyleBackColor = true;
			this.r2.Visible = false;
			this.r2.CheckedChanged += new System.EventHandler(this.R2CheckedChanged);
			// 
			// r3
			// 
			this.r3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.r3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.r3.Location = new System.Drawing.Point(317, 517);
			this.r3.Name = "r3";
			this.r3.Size = new System.Drawing.Size(78, 24);
			this.r3.TabIndex = 47;
			this.r3.TabStop = true;
			this.r3.Text = "4.99";
			this.r3.UseVisualStyleBackColor = true;
			this.r3.Visible = false;
			this.r3.CheckedChanged += new System.EventHandler(this.R3CheckedChanged);
			// 
			// rhint
			// 
			this.rhint.BackColor = System.Drawing.Color.Transparent;
			this.rhint.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rhint.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.rhint.Location = new System.Drawing.Point(139, 480);
			this.rhint.Name = "rhint";
			this.rhint.Size = new System.Drawing.Size(172, 39);
			this.rhint.TabIndex = 48;
			this.rhint.Text = "Select Roaming option acording to the country\r\n";
			this.rhint.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.rhint.Visible = false;
			this.rhint.Click += new System.EventHandler(this.RhintClick);
			// 
			// Country
			// 
			this.Country.BackColor = System.Drawing.Color.PapayaWhip;
			this.Country.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.Country.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Country.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.Country.Location = new System.Drawing.Point(387, 487);
			this.Country.Multiline = true;
			this.Country.Name = "Country";
			this.Country.Size = new System.Drawing.Size(67, 32);
			this.Country.TabIndex = 49;
			this.Country.Text = "Country";
			this.Country.Visible = false;
			// 
			// rdcnct
			// 
			this.rdcnct.BackColor = System.Drawing.Color.LightGray;
			this.rdcnct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rdcnct.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.rdcnct.Location = new System.Drawing.Point(187, 559);
			this.rdcnct.Name = "rdcnct";
			this.rdcnct.Size = new System.Drawing.Size(172, 42);
			this.rdcnct.TabIndex = 50;
			this.rdcnct.TabStop = true;
			this.rdcnct.Text = "RED Connect 12 Month";
			this.rdcnct.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.rdcnct.UseVisualStyleBackColor = false;
			this.rdcnct.Visible = false;
			this.rdcnct.CheckedChanged += new System.EventHandler(this.RdcnctCheckedChanged);
			// 
			// rd30
			// 
			this.rd30.BackColor = System.Drawing.Color.LightGray;
			this.rd30.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rd30.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.rd30.Location = new System.Drawing.Point(187, 510);
			this.rd30.Name = "rd30";
			this.rd30.Size = new System.Drawing.Size(172, 42);
			this.rd30.TabIndex = 52;
			this.rd30.TabStop = true;
			this.rd30.Text = "RED 30 Day";
			this.rd30.UseVisualStyleBackColor = false;
			this.rd30.Visible = false;
			this.rd30.CheckedChanged += new System.EventHandler(this.Rd30CheckedChanged);
			// 
			// simplsmart
			// 
			this.simplsmart.BackColor = System.Drawing.Color.LightGray;
			this.simplsmart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.simplsmart.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.simplsmart.Location = new System.Drawing.Point(187, 461);
			this.simplsmart.Name = "simplsmart";
			this.simplsmart.Size = new System.Drawing.Size(172, 42);
			this.simplsmart.TabIndex = 53;
			this.simplsmart.TabStop = true;
			this.simplsmart.Text = "Simply Smart";
			this.simplsmart.UseVisualStyleBackColor = false;
			this.simplsmart.Visible = false;
			this.simplsmart.CheckedChanged += new System.EventHandler(this.SimplsmartCheckedChanged);
			// 
			// tup
			// 
			this.tup.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.tup.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.tup.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tup.ForeColor = System.Drawing.Color.Black;
			this.tup.Location = new System.Drawing.Point(24, 283);
			this.tup.Name = "tup";
			this.tup.Size = new System.Drawing.Size(107, 46);
			this.tup.TabIndex = 54;
			this.tup.Text = "Change Tariff";
			this.tup.UseVisualStyleBackColor = false;
			this.tup.Click += new System.EventHandler(this.TupClick);
			// 
			// mavod
			// 
			this.mavod.BackColor = System.Drawing.Color.White;
			this.mavod.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.mavod.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.mavod.ForeColor = System.Drawing.Color.Black;
			this.mavod.Location = new System.Drawing.Point(571, 194);
			this.mavod.Name = "mavod";
			this.mavod.Size = new System.Drawing.Size(107, 30);
			this.mavod.TabIndex = 56;
			this.mavod.Text = "My Vodafone";
			this.mavod.UseVisualStyleBackColor = false;
			this.mavod.Click += new System.EventHandler(this.MavodClick);
			// 
			// radioButton1
			// 
			this.radioButton1.BackColor = System.Drawing.Color.LightGray;
			this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.radioButton1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.radioButton1.Location = new System.Drawing.Point(366, 510);
			this.radioButton1.Name = "radioButton1";
			this.radioButton1.Size = new System.Drawing.Size(172, 42);
			this.radioButton1.TabIndex = 60;
			this.radioButton1.TabStop = true;
			this.radioButton1.Text = "Red Connect";
			this.radioButton1.UseVisualStyleBackColor = false;
			this.radioButton1.Visible = false;
			this.radioButton1.CheckedChanged += new System.EventHandler(this.RadioButton1CheckedChanged);
			// 
			// radioButton2
			// 
			this.radioButton2.BackColor = System.Drawing.Color.LightGray;
			this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.radioButton2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.radioButton2.Location = new System.Drawing.Point(365, 461);
			this.radioButton2.Name = "radioButton2";
			this.radioButton2.Size = new System.Drawing.Size(172, 42);
			this.radioButton2.TabIndex = 61;
			this.radioButton2.TabStop = true;
			this.radioButton2.Text = "Red Connect Essentials";
			this.radioButton2.UseVisualStyleBackColor = false;
			this.radioButton2.Visible = false;
			this.radioButton2.CheckedChanged += new System.EventHandler(this.RadioButton2CheckedChanged);
			// 
			// radioButton3
			// 
			this.radioButton3.BackColor = System.Drawing.Color.LightGray;
			this.radioButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.radioButton3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.radioButton3.Location = new System.Drawing.Point(366, 559);
			this.radioButton3.Name = "radioButton3";
			this.radioButton3.Size = new System.Drawing.Size(172, 42);
			this.radioButton3.TabIndex = 62;
			this.radioButton3.TabStop = true;
			this.radioButton3.Text = "Red Connect Super";
			this.radioButton3.UseVisualStyleBackColor = false;
			this.radioButton3.Visible = false;
			this.radioButton3.CheckedChanged += new System.EventHandler(this.RadioButton3CheckedChanged);
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.Transparent;
			this.label4.Location = new System.Drawing.Point(590, 165);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(88, 20);
			this.label4.TabIndex = 63;
			this.label4.Text = "Apps";
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.Transparent;
			this.label5.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.Transparent;
			this.label5.Location = new System.Drawing.Point(597, 411);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(88, 20);
			this.label5.TabIndex = 64;
			this.label5.Text = "Infos";
			// 
			// bar
			// 
			this.bar.BackColor = System.Drawing.Color.White;
			this.bar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.bar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bar.ForeColor = System.Drawing.Color.Black;
			this.bar.Location = new System.Drawing.Point(571, 377);
			this.bar.Name = "bar";
			this.bar.Size = new System.Drawing.Size(107, 30);
			this.bar.TabIndex = 65;
			this.bar.Text = "Data bar";
			this.bar.UseVisualStyleBackColor = false;
			this.bar.Click += new System.EventHandler(this.BarClick);
			// 
			// Back
			// 
			this.Back.BackColor = System.Drawing.Color.CadetBlue;
			this.Back.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.Back.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.Back.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Back.ForeColor = System.Drawing.Color.Black;
			this.Back.Location = new System.Drawing.Point(12, 614);
			this.Back.Name = "Back";
			this.Back.Size = new System.Drawing.Size(93, 46);
			this.Back.TabIndex = 66;
			this.Back.Text = "Back";
			this.Back.UseVisualStyleBackColor = false;
			this.Back.Click += new System.EventHandler(this.BackClick);
			// 
			// refundd
			// 
			this.refundd.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.refundd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.refundd.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.refundd.ForeColor = System.Drawing.Color.Black;
			this.refundd.Location = new System.Drawing.Point(23, 474);
			this.refundd.Name = "refundd";
			this.refundd.Size = new System.Drawing.Size(109, 47);
			this.refundd.TabIndex = 68;
			this.refundd.Text = "Return Handset";
			this.refundd.UseVisualStyleBackColor = false;
			this.refundd.Click += new System.EventHandler(this.RefunddClick);
			// 
			// popayment
			// 
			this.popayment.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.popayment.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.popayment.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.popayment.ForeColor = System.Drawing.Color.Black;
			this.popayment.Location = new System.Drawing.Point(571, 521);
			this.popayment.Name = "popayment";
			this.popayment.Size = new System.Drawing.Size(108, 31);
			this.popayment.TabIndex = 69;
			this.popayment.Text = "PO Payment";
			this.popayment.UseVisualStyleBackColor = false;
			this.popayment.Click += new System.EventHandler(this.PopaymentClick);
			// 
			// Dpo
			// 
			this.Dpo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.Dpo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.Dpo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Dpo.ForeColor = System.Drawing.Color.Black;
			this.Dpo.Location = new System.Drawing.Point(23, 522);
			this.Dpo.Name = "Dpo";
			this.Dpo.Size = new System.Drawing.Size(109, 47);
			this.Dpo.TabIndex = 70;
			this.Dpo.Text = "Data Protection officer";
			this.Dpo.UseVisualStyleBackColor = false;
			this.Dpo.Click += new System.EventHandler(this.DpoClick);
			// 
			// addresses
			// 
			this.addresses.BackColor = System.Drawing.Color.Transparent;
			this.addresses.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.addresses.ForeColor = System.Drawing.Color.Transparent;
			this.addresses.Location = new System.Drawing.Point(24, 450);
			this.addresses.Name = "addresses";
			this.addresses.Size = new System.Drawing.Size(113, 20);
			this.addresses.TabIndex = 71;
			this.addresses.Text = "Addresses";
			this.addresses.Click += new System.EventHandler(this.AddressesClick);
			// 
			// unsub
			// 
			this.unsub.BackColor = System.Drawing.Color.White;
			this.unsub.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.unsub.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.unsub.ForeColor = System.Drawing.Color.Black;
			this.unsub.Location = new System.Drawing.Point(571, 288);
			this.unsub.Name = "unsub";
			this.unsub.Size = new System.Drawing.Size(107, 30);
			this.unsub.TabIndex = 72;
			this.unsub.Text = "Unsubscribe";
			this.unsub.UseVisualStyleBackColor = false;
			this.unsub.Click += new System.EventHandler(this.UnsubClick);
			// 
			// Tarrifupdate
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.LightSeaGreen;
			this.ClientSize = new System.Drawing.Size(690, 667);
			this.Controls.Add(this.unsub);
			this.Controls.Add(this.addresses);
			this.Controls.Add(this.Dpo);
			this.Controls.Add(this.popayment);
			this.Controls.Add(this.refundd);
			this.Controls.Add(this.Back);
			this.Controls.Add(this.bar);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.radioButton3);
			this.Controls.Add(this.radioButton2);
			this.Controls.Add(this.radioButton1);
			this.Controls.Add(this.mavod);
			this.Controls.Add(this.tup);
			this.Controls.Add(this.simplsmart);
			this.Controls.Add(this.rd30);
			this.Controls.Add(this.rdcnct);
			this.Controls.Add(this.Country);
			this.Controls.Add(this.rhint);
			this.Controls.Add(this.r3);
			this.Controls.Add(this.r2);
			this.Controls.Add(this.r1);
			this.Controls.Add(this.in4);
			this.Controls.Add(this.in3);
			this.Controls.Add(this.in2);
			this.Controls.Add(this.joker);
			this.Controls.Add(this.in1);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.due);
			this.Controls.Add(this.get);
			this.Controls.Add(this.eom);
			this.Controls.Add(this.raisecase);
			this.Controls.Add(this.followup);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.spotify);
			this.Controls.Add(this.skysports);
			this.Controls.Add(this.missingpay);
			this.Controls.Add(this.moremins);
			this.Controls.Add(this.add3gb);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.add1gb);
			this.Controls.Add(this.travel);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.mig);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.services);
			this.Controls.Add(this.service1);
			this.Controls.Add(this.dd);
			this.Controls.Add(this.shock);
			this.Controls.Add(this.pay);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.billdue);
			this.Controls.Add(this.body);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.HelpButton = true;
			this.MaximizeBox = false;
			this.Name = "Tarrifupdate";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Confirm your action";
			this.Load += new System.EventHandler(this.AmountlLoad);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button unsub;
		private System.Windows.Forms.Label addresses;
		private System.Windows.Forms.Button Dpo;
		private System.Windows.Forms.Button popayment;
		private System.Windows.Forms.Button refundd;
		private System.Windows.Forms.Button Back;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.RadioButton radioButton3;
		private System.Windows.Forms.RadioButton radioButton2;
		private System.Windows.Forms.RadioButton radioButton1;
		private System.Windows.Forms.Button mavod;
		private System.Windows.Forms.Button bar;
		private System.Windows.Forms.Button tup;
		private System.Windows.Forms.RadioButton simplsmart;
		private System.Windows.Forms.RadioButton rd30;
		private System.Windows.Forms.RadioButton rdcnct;
		private System.Windows.Forms.TextBox Country;
		private System.Windows.Forms.Label rhint;
		private System.Windows.Forms.RadioButton r3;
		private System.Windows.Forms.RadioButton r2;
		private System.Windows.Forms.RadioButton r1;
		private System.Windows.Forms.TextBox joker;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox due;
		private System.Windows.Forms.Button in4;
		private System.Windows.Forms.Button in3;
		private System.Windows.Forms.Button in2;
		private System.Windows.Forms.Button in1;
		private System.Windows.Forms.Button get;
		private System.Windows.Forms.Button raisecase;
		private System.Windows.Forms.Button eom;
		private System.Windows.Forms.Button followup;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button skysports;
		private System.Windows.Forms.Button spotify;
		private System.Windows.Forms.Button missingpay;
		private System.Windows.Forms.Button moremins;
		private System.Windows.Forms.Button add3gb;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button add1gb;
		private System.Windows.Forms.Button travel;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button mig;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label services;
		private System.Windows.Forms.Button service1;
		private System.Windows.Forms.Button dd;
		private System.Windows.Forms.Button shock;
		private System.Windows.Forms.Button pay;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button billdue;
		private System.Windows.Forms.RichTextBox body;
		
		void RadioButton3CheckedChanged(object sender, System.EventArgs e)
		{
body.Clear();
	body.Text+="Dear Customer \n";
			body.Text+="this is to confirm your new tariff \n \n";
			body.Text+="RED Connect Super €80 per month .\n "; 
			body.Text+="and your monthly allowance is : 30GB data, Unlimited calls and texts to any network ,500 international minutes and texts , Also included, Roaming across Europe ,free Secure Net, Spotify or Skysports for free " +
"24 month contract. \n";
	body.Text+="Vodafone. \n";
			rdcnct.Visible=false;
rd30.Visible=false;
simplsmart.Visible=false;
radioButton1.Visible=false;
radioButton2.Visible=false;
radioButton3.Visible=false;					
		}
		
		void RadioButton1CheckedChanged(object sender, System.EventArgs e)
		{
	body.Clear();
	body.Text+="Dear Customer \n";
			body.Text+="this is to confirm your new tariff \n \n";
			body.Text+="RED Connect €60 per month .\n "; 
			body.Text+="and your monthly allowance is : 15GB data, Unlimited calls and texts to any network ,100 international minutes and texts , Also included, Roaming across Europe ,free Secure Net, Spotify or Skysports for free " +
"24 month contract.\n";
	body.Text+="Vodafone. \n";
			rdcnct.Visible=false;
rd30.Visible=false;
simplsmart.Visible=false;
radioButton1.Visible=false;
radioButton2.Visible=false;
radioButton3.Visible=false;			
		}
		
		void RadioButton2CheckedChanged(object sender, System.EventArgs e)
		{
	body.Clear();
	body.Text+="Dear Customer \n";
			body.Text+="this is to confirm your new tariff \n \n";
			body.Text+="Red Connect Essentials €40 per month .\n "; 
			body.Text+="and your monthly allowance is : 5GB data, Unlimited vodafone to vodafone calls, Unlimited any network texts ,100 any network minutes Also included, Roaming across Europe ,3 month trial of Secure Net, 24 month contract. \n";
	body.Text+="Vodafone. \n";
			rdcnct.Visible=false;
rd30.Visible=false;
simplsmart.Visible=false;
radioButton1.Visible=false;
radioButton2.Visible=false;
radioButton3.Visible=false;			
		}
		
		void BackClick(object sender, System.EventArgs e)
		{
				this.Close();
		
		}
		
		
		void RefunddClick(object sender, System.EventArgs e)
		{
					body.Clear();
	body.Text+="Dear Customer \n";
	body.Text+="Returns adress is :1 Sandyford Business Park Burton Hall Avenue Sandyford Industrial Estate Dublin 18  \n";
			
	
	body.Text+="Vodafone. \n";
			rdcnct.Visible=false;
rd30.Visible=false;
simplsmart.Visible=false;
radioButton1.Visible=false;
radioButton2.Visible=false;
radioButton3.Visible=false;
	
		}
		
		
void DpoClick(object sender, System.EventArgs e)
		{
						body.Clear();
	body.Text+="Dear Customer \n";
	body.Text+="Data protection officer adress is :Vodafone Ireland ltd Mountainview Leopardstown  Dublin 18 \n";
	body.Text+="Vodafone. \n";
			rdcnct.Visible=false;
rd30.Visible=false;
simplsmart.Visible=false;
radioButton1.Visible=false;
radioButton2.Visible=false;
radioButton3.Visible=false;
		}
		
		void PayClick(object sender, System.EventArgs e)
		{
			body.Clear();
	body.Text+="Dear Customer \n";
	body.Text+="We have successfully taken a payment of :€  \n";
				
	body.Text+="Vodafone. \n";
		due.Visible=false;
				textBox1.Visible=false;
				joker.Visible=false;
				in1.Visible=false;
				in2.Visible=false;
				in3.Visible=false;
				in4.Visible=false;
r1.Visible=false;
r2.Visible=false;
r3.Visible=false;
radioButton1.Visible=false;
radioButton2.Visible=false;
radioButton3.Visible=false;
	rhint.Visible=false;
	rdcnct.Visible=false;
rd30.Visible=false;
simplsmart.Visible=false;
		}
		
		void PopaymentClick(object sender, System.EventArgs e)
		{
					body.Clear();
	body.Text+="Dear Customer \n";
	body.Text+="We received your payment refrence number , kindly be informed that the payment will be effective from 3-5 working days   \n";
	body.Text+="Vodafone. \n";
		due.Visible=false;
				textBox1.Visible=false;
				joker.Visible=false;
				in1.Visible=false;
				in2.Visible=false;
				in3.Visible=false;
				in4.Visible=false;
r1.Visible=false;
r2.Visible=false;
r3.Visible=false;
radioButton1.Visible=false;
radioButton2.Visible=false;
radioButton3.Visible=false;
	rhint.Visible=false;
	rdcnct.Visible=false;
rd30.Visible=false;
simplsmart.Visible=false;
		}
	}
}
