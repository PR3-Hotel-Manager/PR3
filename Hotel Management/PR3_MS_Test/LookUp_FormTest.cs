using Hotel_Management__Beta_1._0_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR3_MS_Test
{
    [TestClass]
    public class LookUp_FormTest
    {
        FirebaseSingleton db = FirebaseSingleton.Instance; 

        void setupDB() //Databse initialization method
        {
            Main_Form main_Form = new Main_Form(); // Not sure if needed
            db.DeleteGuestDictionary();
            main_Form.InitGuestData();
        }

        [TestMethod]
        public void LookUp_Form_TestTrue()
        {
            LookUp_Form lookUp_Form = new LookUp_Form(); //New instance

            // Arrange 

            string firstName = "Ralph";
            string lastName = "Frem";

            //

            //

        }
    }
}
