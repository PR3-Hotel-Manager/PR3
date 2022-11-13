using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Management__Beta_1._0_
{
    public class JSONGuestModel
    {
        // Attributes -------------------------
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Age { get; set; }
        public string Stay { get; set; }
        public JSONRooms room;
        public JSONPayment payment;
    }

    public class JSONRooms
    {
        public string RoomNumber { get; set; }
        public string BedConfiguration { get; set; }
        public bool Occupied { get; set; }
    }

    public class JSONPayment
    {
        public double price { get; set; }
        public string paymentType { get; set; }
        public string Time { get; set; }
    }
}
