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
        private static readonly string basePath = "https://pr3-database-default-rtdb.firebaseio.com/";
        private static readonly string authSecret = "PJR1BSmziUf1qGe5IzBqGk8VX2fq8PBsceibi1JZ";

        // Getters -----------------------------
        public static string BasePath
        {
            get { return basePath; }
        }

        public static string AuthSecret
        {
            get { return authSecret; }
        }
    }
}