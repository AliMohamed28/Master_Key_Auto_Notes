/*
 * Created by SharpDevelop.
 * User: Ali Khattab
 * Date: 14/05/2018
 * Time: 13:11
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Kelma
{
	/// <summary>
	/// Description of confirmsms.
	/// </summary>
	public partial class Tarrifupdate : Form
	{
		public Tarrifupdate()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}

		void BilldueClick(object sender, EventArgs e)
		{
			body.Clear();
			billtext();
			due.Visible=false;
				textBox1.Visible=false;
				due.Clear();
				textBox1.Clear();
				joker.Clear();
				joker.Visible=false;
				//joker.Text+=" Due date               Amount  \n";
				in1.Visible=false;
					in2.Visible=false;
				in3.Visible=false;
				in4.Visible=false;
r1.Visible=false;
r2.Visible=false;
r3.Visible=false;
rhint.Visible=false;
rdcnct.Visible=false;
rd30.Visible=false;
simplsmart.Visible=false;
radioButton1.Visible=false;
radioButton2.Visible=false;
radioButton3.Visible=false;
		}
		
		void DdClick(object sender, EventArgs e)
		{
				body.Clear();
			body.Text+="Dear customer \n";
			body.Text+="This is to confirm that you have setup your direct debit details. Your new direct debit account should be effective within the next 10 working days. Please notify your bank at your earliest convenience. \n \n";
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
		rhint.Visible=false;
		rdcnct.Visible=false;
rd30.Visible=false;
simplsmart.Visible=false;
radioButton1.Visible=false;
radioButton2.Visible=false;
radioButton3.Visible=false;
		}
		
	
		
		void Button3Click(object sender, EventArgs e)
		{
				body.Clear();
				billshock();
				due.Visible=false;
				textBox1.Visible=false;
				due.Clear();
				textBox1.Clear();
				joker.Clear();
				joker.Visible=false;
				joker.Text+="Amount:  \n";
				in3.Visible=false;
				in2.Visible=false;
				in1.Visible=false;
				in4.Visible=false;
				r1.Visible=false;
r2.Visible=false;
r3.Visible=false;
		rhint.Visible=false;
		rdcnct.Visible=false;
rd30.Visible=false;
simplsmart.Visible=false;
radioButton1.Visible=false;
radioButton2.Visible=false;
radioButton3.Visible=false;
		}
		
		void Service1Click(object sender, EventArgs e)
		{
						body.Clear();
						enddate();
			due.Visible=false;
				textBox1.Visible=false;
				due.Clear();
				textBox1.Clear();
				joker.Clear();
				joker.Visible=false;
				in4.Visible=false;
					in2.Visible=false;
				in3.Visible=false;
				in1.Visible=false;
				r1.Visible=false;
r2.Visible=false;
r3.Visible=false;
		rhint.Visible=false;
		rdcnct.Visible=false;
rd30.Visible=false;
radioButton1.Visible=false;
radioButton2.Visible=false;
radioButton3.Visible=false;
simplsmart.Visible=false;
		}
		
		void ServicesClick(object sender, EventArgs e)
		{
			
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			body.Clear();
			body.Text+="Dear customer \n";
			body.Text+="This is to confirm that you requested your account to be upgraded and we will contact you shortly . \n \n";
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
		       	rhint.Visible=false;
	rdcnct.Visible=false;
rd30.Visible=false;
simplsmart.Visible=false;
radioButton1.Visible=false;
radioButton2.Visible=false;
radioButton3.Visible=false;
		}
		
		void MigClick(object sender, EventArgs e)
		{
			body.Clear();
			body.Text+="Dear customer \n";
			body.Text+="This is to confirm that you requested your account to be migrated to prepay successfully . \n \n";
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
	rhint.Visible=false;
	rdcnct.Visible=false;
rd30.Visible=false;
simplsmart.Visible=false;
radioButton1.Visible=false;
radioButton2.Visible=false;
radioButton3.Visible=false;
		}
		
		
		
		void TravelClick(object sender, EventArgs e)
		{
				body.Clear();
										body.Text+=" ";
			r1.Visible=true;;
			r2.Visible=true;;
			r3.Visible=true;;
			rhint.Visible=true;
				due.Visible=false;
				textBox1.Visible=false;
				joker.Visible=false;
				in1.Visible=false;
				in2.Visible=false;
				in3.Visible=false;
				in4.Visible=false;
				rdcnct.Visible=false;
rd30.Visible=false;
simplsmart.Visible=false;
radioButton1.Visible=false;
radioButton2.Visible=false;
radioButton3.Visible=false;

		}
		
		void Add1gbClick(object sender, EventArgs e)
		{
							body.Clear();
			body.Text+="Dear customer \n";
			body.Text+="We have added instant 1 GB on your account , this addon will expire after 30 days starting from now and for more 1GB just send MOREDATA to 50226. \n \n";
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
	rhint.Visible=false;
rdcnct.Visible=false;
rd30.Visible=false;
simplsmart.Visible=false;
radioButton1.Visible=false;
radioButton2.Visible=false;
radioButton3.Visible=false;
		}
		
		
	
		
		
		
		void Add3gbClick(object sender, EventArgs e)
		{
			
							body.Clear();
			body.Text+="Dear Customer \n";
			body.Text+="We have added instant 3 GB on your account , this addon will expire after 30 days starting from now and for more 3GB just send MOREDATA3 to 50226. \n \n";
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
	rhint.Visible=false;
r3.Visible=false;
rdcnct.Visible=false;
rd30.Visible=false;
simplsmart.Visible=false;
radioButton1.Visible=false;
radioButton2.Visible=false;
radioButton3.Visible=false;

		}
		
		
		
	
		
		void MoreminsClick(object sender, EventArgs e)
		{
			body.Clear();
					body.Text+="Dear Customer \n";
			body.Text+="we have added international minute on your account ,they can cover non vodafone numbers and landlines in case you don't have unlimited calls ,this add on will expire after 30 days \n \n";
body.Text+="Vodafone. \n";
			
			due.Visible=false;
			textBox1.Visible=false;
				due.Clear();
				textBox1.Clear();
				joker.Clear();
				joker.Visible=false;
				in1.Visible=false;
				
				in2.Visible=false;
				in3.Visible=false;
				in4.Visible=false;
				r1.Visible=false;
r2.Visible=false;
r3.Visible=false;
	rhint.Visible=false;
	rdcnct.Visible=false;
rd30.Visible=false;
simplsmart.Visible=false;
radioButton1.Visible=false;
radioButton2.Visible=false;
radioButton3.Visible=false;
		}
		
		
		void MissingpayClick(object sender, EventArgs e)
		{
			body.Clear();
				body.Text+="Dear Customer \n";
			body.Text+="to request a missing payment refund kindly email us at ,https://missingpayments.ie@vodafone.com with a bank statment and we will refund you in a matter of 48 working hours \n \n";

			
			body.Text+="kindly include the following paid amount ,and payment refrence number , payment method ,date of payment , and finally your name along with your mobile number  .\n";
			
			body.Text+="Our team will contact you in the next 48 working hours.\n";
			body.Text+="Vodafone.";
			
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
	rhint.Visible=false;
	rdcnct.Visible=false;
rd30.Visible=false;
simplsmart.Visible=false;
radioButton1.Visible=false;
radioButton2.Visible=false;
radioButton3.Visible=false;
		}
		
		//https://offers.vodafone.com/ie - be sure to open it using mobile data.
		
		
		
		
		
		void SpotifyClick(object sender, EventArgs e)
		{
			body.Clear();
		   body.Text+="Dear Customer \n";
			body.Text+="please visit this link to register for spotify , https://offers.vodafone.com/ie - be sure to open it using mobile data. \n \n";
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
	rhint.Visible=false;
	rdcnct.Visible=false;
rd30.Visible=false;
simplsmart.Visible=false;
radioButton1.Visible=false;
radioButton2.Visible=false;
radioButton3.Visible=false;
		}
		
		void SkysportsClick(object sender, EventArgs e)
		{
			body.Clear();
		   body.Text+="Dear Customer \n";
			body.Text+="please visit this link to register for sky sports , https://offers.vodafone.com/ie - be sure to open it using mobile data. \n \n";
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
	rhint.Visible=false;
	rdcnct.Visible=false;
rd30.Visible=false;
radioButton1.Visible=false;
radioButton2.Visible=false;
radioButton3.Visible=false;
simplsmart.Visible=false;
		}
		
	
		
		void FollowupClick(object sender, EventArgs e)
		{
			body.Clear();
			 body.Text+="Dear Customer \n";
			body.Text+="your query needs investigation , we will resolve it and contact you shortly \n \n";

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
	rhint.Visible=false;
	rdcnct.Visible=false;
rd30.Visible=false;
simplsmart.Visible=false;
radioButton1.Visible=false;
radioButton2.Visible=false;
radioButton3.Visible=false;
		}
		
		
		
		void EomClick(object sender, EventArgs e)
		{
			body.Clear();
						 body.Text+="Dear Customer \n";
			body.Text+="we received your feedback regarding our service , we will resolve your query and one of the managers will contact you shortly \n";
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
	rhint.Visible=false;
	rdcnct.Visible=false;
rd30.Visible=false;
simplsmart.Visible=false;
radioButton1.Visible=false;
radioButton2.Visible=false;
radioButton3.Visible=false;
		}
		
		void RaisecaseClick(object sender, EventArgs e)
		{
			body.Clear();
			 body.Text+="Dear Customer \n";
			body.Text+="we will escalate your the issue to the relavent team , we will resolve your query and contact you shortly \n \n";

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
				rhint.Visible=false;
			rdcnct.Visible=false;
rd30.Visible=false;
simplsmart.Visible=false;
radioButton1.Visible=false;
radioButton2.Visible=false;
radioButton3.Visible=false;
		}
		
		
		
		void Button4Click(object sender, EventArgs e)
		{
			
		}
		
		void GetClick(object sender, EventArgs e)
		{
		
			Clipboard.SetText(body.Text);			
			
		}
		
		void BodyTextChanged(object sender, EventArgs e)
		{
			
		}
		
		void Label5Click(object sender, EventArgs e)
		{
			
		}
		
		void TextBox2TextChanged(object sender, EventArgs e)
		{
			
		}
		
		void DueTextChanged(object sender, EventArgs e)
		{
			
		
			
			
		}
		
		void In1Click(object sender, EventArgs e)
		{
			
				billtext();
				in1.Visible=false;
				r2.Visible=false;
r1.Visible=false;
r2.Visible=false;
r3.Visible=false;
	rhint.Visible=false;
		}
		
		
				void billtext()
		{
				body.Clear();
			body.Text+="Dear Customer \n";
			body.Text+="Your bill is ready. \n";
						
			body.Text+="bill due date is : \n";	
 			
			due.Text.ToString();
		
			body.Text+=due.Text;
		
			body.Text+="Bill amount € \n";
					
			textBox1.Text.ToString();
			body.Text+=textBox1.Text;
body.Text+="Vodafone. \n";
r1.Visible=false;
r2.Visible=false;
r3.Visible=false;
rdcnct.Visible=false;
rd30.Visible=false;
simplsmart.Visible=false;
radioButton1.Visible=false;
radioButton2.Visible=false;
radioButton3.Visible=false;
	
		}
		
				
				void paytext()
				{
							body.Clear();
			body.Text+="Dear Customer \n";
			body.Text+="We have successfully processed your payment \n";
			body.Text+="Payment Date : \n";	

			due.Text.ToString();
		
			body.Text+=due.Text;
			
		

			body.Text+="Payment Value: € \n";
					
			body.Text+="Vodafone. \n";
			textBox1.Text.ToString();
			body.Text+=textBox1.Text;


				
				}
		void In2Click(object sender, EventArgs e)
		{
		paytext();
r1.Visible=false;
r2.Visible=false;
r3.Visible=false;
	rhint.Visible=false;
		}
		
		
		void billshock()
		{
			body.Clear();
			body.Text+="Dear Customer \n";
			body.Text+="This is to confirm that we have credited your account as discussed   \n \n";
			body.Text+="Amount adjusted : ";	

			due.Text.ToString();
		
			body.Text+=due.Text;
			body.Text+="\n";
	body.Text+="Vodafone. \n";
		
		}
		void In3Click(object sender, EventArgs e)
		{
				
			billshock();
			in3.Visible=false;
			r1.Visible=false;
r2.Visible=false;
r3.Visible=false;
	rhint.Visible=false;
	

		}
		void enddate()
		{
					body.Clear();
			body.Text+="Dear Customer \n";
			body.Text+="This is to confirm that the End date of your contract \n";
				body.Text+="Out of contract date : ";	

			due.Text.ToString();
		
			body.Text+=due.Text;
		body.Text+="Vodafone. \n";

		
		}
		
		void In4Click(object sender, EventArgs e)
		{
			
			enddate();
			in4.Visible=false;
				rhint.Visible=false;
		}
		
		void JokerTextChanged(object sender, EventArgs e)
		{
			
		}
		void roam()
		{
				body.Clear();
			body.Text+="Dear Customer \n";
			body.Text+="Roaming at , have the following options :   \n \n";
			
			body.Text+="to check in the future which countries are covered by Vodafone Red roaming visit this link : https://n.vodafone.ie/roaming.html \n";

body.Text+="Vodafone. \n";
		}
		void R2CheckedChanged(object sender, EventArgs e)
		{
							body.Clear();
			body.Text+="Dear Customer \n";
			body.Text+="Red roaming will make sure you will have your allowance abroad for 2.99 per day. \n";
			body.Text+="to check in the future which countries are covered by Vodafone Red roaming visit this link : https://n.vodafone.ie/roaming.html \n";
body.Text+="Vodafone. \n";
	rhint.Visible=false;
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
rdcnct.Visible=false;
rd30.Visible=false;
simplsmart.Visible=false;
radioButton1.Visible=false;
radioButton2.Visible=false;
radioButton3.Visible=false;
		}
		
		void R1CheckedChanged(object sender, EventArgs e)
		{
							body.Clear();
			body.Text+="Dear Customer \n";
			body.Text+="Roaming at Europe is totally included in your bundle you can use your allowance with no daily cost   \n \n";
			body.Text+="to check in the future which countries are covered by Vodafone Red roaming visit this link : https://n.vodafone.ie/roaming.html \n";
body.Text+="Vodafone. \n";
rhint.Visible=false;
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
rdcnct.Visible=false;
rd30.Visible=false;
simplsmart.Visible=false;
radioButton1.Visible=false;
radioButton2.Visible=false;
radioButton3.Visible=false;
		}
		
		void R3CheckedChanged(object sender, EventArgs e)
		{
								body.Clear();
			body.Text+="Dear Customer \n";
			body.Text+="Red roaming will make sure you will have your allowance abroad for 4.99 per day. \n \n";
			body.Text+="to check in the future which countries are covered by Vodafone Red roaming visit this link : https://n.vodafone.ie/roaming.html \n";
body.Text+="Vodafone. \n";
	rhint.Visible=false;
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
rdcnct.Visible=false;
rd30.Visible=false;
simplsmart.Visible=false;

		}
		
		void RhintClick(object sender, EventArgs e)
		{
			
		}
		
		void AmountlLoad(object sender, EventArgs e)
		{
			
		}
		
		void SimplsmartCheckedChanged(object sender, EventArgs e)
		{	body.Clear();
			body.Text+="Dear Customer \n";
			body.Text+="this is to confirm your new tariff \n \n";
			body.Text+="Simply Smart 12 Month €25 per month \n "; 
			body.Text+="and your monthly allowance is : 2 GB data, Unlimited any network calls and texts ,50 international minutes and texts,Also included, Roaming across Europe , 12 month contract. \n";
			rdcnct.Visible=false;
rd30.Visible=false;
radioButton1.Visible=false;
radioButton2.Visible=false;
radioButton3.Visible=false;
simplsmart.Visible=false;
		body.Text+="Vodafone. \n";
		}
		
		void RdcnctCheckedChanged(object sender, EventArgs e)
		{
											body.Clear();
			body.Text+="Dear Customer \n";
			body.Text+="this is to confirm your new tariff \n \n";
			body.Text+="RED Connect 12 Month €25 per month for the first 6 month, €35 thereafter,  \n "; 
			body.Text+="and your monthly allowance is : 10GB data, Unlimited any network calls and texts ,100 international minutes and texts,Also included, Roaming across Europe ,3 month trial of Secure Net, 12 month contract. \n";
			rdcnct.Visible=false;
rd30.Visible=false;
radioButton1.Visible=false;
radioButton2.Visible=false;
radioButton3.Visible=false;
simplsmart.Visible=false;
body.Text+="Vodafone. \n";
		}
		
		void Rd30CheckedChanged(object sender, EventArgs e)
		{
			body.Clear();
	body.Text+="Dear Customer \n";
			body.Text+="this is to confirm your new tariff \n \n";
			body.Text+="RED 30 Day €30 per month .\n "; 
			body.Text+="and your monthly allowance is : 5GB data, Unlimited any network calls and texts, Also included, Roaming across Europe ,3 month trial of Secure Net, 30 day contract. \n";
	body.Text+="Vodafone. \n";
			rdcnct.Visible=false;
rd30.Visible=false;
simplsmart.Visible=false;
radioButton1.Visible=false;
radioButton2.Visible=false;
radioButton3.Visible=false;
		}
		
		void TupClick(object sender, EventArgs e)
		{
						body.Clear();
						body.Text+=" ";
rd30.Visible=true;
rdcnct.Visible=true;
simplsmart.Visible=true;
radioButton1.Visible=true;
radioButton2.Visible=true;
radioButton3.Visible=true;

		}
		
		void BarClick(object sender, EventArgs e)
		{
			body.Clear();
			 body.Text+="Dear Customer \n";
			body.Text+="your mobile data will be capped once you finish all your allowance to prevent any extra charges. \n \n";
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
		
		void MavodClick(object sender, EventArgs e)
		{
				body.Clear();
			 body.Text+="Dear Customer \n";
			body.Text+="your Vodafone account is now unlocked and your new password is: \n \n";
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
		
		void AddressesClick(object sender, EventArgs e)
		{
			
		}
		
		
		void UnsubClick(object sender, EventArgs e)
		{
						body.Clear();
	body.Text+="Dear Customer \n";
	body.Text+="To cancel the premium account kindly visit this link:\n";
	body.Text+="https://offers.vodafone.com/ie/cancel \n";
	body.Text+="Vodafone. \n";
			rdcnct.Visible=false;
rd30.Visible=false;
simplsmart.Visible=false;
radioButton1.Visible=false;
radioButton2.Visible=false;
radioButton3.Visible=false;

		}
	}
}
