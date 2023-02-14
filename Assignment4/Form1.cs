using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment4
{
    public partial class MainForm : Form
    {
        Party party;
        public MainForm()
        {
            InitializeComponent();
            InitializeGUI();
        }

        private void InitializeGUI() //decides what values the form shall provide at start of program
        {
            txtFirstName.Text = string.Empty;
            txtLastName.Text = string.Empty;

            txtTotalNumberOfGuests.Text = string.Empty;
            txtCostPerPerson.Text = string.Empty;
            txtNumberOfGuests.Text = string.Empty;

            grpAddGuests.Enabled = false;
            grpNewParty.Enabled = true;
        }

        private bool CreateParty() //check user input + creates boundries of max guests
        {
            int maxNum = 0;
            bool ok = true;

            if(int.TryParse(txtTotalNumberOfGuests.Text, out maxNum) && (maxNum > 0)) //converts numberofguests to int maxNum and needs to be able to do so + be above zero
            {
                party = new Party(maxNum);  //new party object
                MessageBox.Show($"Party list with space for {maxNum} guests created", "Success");
            }
            else //if maxNum is'nt numbers only or negative number
            {
                MessageBox.Show("Invalid number of guests. Please try again!", "Error");
                ok = false;
            }
            return ok;
        }
        private bool ReadCostPerPerson() //checks input from user + creates cost per person
        {
            bool ok = false;
            double cost = double.Parse(txtCostPerPerson.Text);

            if(txtCostPerPerson.Text == string.Empty || cost < 0) //empty string or below zero will return false
            {
                ok = false;
            }
            else
            {
                ok = true;
                party.CostPerPerson = cost; //party objects cost value = cost input
            }
            return ok;
        }

        private void UpdateGUI() //Update: clear list, get current guests from list - from party object, empty list if no guestlist, sets values  
                                 
        {
            lstGuestList.Items.Clear();
            string[] guestList = party.GetGuestList();

            if(guestList != null)
            {
                for(int i = 0; i < guestList.Length; i++)
                {
                    string str = $"{i + 1,4}{guestList[i],-20}"; //string interpolation
                    lstGuestList.Items.Add(str);
                }
            }
            else
            {
                return;
            }

            double totalCost = party.CalcTotalCost(party);
            txtTotalCost.Text = totalCost.ToString("0.00");
            int x;
            x = Convert.ToInt32(party.NumberOfGuests());
            txtNumberOfGuests.Text = x.ToString();

        }

        private bool CheckIndexNumber() //prevent the program from crashing if delete or change buttons are pushed without an item from the list being selected
        {
            if(lstGuestList.SelectedIndex != -1) //no item from list is selected, or none exist
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void ListLabel_Click(object sender, EventArgs e)
        {

        }

        private void btnCreateList_Click(object sender, EventArgs e) //create party - calls CreateParty() and ReadCostPerPerson() and updates GUI if all is OK
        {
            bool maxNumOk = CreateParty();

            if(!maxNumOk)
            {
                return;
            }

            bool amountOk = ReadCostPerPerson();
            if(amountOk && maxNumOk)
            {
                grpAddGuests.Enabled = true; //if list is created properly, enable the option to add guests
                UpdateGUI();
            }
        }

        private void CostTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e) //change button use - 
        {
            bool ok = CheckIndexNumber();

            if (ok) //if true, and is a number - change selected index info
            {
                party.Delete(lstGuestList.SelectedIndex);           //calls to delete info
                party.AddGuest(txtFirstName.Text, txtLastName.Text); //calls to add the new info
                UpdateGUI();
            }
        }

        private void AddButton_Click(object sender, EventArgs e) //adds guests if first and last name input is ok
        {
            if(TrimNames())
            {
                bool ok = party.AddGuest(txtFirstName.Text, txtLastName.Text); //calls addguest from party object
                if(!ok)
                {
                    MessageBox.Show("List is full. New guest not added!", "Error"); 
                }
                else
                {
                    UpdateGUI();
                }
            }
        }
        private bool TrimNames() //trim guest name if validatetext returns true
        {
            if((!ValidateText(txtFirstName.Text)) || (!ValidateText(txtFirstName.Text))) 
            {
                return false;
            }
            else
            {
                txtFirstName.Text = txtFirstName.Text.Trim();
                txtLastName.Text = txtLastName.Text.Trim();
                return true;
            }
        }
        private bool ValidateText(string text) //returns true if user input is correctly
        {
            text = text.Trim();

            if(string.IsNullOrEmpty(text)) //no input returns error message
            {
                MessageBox.Show("Please provide both first and last name.", "Error");
                return false;
            }
            return true;
        }

        private void TotalLbl_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e) //delete button
        {
            bool ok = CheckIndexNumber();

            if (ok)
            {
                party.Delete(lstGuestList.SelectedIndex);
                UpdateGUI();
            }
            
        }

        private void lstGuestList_SelectedIndexChanged(object sender, EventArgs e) //if item from list is selected the string will be divided to last and frist name + lists number is trimmed
                                                                                    //then showed in last and first name textboxes
                                                                                    //lastname will however still be in capital letters
        {
            string str = lstGuestList.GetItemText(lstGuestList.SelectedItem); //new string full name
            char[] seperator = {',', ' '}; 

            string tempXName = string.Empty;
            string tempYName = string.Empty; ;

            if(str != string.Empty)
            {
                string[] strlist = str.Split(seperator, StringSplitOptions.RemoveEmptyEntries); //seperates last from last name through seperator
                tempYName = strlist[0];
                tempXName = strlist[1];
            }

            txtFirstName.Text = tempXName;
            txtLastName.Text = tempYName.Trim(new Char[] { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' }); //trims listnumber from last name
        }
    }
}
