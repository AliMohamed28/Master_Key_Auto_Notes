/*
 * Created by SharpDevelop.
 * User: Ali Khattab
 * Date: 24/04/2018
 * Time: 15:44
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;


namespace Kelma
{
	/// <summary>
	/// Description of Form1.
	/// </summary>
	/// 
	
	public partial class notewrap : Form
	{

		public notewrap()
		{
			InitializeComponent();
		}

		
		void m_Tick(object sender, EventArgs e)
		{
			
  
		}
		
		  protected override void WndProc(ref Message m)
    {
        base.WndProc(ref m);
        if (m.Msg == WM_NCHITTEST)
            m.Result = (IntPtr)(HT_CAPTION);
    }

    private const int WM_NCHITTEST = 0x84;
    private const int HT_CLIENT = 0x1;
    private const int HT_CAPTION = 0x2;
		
       private static void OnTimedEvent(Object source, System.Timers.ElapsedEventArgs e)
    {
        Console.WriteLine("The Elapsed event was raised at {0}", e.SignalTime);
    }
			void call()
		{
			handle x=new handle();
				x.Show();
			//
		}
		
			
				
			void txt()
		{
			Zodiac s=new Zodiac();
				s.Show();
		
		}
			void confirm()
			{
				Tarrifupdate w = new Tarrifupdate();
				w.Show();
				
			
			}
		void Bill01Click(object sender, EventArgs e)
		{
			
		}
		
	

		
		void Form1Load(object sender, EventArgs e)
		{
		
		}
		
		
		void Panel1Paint(object sender, PaintEventArgs e)
		{

			
		}
		
	

		
		
		void d(object sender, MouseEventArgs e)
		{
			
		}
		
		
	
		
		void EQXClick(object sender, EventArgs e)
		{
		//	MessageBox.Show("This Application was Designed by Caroline Gergis , coded by Ali Khattab feel free to contact us to add any querys !");		
		}
		
		void RemClick(object sender, EventArgs e)
		{

		}
		
		void KnowClick(object sender, EventArgs e)
		{

		}
		
	
		void Button1Click(object sender, EventArgs e)
		{
			txt();
		}
		
		void SendClick(object sender, EventArgs e)
		{

			
		}
		
		void VatClick(object sender, EventArgs e)
		{
		}
		
		void QuitClick(object sender, EventArgs e)
		{
			this.Close();
		}
		
		void AboutClick(object sender, EventArgs e)
		{
	//		MessageBox.Show("This app was designed by CAROLINE - ALI, for any inquires kindly email us on ali.mohamed-khattab@vodafone.com, Caroline.Nessim-Gergis@vodafone.com , Thanks for using our application , We value your feedback team. ");
		}
		

		
		void UsfellinksClick(object sender, EventArgs e)
		{
			
		}
		
		void FufwClick(object sender, EventArgs e)
		{

		}
		
		void Label1Click(object sender, EventArgs e)
		{
			MessageBox.Show("for any inquires kindly email us on Caroline.Nessim-Gerges@vodafone.com, and Ali.Mohamed-Khattab@vodafone.com" );			
		}
		
	
		
		void LinkatClick(object sender, EventArgs e)
		{
										 System.Diagnostics.Process.Start("Links.docx");								
		}
		
	
		
	
		
		void NotClick(object sender, EventArgs e)
		{
			call();
			
		}
		
		void Label2Click(object sender, EventArgs e)
		{
									confirm();
		}
		
		
		
		
	
		void TmpClick(object sender, EventArgs e)
		{
			 System.Diagnostics.Process.Start("temp.docx");								
		}
		
	
		
		void KnoClick(object sender, EventArgs e)
		{
			 System.Diagnostics.Process.Start("know.pdf");	
		}
   }
}
