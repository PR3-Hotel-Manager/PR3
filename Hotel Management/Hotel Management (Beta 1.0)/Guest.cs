using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public Guest(string firstName, string lastName, string age, string stay, Room room, Payment payment)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.Stay = stay;
            this.room = room;
            this.payment = payment;
        }

    }
}
