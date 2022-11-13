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
        public JSONPayment payment { get; set; }
        public JSONRooms room { get; set; }
        
    }

    public class JSONPayment
    {
        public string PaymentType { get; set; }
        public double Price { get; set; }
        public string Time { get; set; }
    }
    public class JSONRooms
    {
        public string BedConfiguration { get; set; }
        public bool Occupied { get; set; }
        public string RoomNumber { get; set; }
    }

}
