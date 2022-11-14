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
        public IFirebaseClient client;

        private static string BasePath
        {
            get { return basePath; }
        }

        private static string AuthSecret
        {
            get { return authSecret; }
        }

        // FirebaseSingleton Empty Constructor
        private FirebaseSingleton() { }

        // Singleton Instance
        public static FirebaseSingleton Instance
        {
            get 
            { 
                if (instance == null)
                {
                    instance= new FirebaseSingleton();
                } 
                return instance; 
            }
        }

        // Configures Authentication secret and Basepath
        static readonly IFirebaseConfig config = new FirebaseConfig()
        {
            AuthSecret = AuthSecret,
            BasePath = BasePath
        };

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

        // Used only in Main-Form. Inserts an entire Guest dictionary in the FireBase Realtime data. 
        public void InitFireBaseWithData(Dictionary<string, Guest> initGuestData)
        {
            this.client.Set(K.FirebaseTopFolder + "/", initGuestData);
        }

        // Fecths the Guest dictionary in Firebase as a JSON collection. Used only in Main-Form and GetFirebaseResponse().
        public FirebaseResponse GetFirebaseResponse()
        {
            return this.client.Get(@K.FirebaseTopFolder);
        }


        // Inserts a guest into a room in the Firebase Realtime database.
        public void UpdateRoomStatus(Guest guest)
        {
            var firebaseKey = K.FirebaseKey(guest.room.RoomNumber);
            this.client.Set(K.FirebaseTopFolder + "/" + firebaseKey, guest);
        }



        // Returns a Dictionary of the Firebase JSON collection.
        public Dictionary<string, Guest> GetData ()
        {
            Dictionary<string, Guest> data;
            try
            {
                FirebaseResponse res = GetFirebaseResponse();

                if (res.Body.ToString() == "null")
                {
                    MessageBox.Show("No data in Firebase Realtime database.", "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    data = null;
                    return data;
                }
                else
                {
                    data = JsonConvert.DeserializeObject<Dictionary<string, Guest>>(res.Body.ToString());
                    return data;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Connection Error.", "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                data = null;
                return data;
            }
        }

        // Returns an Array of guests sorted by room number. Zero Based.
        public Guest[] GetSortedData()
        {
            Dictionary<string, Guest> data = GetData();
            Guest[] sortedRooms = new Guest[K.NumberOfRooms];
            for (var i = 0; i < K.NumberOfRooms; i++)
            {
                string firebaseKey = K.FirebaseKey((i + 1).ToString());
                int index = Convert.ToInt32(data[firebaseKey].room.RoomNumber) - 1;
                Guest guest = data[firebaseKey];
                sortedRooms[index] = guest;
            }
            return sortedRooms;
        }


    }
}
