using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    class Party
    {
        private double costPerPerson;
        private string[] guestList;
        public Party(int maxNumOfGuests) //constructor 
        {
            guestList = new string[maxNumOfGuests];
        }

            public double CostPerPerson //sets cost per person as long as zero or above
        {
            get{ return costPerPerson; }
            set
        {
            if (value >= 0)
                {
                    costPerPerson = value;
                }
            }
        }
        private double NumOfGuests()    //returns amount of guests  equal to party array elements
        {
            double numOfGuests = 0;

            for(int i = 0; i < guestList.Length; i++)
            {
                if(!string.IsNullOrEmpty(guestList[i])) //open spots to the party is'nt counted only filled ones
                {
                    numOfGuests++;
                }
            }
            return numOfGuests;
        }
        private int FirstVacantPosition() //find first available position in array
        {
            int vacant = -1;
            for(int i = 0; i < guestList.Length; i++) //go through array
            {
                if(string.IsNullOrEmpty(guestList[i])) //first empty
                {
                    vacant = i; //position i in array is first vacant
                    break;       
                }
            }
            return vacant;
        }
        public bool AddGuest(string firstName, string lastName) //calls to find first vacant pos, add guest to that position
        {
            bool ok = true;
            int vacantPos = FirstVacantPosition();
            if(vacantPos != -1) //-1 if array is full
            {
                guestList[vacantPos] = FullName(firstName, lastName); 
            }
            else
            {
                ok = false;
            }
            return ok;

        }
        private string FullName(string firstName, string lastName) //last name letters to capitals, combines first and last name into one string with ',' between
        {
            return lastName.ToUpper() + "," + firstName;
        }
        public bool Delete(int index) //emptying string at array position index making it empty
        {
            bool ok = false;
            if(CheckIndex(index))
            {
                guestList[index] = string.Empty;
                OneStepLeft(index);
                ok = true;
            }
            return ok;
        }
        private void OneStepLeft(int index) //rearrange array so all empty positions are last in array
        {
            for(int i=index+1; i < guestList.Length; i++)
            {
                guestList[i - 1] = guestList[i];
                guestList[i] = string.Empty;
            }
        }
        private bool CheckIndex(int index) //makes sure the arrayposition ain't empty
        {
            if(guestList[index] != null)
            {
                return true;
            }
            return false;
        }
        public string[] GetGuestList() //returns full guestlist for UpdateGUI() - what's being showed in list box
        {
            int size = Convert.ToInt32(NumOfGuests());

            if(size <= 0) 
            {
                return null; //no guests
            }

            string[] guests = new string[size]; 

            for(int i = 0,j = 0; i < guestList.Length; i++)
            {
                if(!string.IsNullOrEmpty(guestList[i])) //copies all but empty array positions
                {
                    guests[j++] = guestList[i];
                }
            }
            return guests;
        }
        public double CalcTotalCost(Party party)
        {
            double totalCost = 0;

            totalCost = party.CostPerPerson * party.NumOfGuests();

            return totalCost;

        }
        public int NumberOfGuests()
        {
            int total = Convert.ToInt32(NumOfGuests());
            return total;
        }
    }
}
