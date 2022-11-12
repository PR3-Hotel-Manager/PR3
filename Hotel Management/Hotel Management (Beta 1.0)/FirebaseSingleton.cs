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
        private readonly string basePath = "https://pr3-hotel-manager-default-rtdb.firebaseio.com/";
        private readonly string authSecret = "4LVoVYi4G6e37CW2wquSpciQfTwOOHWmuBotCTkx";
        public IFirebaseClient client;

        public string BasePath
        {
            get { return basePath; }
        }

        public string AuthSecret
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
            AuthSecret = Constants.AuthSecret,
            BasePath = Constants.BasePath
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

    }
}
