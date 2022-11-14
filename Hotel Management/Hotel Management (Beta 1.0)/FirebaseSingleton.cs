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

        private FirebaseSingleton() { }

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

        static readonly IFirebaseConfig config = new FirebaseConfig()
        {
            AuthSecret = AuthSecret,
            BasePath = BasePath
        };

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

        public void StartFirebase()
        {
            checkConnection();
        }

        public void UpdateRoomStatus(Guest guest)
        {
            var firebaseKey = K.FirebaseKey(guest.room.RoomNumber);
            this.client.Set(K.FirebaseTopFolder + "/" + firebaseKey, guest);
        }

        public void InitFireBaseWithData(Dictionary<string, Guest> initGuestData)
        {
            this.client.Set(K.FirebaseTopFolder + "/", initGuestData);
        }

        public FirebaseResponse GetFirebaseResponse()
        {
            return this.client.Get(@K.FirebaseTopFolder);
        }

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
