using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KwonLab4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Hide label(tripInformation)m mark Cuba and Credit card, empty txtbox and Price label
        //put curson on top textbox
        private void ResetTrip()
        {
            grpTripInformation.Hide();
            radCuba.Checked=true;
            txtPeople.ResetText();
            lblPrice.Text="";
            radCreditCard.Checked=true;
            txtPeople.Focus();           
        }//end of ResetTrip function

        //check in flight is included. Radio buton is put in a IF ELSE IF statement when more than 2 options
        private void SetFlight()
        {
            if (radFlorida.Checked)
            {
                chkFlightIncluded.Checked=false;
            }
            else if (radCuba.Checked)
            {
                chkFlightIncluded.Checked = true;                
            }
            else if (radMexico.Checked)
            {
                chkFlightIncluded.Checked = true;                
            }
        }
        //end of SetFlight function
        
        //function to create MessageBox.Show with two parameters. 
       
        private void DisplayMsg(string message, string title)
        {
            MessageBox.Show(message, title);
        }
        //end of DisplayMsg function

        //When user click on Reset button
        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetTrip();
        }

        //When user open the program 
        private void Form1_Load(object sender, EventArgs e)
        {
            ResetTrip();
        }

        //when user select Cuba radio button
        private void radCuba_CheckedChanged(object sender, EventArgs e)
        {
            SetFlight();                
            
        }
        //When user select Florida radio button
        private void radFlorida_CheckedChanged(object sender, EventArgs e)
        {
            SetFlight();
            
        }
        //When user select Mexico radio button
        private void radMexico_CheckedChanged(object sender, EventArgs e)
        {
            SetFlight();
         
        }
        //When user click on Book button
        private void btnBook_Click(object sender, EventArgs e)
        {
            int people;
            double price = 0;
            string location = "Cuba";
            const int MINPEOPLE = 1;
            const int MAXPEOPLE = 10;
            const double DISCOUNT = 0.10;
            const string PHONE = "555-1212";



            //Validade input text if it is an integer
            //will validade if data inputed is not an integer first
            if (!int.TryParse(txtPeople.Text, out people))
            {
                DisplayMsg("People must be a whole number", "Input Error");
                txtPeople.Focus();
                txtPeople.SelectAll();
            }
            //will validade if people is out of range 1-10
            else if (people<1 || people>10)
            {
                DisplayMsg("People must be between "+ MINPEOPLE +"-"+MAXPEOPLE, "Input Error");
                txtPeople.Focus();
                txtPeople.SelectAll();
            }
            else
            {

                //this sequence will price and add the value formatted do currency 2 digits .
                if (radMexico.Checked)
                {
                    location = "Mexico";
                    price= people * 2300.79;
                }
                else if (radFlorida.Checked)
                {
                    location = "Florida";
                    price= people*  2150.50;
                }
                else if (radCuba.Checked)
                {
                    location = "Cuba";
                    price= people*  2150.50;
                }//end of radiobutton varification

                //if cash selected apply discount of 10% and put value on lblPrice
                if (radCash.Checked)
                {
                    price = price + DISCOUNT*price;
                    lblPrice.Text = price.ToString("c2");
                }
                else if (radCreditCard.Checked)
                {
                    lblPrice.Text = price.ToString("c2");
                }

                //after all verification start the trip information label

                lblTripInformation.Text= "";
                //this will add the first lines and wait to be add more info.
                lblTripInformation.Text=" Booked by Kang\n\nPeople: " + people.ToString("d2") +
                    "\nLocation: " + location.ToUpper();

                //verify if checkbox flight Included true , add message " Flight Included "
                if (chkFlightIncluded.Checked)
                {
                    lblTripInformation.Text += "\nFlight Included";
                }

                //If radio button cash checked , add message " Cash discount applied "
                if (radCash.Checked)         
                {

                    lblTripInformation.Text += "\nCash Discount Applied";
                }


                //then, add final price.
                lblTripInformation.Text += "\nPrice: "+ lblPrice.Text;

                //make trip Information label visible
                grpTripInformation.Visible=true;

                //Disable the entire book groupbox
                grpBook.Enabled=false;               

                //Swtich to give an offer if value input is 1 or 3. DisplayMsg call a const PHONE 
                switch (people)
                {
                    case 1:
                    case 3:
                        DisplayMsg("Special when booking single or triple.\nBOGO Special - Call "+ PHONE +
                            " to receive another person free!", "Limited Time Offer");
                        break;

                }//end switch
            }//end else
        }//end of book click event    
        
        //When user click on Confirm button, it shows a message, clear the form and enage group Book
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            //get prive from label (already formatted)
            DisplayMsg("Trip booked and paid\nPrice: "+lblPrice.Text , "Confirmation Email Sent");
            grpBook.Enabled=true;
            ResetTrip();

        }//end of confirm event
    }//end program
}
