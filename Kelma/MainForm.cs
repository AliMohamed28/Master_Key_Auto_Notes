/*
 * Created by SharpDevelop.
 * User: Ali Khattab
 * Date: 20/04/2018
 * Time: 15:39
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;



namespace Kelma
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	/// 

	
	public partial class handle : Form
	{
	
		
		public handle()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
	//	int flag=0;
		}
		
		void fo()
		{
			notewrap x=new notewrap();
				x.Show();
		
		}
		void Button1Click(object sender, EventArgs e)
		{
			
			Clipboard.SetText(hidee.Text);
 			
			
		}
		
		
		void Button2Click(object sender, EventArgs e)
		{
			//sla.Visible=false;
			hidee.Clear();
		}
		
		
		void Bill01Click(object sender, EventArgs e)
		{
		
		
			hidee.Clear();			
			hidee.Text+="Query:Customer called to check the bill \n \n";
			hidee.Text+="Action taken:Explained\n \n";
			hidee.Text+="Outcome:customer agreed \n \n";
			hidee.Text+="Resultion:advised with the selfservices and how to check the bill online \n \n";	
			//sla.Clear();
			//sla.Text+=" |Mobile Billing|     	  |Charges|	    	       |Explain| \n";	
			w1.Clear();
			w2.Clear();
			w3.Clear();
			w1.Text+="Mobile billing";
			w2.Text+="Charges";
			w3.Text+="Explain";
			  
		}
		
		void MainFormLoad(object sender, EventArgs e)
		{
		
				

		}
		
		void EmailClick(object sender, EventArgs e)
		{

			hidee.Clear();			
			hidee.Text+="Query:Customer called to have the bill sent out to him \n \n";
			hidee.Text+="Action taken:sent the bill via Email/post \n \n";
			hidee.Text+="Outcome:advised with the SLA customer agreed \n \n";
			hidee.Text+="Resultion:advised with the self services and how to get the bill online \n \n";	
			//sla.Clear();
			//sla.Text+="|Mobile Billing|	     	|Bill Type|		   |Emailed Bill|\n ";	
			w1.Text="Mobile billing";
			w2.Text="Bill Type";
			w3.Text="Emailed bill";
				
						
		}
		
		void RoamingClick(object sender, EventArgs e)
		{
	
					hidee.Clear();			
			hidee.Text+="Query:Customer called to query about roaming \n \n";
			hidee.Text+="Action taken:advised about the roaming charges and services \n \n";
			hidee.Text+="Outcome:customer agreed \n \n";
			hidee.Text+="Resultion:advised with the self services and how to activate the roaming online \n \n";	
			//sla.Clear();
			//sla.Text+="|Mobile services|		|Roaming|		|information| \n ";	
			w1.Text="Mobile services";
			w2.Text="Roaming";
			w3.Text="Information";
			
		}
		
		void InternationalClick(object sender, EventArgs e)
		{
	
					hidee.Clear();			
			hidee.Text+="Query:Customer called to query about intreantional calls \n \n";
			hidee.Text+="Action taken:advised about the charges and services \n \n";
			hidee.Text+="Outcome:customer agreed \n";
			hidee.Text+="Resultion:advised with the self services and how to add extra mins online \n \n";	

			//	sla.Clear();
		
			w1.Text="Mobile services";
			w2.Text="International";
			w3.Text="Explain";
			//sla.Text+=" |Mobile services|		|international|	      	|depends on the query| \n ";	
		
		}
		
		void PrimrateClick(object sender, EventArgs e)
		{
		
						hidee.Clear();			
			hidee.Text+="Query:Customer called to query about charges related to prim rate messages \n \n";
			hidee.Text+="Action taken:advised about the charges and services \n \n";
			hidee.Text+="Outcome:customer agreed \n \n";
			hidee.Text+="Resultion:advised with the serivce name and contact number \n \n";	
			//	sla.Clear();
			//sla.Text+=" |Mobile services|    	  |Call Bar/Unbar|	      |Premium Rate Calls| \n ";	
w1.Text="Mobile services";
			w2.Text="call bar/unbar";
			w3.Text="Premium rate calls";
			
		}
		
		void MinsClick(object sender, EventArgs e)
		{
			
			
		
						hidee.Clear();			
			hidee.Text+="Query:Customer called to query about charges related to minutes \n \n";
			hidee.Text+="Action taken:advised about the charges and how to avoid them \n \n";
			hidee.Text+="Outcome:customer agreed \n \n";
			hidee.Text+="Resultion:advised with the self services and how to add more \n \n";	
			//sla.Clear();			
			//sla.Text+=" |Mobile billing|		|Charges|	     	|Explain Charges| \n ";	
			
			
		}
		
		void DataClick(object sender, EventArgs e)
		{
			
						hidee.Clear();	
					
			hidee.Text+="Query:Customer called to query about charges related to data \n \n";
			hidee.Text+="Action taken:advised about the charges \n \n";

		//		sla.Clear();
	//		sla.Text+=" |Mobile services|     |Charges|    	  |4G Data Usage Query| \n ";
			
		}
		

		
		void Button10Click(object sender, EventArgs e)
		{
	
						hidee.Clear();			
			hidee.Text+="Query:Customer called to make a payment \n \n";
			hidee.Text+="Action taken:Payment taken and confirmation sent \n \n";
			hidee.Text+="Outcome:success \n \n";
//	sla.Clear();	
		w1.Text="Mobile Payment";
			w2.Text="Call Bar/Unbar";
			w3.Text="All Outgoing Calls";

//			sla.Text+=" |Mobile Payment|	    |Call Bar/Unbar|    	    |All Outgoing Calls| \n ";

		}
		
		void InsuranceClick(object sender, EventArgs e)
		{
				
						hidee.Clear();			
			hidee.Text+="Query:Customer called to claim insurance \n \n";
			hidee.Text+="Action taken:transfered the call warm to the insurance team \n \n";
//				sla.Clear();

//				sla.Text+=" |Mobile Product|		|Insurance|		   |Depends| \n ";
			w1.Text="Mobile services";
			w2.Text="Insureance";
			w3.Text="Claim";
			
	}
		

		void DatatClick(object sender, EventArgs e)
		{
			hidee.Clear();
			hidee.Text+="Query:Customer called to report data issue \n \n";
			hidee.Text+="Action taken : Checked APNs , Derag , advised with powercycle \n \n";
			hidee.Text+="Outcome : advised with the SLA  \n \n";
//					sla.Clear();
	w1.Text="Mobile Tech Supp";
			w2.Text="Data sim";
			w3.Text="issue";
//			sla.Text+=" |Mobile Tech Supp|	     |Data Sim|	    	|issue| \n ";

						
			
		}
		
		void BarClick(object sender, EventArgs e)
		{
				hidee.Clear();	
			hidee.Text+="Query: Customer called to report a barred service \n \n";
			hidee.Text+="Action taken:Checked for outstanding balance , NPT full troubleshooting done \n \n";
			hidee.Text+="Outcome:derag , advised with powercycle  \n \n";
			w1.Text="Mobile payment";
			w2.Text="Bar/Unbar";
			w3.Text="Cap";

//			sla.Clear();
//			sla.Text+=" |Mobile payment|	     |Bar/Unbar|	    	|Cap| \n ";

		
		
		}
		
		void Button7Click(object sender, EventArgs e)
		{
			hidee.Clear();			
			hidee.Text+="Query:Customer called report device issue\n \n";
			hidee.Text+="Action taken:full troubleshooting done \n \n";
			hidee.Text+="Outcome:advised with to go to the store and the repair process  \n \n";

				w1.Text="Mobile Product";
			w2.Text="Device";
			w3.Text="issue";
//			sla.Clear();
//			sla.Text+=" |Mobile Product|	     |Device|        |Issue| \n";
		

		}
		
		void DatacapClick(object sender, EventArgs e)
		{
				hidee.Clear();			
			hidee.Text+="Query:Customer called to report a Data problem \n \n";
			hidee.Text+="Action taken:Checked coverge goood, cell site, good , NPT full troubleshooting done \n \n";
			hidee.Text+="Outcome:advised with the SLA  \n \n";
	w1.Text="Mobile Services";
			w2.Text="Mobile internet";
			w3.Text="Cap Info";
//				sla.Clear();
//			sla.Text+=" |Mobile Services|	    |Mobile Internet|      	   |CAP Info| \n";
			
		}
		
		void DOAClick(object sender, EventArgs e)
		{
			
			hidee.Clear();			
			hidee.Text+="Query:Customer called to report a phone problem \n \n";
			hidee.Text+="Action taken:advised if he is within the first 28 days he can replace it , otherwise.. \n \n";
			hidee.Text+="Outcome:to go to the store and the repair process  \n \n";

				w1.Text="Mobile product";
			w2.Text="Device";
			w3.Text="Repair/Return Query";
//				sla.Clear();
//            sla.Text+=" |Mobile Product|	      |Device|	       |Repair/Return Query| \n";			
		}
		
		void WarrentyClick(object sender, EventArgs e)
		{
			
			
			hidee.Clear();			
			hidee.Text+="Query:Customer called to report a phone problem \n \n";
			hidee.Text+="Action taken:advised if he is within the first 24 for andriod or 12 monthes for I phone he can replace it. \n \n";
			hidee.Text+="Outcome:to go to the store and the repair process  \n \n";

				w1.Text="Mobile product";
			w2.Text="Device";
			w3.Text="Repair/Return Query";
//				sla.Clear();
//			sla.Text+=" |Mobile Product|  	   |Device|	         |Repair/Return Query| \n";
			
		}
		
		void RetentionClick(object sender, EventArgs e)
		{
					
			hidee.Clear();			
			hidee.Text+="Query:Customer called return a deal \n \n";
			hidee.Text+="Action taken:advised if he is within the first 28 days he can replace it , otherwise.. \n \n";
			hidee.Text+="Outcome:to go to the store and the repair process  \n \n";

			
				w1.Text="Mobile Sales";
			w2.Text="Upgrade/return";
			w3.Text="Information";
//			sla.Clear();
			
//			sla.Text+=" |Mobile Sales|	    |Upgrade Return|         |Information| \n";
		
		}
		
		void DataaddClick(object sender, EventArgs e)
		{
				hidee.Clear();		
			hidee.Text+="Query:Customer called to request a Data Add on \n \n";
			hidee.Text+="Action taken:advised with the options and met customer's choice \n \n";
			hidee.Text+="Outcome:applied the changes , sent a confirmation message and advised with the self services.  \n \n";

				w1.Text="Mobile Package";
			w2.Text="Add on";
			w3.Text="Change";
//			sla.Clear();
//			sla.Text+=" |Mobile Package|         |Add On|	       |Change| \n \n";
	
		}
		
		void IntminaddonClick(object sender, EventArgs e)
		{
			hidee.Clear();			
			hidee.Text+="Query:Customer called to request a international mins on \n \n";
			hidee.Text+="Action taken:advised with the options and met customer's choice \n \n";
			hidee.Text+="Outcome:applied the changes , sent a confirmation message and advised with the self services in it \n \n";
				w1.Text="Mobile Package";
			w2.Text="Add on";
			w3.Text="Change";

//			sla.Clear();
//			sla.Text+=" |Mobile Services|	     |Call Bar/Unbar|       |International Calls| \n \n";
		}
		
		void RedroamingClick(object sender, EventArgs e)
		{
			hidee.Clear();			
			hidee.Text+="Query:Customer called to request a Red Roaming \n \n";
			hidee.Text+="Action taken:advised with the options and met customer's choice \n \n";
			hidee.Text+="Outcome:applied the changes , sent a confirmation message and advised with the self services in it \n \n";
				w1.Text="Mobile Product";
			w2.Text="Red Roaming";
			w3.Text="Countries & Networks";

//			sla.Clear();
//			sla.Text+=" |Mobile Tech Supp|	      |Roaming|       |Red Roaming| \n \n";			
		}
		
		void UpgradeClick(object sender, EventArgs e)
		{
				hidee.Clear();		
			hidee.Text+="Query:Customer called to request an upgrade to the price plan on \n \n";
			hidee.Text+="Action taken:advised with the options and met customer's choice \n \n";
			hidee.Text+="Outcome:applied the changes , sent a confirmation message and advised with the self services in it \n \n";

				w1.Text="Promotions-VF";
			w2.Text="Upgrade";
			w3.Text="Information";
		

//				sla.Clear();
//			sla.Text+=" |Promotions-VF|	      |Upgrade|     	  |Information| \n";

		}
		
		void Button8Click(object sender, EventArgs e)
		{
			hidee.Clear();			
			hidee.Text+="Query:Customer called to request Simonly plan \n \n";
			hidee.Text+="Action taken:advised with the options and met customer's choice \n \n";
			hidee.Text+="Outcome:applied the changes , sent a confirmation message and advised with the self services in it \n \n";
			hidee.Text+="Resultion:done \n \n";	
			hidee.Text+="Escaltion:N/A \n \n";

				w1.Text="Mobile Services";
			w2.Text="Upgrade / Renwal";
			w3.Text="Assist Customer";
		

//			sla.Clear();
//			sla.Text+=" |Mobile Services|	      |Upgrade / Renewal|	      |Assist Customer| \n";
		}
		
		void HandsetClick(object sender, EventArgs e)
		{
				hidee.Clear();
			hidee.Text+="Query:Customer called to request a device to be sent to him \n \n";
			hidee.Text+="Action taken:advised with the options and met customer's choice \n \n";
			hidee.Text+="Outcome:applied the changes , sent a confirmation message and advised with the self services in it \n \n";

				w1.Text="Mobile Tech Supp";
			w2.Text="Device";
			w3.Text="issue";

//				sla.Clear();
//			sla.Text+=" |Mobile Tech Supp|	      |Device|	     |Internet/Live Issue| \n ";
		}
		

		
		void UsageClick(object sender, EventArgs e)
		{
		hidee.Clear();		
			hidee.Text+="Query:Customer called to check his unbilled usage \n \n";
			hidee.Text+="Action taken:advised with the remainaing allowance \n \n";
			hidee.Text+="Outcome:sent a confirmation message and advised with the self services in it \n \n";


			w1.Text="Mobile Billing";
			w2.Text="Charges";
			w3.Text="4G Data usage query";

//	sla.Clear();			
//			sla.Text+=" |Mobile Billing|	    |Charges|	   |4G Data Usage Query| \n ";
		}
		
		void Button4Click(object sender, EventArgs e)
		{
			hidee.Clear();	
			hidee.Text+="Query:Customer called to track a number that they called \n \n";
			hidee.Text+="Action taken :advised with date and time of the call \n \n";
	
		}
		
		void Button3Click(object sender, EventArgs e)
		{
			hidee.Clear();		
			hidee.Text+="Query:Customer called to Cancel a contract \n \n";
			hidee.Text+="Action taken:transfered to the TSAR / raised a case on UFE \n \n";
			hidee.Text+="Outcome:warm \n \n";
//			sla.Clear();

			w1.Text="Mobile Cessation";
			w2.Text="Bill pay voice";
			w3.Text="Unable to save";
//			sla.Text+=" |Mobile Cessation|	    |Bill Pay Voice|	   |Unable To Save| \n";
			
		}
		
		void CallClick(object sender, EventArgs e)
		{
			hidee.Clear();	
			hidee.Text+="Query:Customer called to report Calls problem \n \n";
			hidee.Text+="Action taken:Checked coverge goood, cell site, good , NPT full troubleshooting done \n \n";
			hidee.Text+="Outcome:advised with the SLA  \n \n";

//			sla.Clear();
//			sla.Text+=" |Mobile Tech Supp|	    |Disco/Reco|	   |IMSI Mis Match| \n";
			
			w1.Text="Mobile Tech supp";
			w2.Text="Disco/reco";
			w3.Text="IMSI mismatch";
			
		}
		
		void TxtClick(object sender, EventArgs e)
		{
				hidee.Clear();
			hidee.Text+="Query:Customer called to report a SMS problem \n \n";
			hidee.Text+="Action taken:Checked coverge goood, cell site, good , NPT full troubleshooting done \n \n";
			hidee.Text+="Outcome:advised with the SLA  \n \n";

//			sla.Clear();
//			sla.Text+=" |Mobile Tech Supp|  	    |SMS|	      |Escalated| \n ";
			
			w1.Text="Mobile Tech supp";
			w2.Text="SMS";
			w3.Text="Esclated";
		}
		
		void KelmaTextChanged(object sender, EventArgs e)
		{
			
		}
		
		
		void KnowledgegapClick(object sender, EventArgs e)
		{
	  System.Diagnostics.Process.Start("https://alimagdy94.wixsite.com/kelmaproject");
		}
		
		void Button6Click(object sender, EventArgs e)
		{
			hidee.Clear();
			//	hidee.Text+="eqx follow up team + control K outlook aplication for bill peaper copy or upgrades \n \n";
			//hidee.Text+="care.ie if you wanna share somthing with the whole floor \n \n";
		}

		
		void GeneralClick(object sender, EventArgs e)
		{
					hidee.Clear();
			hidee.Text+="Query:    \n \n";
			hidee.Text+="Action taken: \n \n";
			hidee.Text+="Outcome : customer agreed , advised with the SLA  \n \n";
			w1.Text="Mobile Admin";
			w2.Text="Account Information";
			w3.Text="Query";
		}
		
		void NACClick(object sender, EventArgs e)
		{
			
					hidee.Clear();
			hidee.Text+="Query:Customer called to requst NAC \n \n";
			hidee.Text+="Action taken:checked min spent = passed , less than 3 a year = passed, raised a case \n \n";
			hidee.Text+="Outcome:advised with the SLA  \n \n";			
//			sla.Clear();
w1.Text="Mobile Product";
			w2.Text="Nac";
			w3.Text="Nac Request";
//			sla.Text+=" |Mobile Tech Supp|	    |Iphone|     |Unlock NAC| \n";

		}
	

		void SlaTextChanged(object sender, EventArgs e)
		{
			
		}
		
		

				
	        

		
		void Button17Click(object sender, EventArgs e)
		{
			hidee.Clear();	
			hidee.Text+="Query:Customer called to Add authorization for a contact \n \n";
			hidee.Text+="Action taken:Validated the customer ,and added the authority \n \n";
			hidee.Text+="Outcome:done successfully  \n \n";		
//			sla.Clear();
w1.Text="Mobile Admin";
			w2.Text="Account Information";
			w3.Text="Query";
//			sla.Text+=" |Mobile Admin|	    |Customer Admin|	   |Change Details| \n";			
		}
		
		void Button19Click(object sender, EventArgs e)
		{
			
		}
		
		void Button23Click(object sender, EventArgs e)
		{

		}
		
		void TrackmyorderClick(object sender, EventArgs e)
		{
			hidee.Clear();	
				hidee.Text+="Query:Customer called to track an order \n \n";
			hidee.Text+="Action taken:raised a tracking request \n \n";
			hidee.Text+="Outcome:advised with the SLA  \n \n";		
//			sla.Clear();
			w1.Text="Mobile Sales";
			w2.Text="Order";
			w3.Text="Information";
//			sla.Text+=" |Order|	       |Upgrade|	  |information| \n";
		}
		
		void TarrifmgarionClick(object sender, EventArgs e)
		{
			hidee.Clear();	
			hidee.Text+="Query: Customer called to requst tarrif migration \n \n";
			hidee.Text+="Action taken : took the action and migrated the customer to the requested tarrif \n \n";
			hidee.Text+="Outcome:advised that's it's done and confirmed with SMS  \n \n";
		
//			sla.Clear();
w1.Text="Mobile Package";
			w2.Text="Tariff";
			w3.Text="Change Tarrif";
//			sla.Text+=" |Mobile Package|	    |Tariff|	   |Change Tariff| \n";
		}
		
		void EsclationClick(object sender, EventArgs e)
		{
			hidee.Clear();	
				hidee.Text+="Query:Customer called to requst a manger \n \n";
			hidee.Text+="Action taken:took the customer's complain after validation and arranged a manger's call back \n \n";
			hidee.Text+="Outcome:advised that's it's done and confirmed with SMS  \n \n";
//			sla.Clear();

//			sla.Text+=" |Mobile Admin|	    |Account Information|		   |Query| \n";
		}
		
		void PaymeanClick(object sender, EventArgs e)
		{
			hidee.Clear();	
				hidee.Text+="Query:Customer called to change paymean \n \n";
			hidee.Text+="Action taken:Validated the customer ,and added the new information \n \n";
			hidee.Text+="Outcome:done successfully  \n \n";			
	//		sla.Clear();
w1.Text="Mobile Payment";
			w2.Text="Direct Debit";
			w3.Text="Change Details";
	//		sla.Text+=" |Mobile Payment|	   |Direct Debit|		  |Change Details| \n";	
		}
		
		void SIMSWAPClick(object sender, EventArgs e)
		{
			hidee.Clear();	
				hidee.Text+="Query:Customer called to request SIM swap \n \n";
			hidee.Text+="Action taken:Validated the customer ,and updated the sim \n \n";
			hidee.Text+="Outcome:done successfully advised with power cycle  \n \n";			
	//		sla.Clear();
w1.Text="Mobile Services";
			w2.Text="Sim Card";
			w3.Text="Activated";
			//sla.Text+=" |Mobile Services|	    |Sim Card|		    |Activated| \n";
		}
		
		
		void PortoutClick(object sender, EventArgs e)
		{
			hidee.Clear();	
			hidee.Text+="Query:Customer called to request cancel his number and port out \n \n";
			hidee.Text+="Action taken:Validated the customer , provided the finanical number \n \n";
			hidee.Text+="Outcome:tried to retain the customer , but he has to go  \n \n";				
		//	sla.Clear();
w1.Text="Mobile Cessation";
			w2.Text="Bill Pay Voice";
			w3.Text="Unable to Save";
		//	sla.Text+=" |Mobile Cessation|	   |Bill Pay Voice|	 	 |Unable To Save| \n";
		}
		
		void FixedbillingClick(object sender, EventArgs e)
		{
			hidee.Clear();	
				hidee.Text+="Query:Customer called regarding a fixed connection\n \n";
			hidee.Text+="Action taken:Validated the customer , transfered to the relavent team \n \n";
			hidee.Text+="Outcome:warm transfer \n \n";		
		//	sla.Clear();
w1.Text="Call options";
			w2.Text="Transfer Call";
			w3.Text="Customer Request";
		//	sla.Text+=" |Call Options|	    |Transfer Call|	    |Customer Request| \n";
		}
		
		void FixedtechClick(object sender, EventArgs e)
		{
			hidee.Clear();	
				hidee.Text+="Query:Customer called regarding a fixed connection tech query \n \n";
			hidee.Text+="Action taken:Validated the customer , transfered to the relavent team \n \n";
			hidee.Text+="Outcome:warm transfer \n \n";			
		//	sla.Clear();
w1.Text="Call options";
			w2.Text="Transfer Call";
			w3.Text="Customer Request";
		//	sla.Text+=" |Call Options|	    |Transfer Call|		    |Tech (Request)| \n";
		}
		
		void TransferClick(object sender, EventArgs e)
		{
			hidee.Clear();	
				hidee.Text+="Query:Customer requested to be transfered \n \n";
			hidee.Text+="Action taken:Validated the customer , transfered to the relavent team \n \n";
			hidee.Text+="Outcome:warm transfer \n \n";		
		//	sla.Clear();
w1.Text="Call options";
			w2.Text="Transfer Call";
			w3.Text="Customer Request";
		//	sla.Text+=" |Call Options|	    |Transfer Call|	 	   |Customer Request)| \n";
		}
		
		void LoststolenClick(object sender, EventArgs e)
		{
			hidee.Clear();	
				hidee.Text+="Query:Customer called to report a stolen handset \n \n";
			hidee.Text+="Action taken:Validated the customer , and barred the sim card , and black listed the handset \n \n";
			hidee.Text+="Outcome:Ordered new sim to the customer \n \n";
				
		//	sla.Clear();
w1.Text="Mobile Services";
			w2.Text="Call Bar/Unbar";
			w3.Text="Lost/ Stolen";
		//	sla.Text+=" |Mobile Services|	    |Call Bar/Unbar|	    |Lost/Stolen)| \n";
		}
		
		void SkysportsClick(object sender, EventArgs e)
		{
			hidee.Clear();	
			hidee.Text+="Query:Customer called to Activate sky sports \n \n";
			hidee.Text+="Action taken:link sent to the customer , and advised how to register \n \n";
		//	sla.Clear();
w1.Text="Mobile Product";
			w2.Text="Sky Sports Mobile TV";
			w3.Text="Information";
		//	sla.Text+=" |Mobile Product|	    |Sky Sports Mobile TV|	    |Information)| \n";
		}
		
		void SpotifyClick(object sender, EventArgs e)
		{
			hidee.Clear();	
				hidee.Text+="Query:Customer called to Activate Spotify \n \n";
			hidee.Text+="Action taken:link sent to the customer , and advised how to register \n \n";		
		//	sla.Clear();
			w1.Text="Mobile Product";
			w2.Text="Spotify";
			w3.Text="Information";
	
		//	sla.Text+=" |Mobile Product|	   |Spotify|	   	 |Information)| \n";
		}
		
		void MyvodafoneonlineClick(object sender, EventArgs e)
		{
			hidee.Clear();	
				hidee.Text+="Query:Customer called to Activate My Vodafone \n \n";
			hidee.Text+="Action taken : Assisted customer resetting the Login details \n \n";			
		//	sla.Clear();
			w1.Text="Mobile Services";
			w2.Text="Self Care";
			w3.Text="mCare App";
		//	sla.Text+=" |Mobile Services|	    |Self Care|	    	 |mCare App| \n";
		}
		
		void OnlineaccountClick(object sender, EventArgs e)
		{
			hidee.Clear();	
					hidee.Text+="Query:Customer called to reset online account \n \n";
			hidee.Text+="Action taken:link sent to the customer , and advised how to reset \n \n";		
		//	sla.Clear();
w1.Text="Mobile Services";
			w2.Text="Self Care";
			w3.Text="mCare App";
		//	sla.Text+=" |Mobile Services|	    |Self Care|		  	  |mCare App| \n";
		}
		
		void NetworkClick(object sender, EventArgs e)
		{
			hidee.Clear();	
					hidee.Text+="Query:Customer called to report a network issue \n \n";
			hidee.Text+="Action taken:checked the network for the customer using landescape \n \n";
			hidee.Text+="Outcome:advised with the sla done \n \n";
			
		//	sla.Clear();
			w1.Text="Mobile Tech Supp";
			w2.Text="Network";
			w3.Text="Depends on your Query";
		//	sla.Text+=" |Mobile Tech Supp|	    |Network|		    |Depends on your Query)| \n";
		}
		
		void Label6Click(object sender, EventArgs e)
		{
			
		}
		
		void Label7Click(object sender, EventArgs e)
		{
			
		}
		
		void AClick(object sender, EventArgs e)
		{
						//MessageBox.Show("This Application was Designed by CAROLINE , coded by ADAM feel free to contact us via email alimagdy94@gmail.com .");					
		}
		
		void SpamClick(object sender, EventArgs e)
		{
			hidee.Clear();	
					hidee.Text+="Query:Customer called to report an extra charges from a spam number\n \n";
			hidee.Text+="Action taken : advised that the number will be reported on a network level, yet the charges are valid \n \n";
			hidee.Text+="Outcome : advised how to block the number from the customer's end\n \n";			
		//	sla.Clear();
			w1.Text="Mobile Services";
			w2.Text="Nuisance Comms";
			w3.Text="Information";
		//	sla.Text+=" |Mobile services|	  |Nuisance Comms|	   |Information| \n";
		}
		
		void ComplainClick(object sender, EventArgs e)
		{
			hidee.Clear();	
					hidee.Text+="Query:Customer called to report ongoing un resloved issue\n \n";
			hidee.Text+="Action taken:resolved the customer query , and took the customer's feedback into consideration \n \n";
			hidee.Text+="Outcome:dvised with the SLA \n \n";
			w1.Text="Mobile Tech Supp";
			w2.Text="Network";
			w3.Text="Depends on your Query";
		//	sla.Clear();
			w1.Text="Mobile Services";
			w2.Text="Nuisance";
			w3.Text="Depends on your Query";
		//	sla.Visible=true;
		//	sla.Text+=" |Mobile services|	    |nuisance call|	    |Depends on your Query)| \n";
		}
		
		void StuckClick(object sender, EventArgs e)
		{
			hidee.Clear();	
					hidee.Text+="Query:Customer called to report a stuck order\n \n";
			hidee.Text+="Action taken:tracked the order , and advised with the SLA \n \n";
			hidee.Text+="Outcome:provided the customer with the tracking number\n \n";
			
		//	sla.Clear();
			w1.Text="Mobile Services ";
			w2.Text="Upgrade";
			w3.Text="Information";
		//	sla.Text+=" |Mobile services|	    |Upgrade|		    |(information)| \n";
		}
		
		void New2Click(object sender, EventArgs e)
		{
						hidee.Clear();	
					
			hidee.Text+="Query:Customer called to query about his account information \n \n";
			hidee.Text+="Action taken:advised with what the customer needs \n \n";
			w1.Text="Mobile Tech Supp";
			w2.Text="Network";
			w3.Text="Depends on your Query";
		//		sla.Clear();
		}
		
		void New3Click(object sender, EventArgs e)
		{
						hidee.Clear();	
					
			hidee.Text+="Query:Customer called to query about Roaming \n \n";
			hidee.Text+="Action taken:advised with the Red Roaming and the standrad charges , advised how to check on www.vodafone.ie  \n \n";

		//		sla.Clear();
			w1.Text="Mobile Tech Supp";
			w2.Text="Network";
			w3.Text="Depends on your Query";
		//		sla.Text+=" |Mobile services|	    |Roaming|		    |(information)| \n";
		}
		
		void New4Click(object sender, EventArgs e)
		{
				hidee.Clear();	
					
			hidee.Text+="Query:Customer called to roll the contract over , as it was extended by mistake \n \n";
			hidee.Text+="Action taken:done successfully  \n \n";
			w1.Text="Mobile Services";
			w2.Text="Roaming";
			w3.Text="Information";
		//		sla.Clear();
		
			//	sla.Text+=" |Mobile services|	    |Roaming|	    |(information)| \n";			
		}
		
		void New5Click(object sender, EventArgs e)
		{
	hidee.Clear();	
					
			hidee.Text+="Query:Customer called to renew the contract , offered bill pay phones and bill pays sim only plans \n \n";
			hidee.Text+="Action taken:done successfully after meeting the customer's excepctaions  \n \n";

			w1.Text="Mobile Producsts/services";
			w2.Text="Uprade/renewal";
			w3.Text="Assist customer";
		//	sla.Text+=" |Mobile Products/services|	    |Upgrade/renwal|	    |(first)| \n";
		//		sla.Clear();			
		}
		
		void New6Click(object sender, EventArgs e)
		{
				hidee.Clear();	
					
			hidee.Text+="Query:Customer called to change tariff \n \n";
			hidee.Text+="Action taken:done successfully Sent a confirmation message with the new tarrif details , terms and conditions  \n \n";
			w1.Text="Mobile Products";
			w2.Text="Tariff";
			w3.Text="Change";
		//	sla.Text+=" |Mobile Products/services|	    |Tarrif|	    |(Change)| \n";
		//		sla.Clear();				
		}
		
		void New7Click(object sender, EventArgs e)
		{
	hidee.Clear();	
					
			hidee.Text+="Query:Customer called to to query about charges prim rate messages  \n \n";
			hidee.Text+="Action taken:Advised the customer with the third party service , and stopped the service , then raised a refund request   \n \n";
w1.Text="Mobile billing";
			w2.Text="Charges";
			w3.Text="Explain";
		//		sla.Clear();
//	sla.Text+=" |Mobile Billing|	    |Charges|	  	  |Explain| \n";
		}
		
		void New8Click(object sender, EventArgs e)
		{
		hidee.Clear();	
					
			hidee.Text+="Query:Customer called to to query about his upgrade  \n \n";
			hidee.Text+="Action taken:Advised the customer with the information, sent a confirmation message \n \n";
			w1.Text="Mobile Products";
			w2.Text="Upgrade/renewal";
			w3.Text="Assist customer";
//			sla.Text+=" |Mobile Products/services|	    |Upgrade/renwal|	    |Assist| \n";
//				sla.Clear();		
		}
		
		void New9Click(object sender, EventArgs e)
		{
			
		}
		
		void New10Click(object sender, EventArgs e)
		{
hidee.Clear();	
					
			hidee.Text+="Query:Customer called to to report a double payment \n \n";
			hidee.Text+="Action taken:called retail support 5502 in order to allocate and adjust the payment\n";
			w1.Text="Mobile Payment";
			w2.Text="Missing Payment";
			w3.Text="Esclated";

//			sla.Clear();
//			sla.Text+=" |Mobile Payment|	    |Missing Payment|	    |Esclated| \n";
						
						
		}
		
		void New11Click(object sender, EventArgs e)
		{
		hidee.Clear();	
					
			hidee.Text+="Query:Customer called to to report a missing payment \n \n";
			hidee.Text+="Action taken:called retail support 5502 in order to allocate and adjust the payment\n";

			w1.Text="Mobile Payment";
			w2.Text="OverPaid";
			w3.Text="Investigation";

//sla.Clear();
//			sla.Text+=" |Mobile Payment|	    |OverPaid|	    		|investigation| \n";
					
			
		}
		
		void New12Click(object sender, EventArgs e)
		{
		hidee.Clear();	
					
			hidee.Text+="Query:Customer called to to query about an account that is not under their name \n \n";
			hidee.Text+="Action taken:Advised the customer that we can't share account information with anyone but the account holder , customer agreed\n";
			w1.Text="Call Options";
			w2.Text="Failed Validation";
			w3.Text="Unable to Deal";

//				sla.Clear();			
		}
		
		void New20Click(object sender, EventArgs e)
		{
			hidee.Clear();	
					
			hidee.Text+="Query:Customer called to to query an installment plan \n \n";
			hidee.Text+="Action taken:Transfered the call warm to the credits and collections team\n";
	w1.Text="Mobile Payment";
			w2.Text="Installment Plan";
			w3.Text="Information";

			//Mobile Payment

		

//sla.Clear();
//			sla.Text+=" |Mobile Payment|	    |Instalment Plan|	    |Information| \n";
						
		}
		
		void New13Click(object sender, EventArgs e)
		{
	hidee.Clear();	
					
			hidee.Text+="Query:Customer called to add insurance  \n \n";
			hidee.Text+="Action taken:Transfered the call warm to the insurance team \n";
	w1.Text="Mobile Products";
			w2.Text="Insurance";
			w3.Text="Add";

//sla.Clear();
//			sla.Text+=" |Mobile Products/services|	    |insurance|	 	   |Add| \n";
								
		}
		
		void New14Click(object sender, EventArgs e)
		{
	hidee.Clear();	
					
			hidee.Text+="Query:Customer called to remove insurance  \n \n";
			hidee.Text+="Action taken:Transfered the call warm to the insurance team \n";
	w1.Text="Mobile products";
			w2.Text="Insurance";
			w3.Text="Remove";

//				sla.Clear();
//			sla.Text+=" |Mobile Products/services|	    |insurance|	   		 |Remove| \n";
							
		}
		
		void New15Click(object sender, EventArgs e)
		{
			hidee.Clear();	
					
			hidee.Text+="Query:Customer called to disbute charges on the most recent bill  \n \n";
			hidee.Text+="Action taken:investgated the bill in question , customer was charged incorrectly , Added a credit : () advised it will be deducted from the next bill , Validated by TM () \n";
	w1.Text="Mobile Billing";
			w2.Text="Charges";
			w3.Text="Explain";

//				sla.Clear();
//			sla.Text+=" |Mobile billing|	    |charges|	   	 |Explain| \n";
		}
		
		void New16Click(object sender, EventArgs e)
		{
			hidee.Clear();	
					
			hidee.Text+="Query:Customer called to To query about the current tarrif  \n \n";
			hidee.Text+="Action taken:Sent a confirmation SMS \n";
	w1.Text="Mobile Products";
			w2.Text="Tariff";
			w3.Text="Information";

//sla.Clear();
//			sla.Text+=" |Mobile Products/services|	    |Tariff|	    |information| \n";
				
		}
		
		void New17Click(object sender, EventArgs e)
		{
			hidee.Clear();	
					
			hidee.Text+="Query:Customer called to To activate Red Roaming  \n \n";
			hidee.Text+="Action taken:Done,Sent a confirmation SMS \n";
//sla.Clear();
	w1.Text="Mobile Products";
			w2.Text="Roaming";
			w3.Text="Countries";

//			sla.Text+=" |Mobile Products/services|	    |Roaming|	    |Countries| \n";
			
		}
		
		void New18Click(object sender, EventArgs e)
		{
				hidee.Clear();	
					
			hidee.Text+="Query:Customer called to To Track their usage  \n \n";
			hidee.Text+="Action taken:Advised with the remaining allowance ,Advised with how to track it using my vodafone app \n";
	w1.Text="Mobile Billing";
			w2.Text="Charges";
			w3.Text="4G Data Usage Query";

//			sla.Text+=" |Mobile Products/services|	    |Roaming|	    |Countries| \n";
//				sla.Clear();
		}
		
		void New19Click(object sender, EventArgs e)
		{
						hidee.Clear();	
					
			hidee.Text+="Query:Customer called to To change their phone number  \n \n";
			hidee.Text+="Action taken:Advised with the options and met the customer's choice \n";

			w1.Text="Mobile Admin";
			w2.Text="Account Information";
			w3.Text="Query";

			//sla.Text+=" |Mobile Products/services|	    |Roaming|	    |Countries| \n";
//				sla.Clear();
		}
		
		void AdddonnClick(object sender, EventArgs e)
		{
						hidee.Clear();	
					
			hidee.Text+="Query:Customer called to To Add on extra :  \n \n";
			hidee.Text+="Action taken:Advised with the options and met the customer's choice \n";
	w1.Text="Mobile Products";
			w2.Text="Add on";
			w3.Text="Change";

//			sla.Text+=" |Mobile Products/services|	    |Add on|	    |Change| \n";
//				sla.Clear();
		}
		
		
		
		void WrapsClick(object sender, EventArgs e)
		{
			System.Diagnostics.Process.Start("Wraps.xlsx");			
		}
		
		
		void W2MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
		{
			
		}
		
		void W1MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
		{
			
		}
		
		void W3MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
		{
			
		}
		
		void XClick(object sender, EventArgs e)
		{
			this.Close();
		}
		
		void CallbkClick(object sender, EventArgs e)
		{
			hidee.Clear();	
					
			hidee.Text+="Called the customer back as promised \n \n";
			hidee.Text+="Followed up on the query and resloved the issue \n \n";
			
	w1.Text="Mobile Admin";
			w2.Text="Call back";
			w3.Text="Completed";

//			sla.Text+=" |Mobile Products/services|	    |Add on|	    |Change| \n";
//				sla.Clear();
		}
		
		void IMTClick(object sender, EventArgs e)
		{
				hidee.Clear();	
					
			hidee.Text+="IMT Case Raised  \n \n";
			hidee.Text+="Action taken:Advised with the service level , customer agreed \n";
	
			w1.Text="Mobile Admin";
			w2.Text="Account Information";
			w3.Text="Query";

		}
		
		void ReconnectionfeeClick(object sender, EventArgs e)
		{
			hidee.Clear();	
			hidee.Text+="Customer called to query charges on the latest bill  \n";
			hidee.Text+="Action taken:Advised with the reconnection fee 25 Euro , customer accepted the charges \n";
			hidee.Text+="Advised That the charges can be waived once the direct debit is setup on the account \n";
			hidee.Text+="Outcome:customer agreed.\n";
			
	
			w1.Text="Mobile Billing";
			w2.Text="Charges";
			w3.Text="Disbuted";	
		}
	}
}
