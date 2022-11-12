using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Management__Beta_1._0_
{
    static class Constants
    {
        // Attributes -------------------------
        private static readonly int numberOfRooms = 10;

        // Getters -----------------------------


        public static int NumberOfRooms
        {
            get { return numberOfRooms; }
        }

        public static string FirebaseKey (string roomNumber)
        {
            return "Room: " + roomNumber;
        }

    }
}