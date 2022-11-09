using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Management__Beta_1._0_
{
    public class Room
    {
        // Attributes -------------------------
        public string RoomNumber { get; set; }
        public string BedConfiguration { get; set; }
        public bool Occupied { get; set; }

        // Conctrustors -------------------------------
        public Room(string roomNumber, string bedConfiguration, bool occupied)
        {
            this.RoomNumber = roomNumber;
            this.BedConfiguration = bedConfiguration;
            this.Occupied = occupied;
        }
    }


}