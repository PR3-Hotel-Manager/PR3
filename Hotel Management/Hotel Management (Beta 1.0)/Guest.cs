using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Hotel_Management__Beta_1._0_
{
    public class Guest
    {
        // Attributes -------------------------
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Age { get; set; }
        public string Stay { get; set; }
        public Room room;
        public Payment payment;

        // Conctrustors -------------------------------
        public Guest()
        {
            this.FirstName = "";
            this.LastName = "";
            this.Age = "";
            this.Stay = "";
            this.room = new Room("","",false);
            this.payment = new Payment(0, "");
        }

        public Guest(string roomNumber)
        {
            this.FirstName = "";
            this.LastName = "";
            this.Age = "";
            this.Stay = "";
            this.room = new Room(roomNumber, InitBedConfiguration(roomNumber), false);
            this.payment = new Payment(0, "");
        }

        public Guest(string firstName, string lastName, string age, string stay, Room room, Payment payment)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.Stay = stay;
            this.room = room;
            this.payment = payment;
        }

        // Methods ------------------------------------
        private string InitBedConfiguration(string roomNumber)
        {
            int rNum = Convert.ToInt32(roomNumber);
            if (rNum <= 15)
            {
                return 1.ToString();
            }
            else
            {
                return 2.ToString();

            }
        }
    }
}