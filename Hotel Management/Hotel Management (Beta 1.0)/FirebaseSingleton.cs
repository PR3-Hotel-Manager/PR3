using FireSharp.Config;
using FireSharp.Interfaces;
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

    }
}
