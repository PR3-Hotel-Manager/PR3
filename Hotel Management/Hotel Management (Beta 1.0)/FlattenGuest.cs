using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Management__Beta_1._0_
{
    internal class FlattenGuest
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Age { get; set; }
        public string Stay { get; set; }
        public string RoomNumber { get; set; }
        public string BedConfiguration { get; set; }
        public Boolean Occupied { get; set; }
        public double Price { get; set; }
        public string PaymentType { get; set; }
        public string Time { get; set; }



        public FlattenGuest()
        {
            this.FirstName = "";
            this.LastName = "";
            this.Age = "";
            this.Stay = "";
            this.RoomNumber = "";
            this.BedConfiguration = "";
            this.Occupied = false;
            this.Price = 0;
            this.PaymentType = "";
            this.Time = "";
        }

        public FlattenGuest(string firstName, string lastname, string age, string stay, string roomNumber, string bedConfiguration, Boolean occupied, double price, string paymentType, string time)
        {
            this.FirstName = firstName;
            this.LastName = lastname;
            this.Age = age;
            this.Stay = stay;
            this.RoomNumber = roomNumber;
            this.BedConfiguration = bedConfiguration;
            this.Occupied = occupied;
            this.Price = price;
            this.PaymentType = paymentType;
            this.Time = time;
        }

        public FlattenGuest(string roomNumber)
        {
            this.FirstName = "";
            this.LastName = "";
            this.Age = "";
            this.Stay = "";
            this.RoomNumber = roomNumber;
            this.BedConfiguration = "";
            this.Occupied = false;
            this.Price = 0;
            this.PaymentType = "";
            this.Time = "";
        }

    }
}
