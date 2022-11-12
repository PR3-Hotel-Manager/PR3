using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Management__Beta_1._0_
{
    class GuestInfo
    {
        String Age { get; set; }
        String FirstName { get; set; }
        String Stay { get; set; }
        class payment
        {
            String Time { get; set; }
            String paymentType { get; set; }
            double price { get; set; }
        }
        class room
        {
            String BedConfiguration { get; set; }
            Boolean Occupied { get; set; }
            String RoomNumber { get; set; }
        }
    }
}
