using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hotel_Management__Beta_1._0_;

namespace PR3_MS_Test
{
    internal class CheckOut_FormsTest
    {
        FirebaseSingleton db = FirebaseSingleton.Instance;

        void setupDB()
        {
            Main_Form main_Form = new Main_Form();
            db.DeleteGuestDictionary();
            main_Form.InitGuestData();
        }

        [TestMethod]
        public void performCheckOut_RoomIsOccupied_ReturnsTrue()
        {
            db.StartFirebase();
            setupDB();

            CheckOut_Form checkOut_Form = new CheckOut_Form();

            // Arrange
            int roomNumber = 1;

            var result = checkOut_Form.performCheckout(roomNumber);
            Assert.IsTrue(result);

        }

        public void performCheckOut_RoomIsNotOccupied_ReturnsFalse()
        {

        }

        public void performCheckOut_InvalidInput_ReturnsFalse()
        {

        }

    }
}
