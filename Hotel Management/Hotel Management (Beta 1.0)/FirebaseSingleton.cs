using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Management__Beta_1._0_
{
    internal class FirebaseSingleton
    {
        // Class Attributes
        private static FirebaseSingleton instance = new FirebaseSingleton();
        private static readonly string basePath = "https://pr3-hotel-manager-default-rtdb.firebaseio.com/";
        private static readonly string authSecret = "4LVoVYi4G6e37CW2wquSpciQfTwOOHWmuBotCTkx";
        private IFirebaseClient client;

        private static string BasePath
        {
            get { return basePath; }
        }

        private static string AuthSecret
        {
            get { return authSecret; }
        }

        // Singleton Instance
        public static FirebaseSingleton Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new FirebaseSingleton();
                }
                return instance;
            }
        }

        // FirebaseSingleton Empty Constructor
        private FirebaseSingleton() { }


        // Configures Authentication secret and Basepath
        static readonly IFirebaseConfig config = new FirebaseConfig()
        {
            AuthSecret = AuthSecret,
            BasePath = BasePath
        };

        // Methods ------------------------------------

        // Checks Firebase connection
        async private void checkConnection()
        {

            try
            {
                client = new FireSharp.FirebaseClient(config);
            }
            catch
            {
                MessageBox.Show("Unable to establish connection.");

            }

        }

        // Initiates Firebases Connection
        public void StartFirebase()
        {
            checkConnection();
        }

        // Used only in Main-Form. Inserts an entire Guest dictionary into the FireBase Realtime database. 
        public void InsertGuestDictionary(Dictionary<string, Guest> initGuestData)
        {
            this.client.Set(K.FirebaseTopFolder + "/", initGuestData);
        }

        // Retrieves JSON collection from Firebase. Used only in Main-Form and GetFirebaseResponse().
        public FirebaseResponse GetFirebaseResponse()
        {
            return this.client.Get(@K.FirebaseTopFolder);
        }

        // =========================================
        // Use these functions 
        // =========================================

        // Inserts a single guest into a room in the Firebase Realtime database.
        public void InsertGuest(Guest guest)
        {
            var firebaseKey = K.GuestKey(guest.room.RoomNumber);
            this.client.Set(K.FirebaseTopFolder + "/" + firebaseKey, guest);
        }

        // Returns a Dictionary of the Firebase JSON collection. Key = string: Room Number, Value = Guest: guest.
        public Dictionary<string, Guest> GetGuestDictionary()
        {
            Dictionary<string, Guest> guestDictionary;
            try
            {
                FirebaseResponse res = GetFirebaseResponse();

                if (res.Body.ToString() == "null")
                {
                    MessageBox.Show("No data in Firebase Realtime database.", "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    guestDictionary = null;
                    return guestDictionary;
                }
                else
                {
                    guestDictionary = JsonConvert.DeserializeObject<Dictionary<string, Guest>>(res.Body.ToString());
                    return guestDictionary;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Connection Error.", "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                guestDictionary = null;
                return guestDictionary;
            }
        }

        // Returns an Array of guests sorted by room number. Zero Based.
        public Guest[] GetSortedGuest()
        {
            Dictionary<string, Guest> guestDictionary = GetGuestDictionary();
            Guest[] sortedRooms = new Guest[K.NumberOfRooms];
            for (var i = 0; i < K.NumberOfRooms; i++)
            {
                string firebaseKey = K.GuestKey((i + 1).ToString());
                int index = Convert.ToInt32(guestDictionary[firebaseKey].room.RoomNumber) - 1;
                Guest guest = guestDictionary[firebaseKey];
                sortedRooms[index] = guest;
            }
            return sortedRooms;
        }

    }
}
