using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Management__Beta_1._0_
{
    static class K
    {
        // Attributes -------------------------
        private static readonly int numberOfRooms = 40;
        private static readonly string firebaseTopFolder = "Guest";

        // Getters -----------------------------


        public static int NumberOfRooms
        {
            get { return numberOfRooms; }
        }

        public static string FirebaseTopFolder
        {
            get { return firebaseTopFolder; }
        }

        public static string FirebaseKey (string roomNumber)
        {
            return "Room: " + roomNumber;
        }

    }
}