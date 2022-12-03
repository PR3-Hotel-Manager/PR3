using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hotel_Management__Beta_1;
using Hotel_Management__Beta_1._0_;

namespace PR3_MS_Test
{
    [TestClass]
    public class CheckOut_FormsTest
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
            CheckIn_Form checkIn_Form = new CheckIn_Form();
            Payment payment = new Payment();

            // Arrange
            string firstName = "Michael";
            string lastName = "Granberry";
            string age = "32";
            string stayLength = "6";
            string roomNumber = "5";
            string bedConfig = "1";
            string price = payment.CalculatePrice(Convert.ToDecimal(bedConfig), Convert.ToDecimal(stayLength)).ToString();
            string paymentType = "Cash";
            Guest guest = new Guest();

            checkIn_Form.performCheckIn(guest,
                                        firstName,
                                        lastName,
                                        age,
                                        stayLength,
                                        roomNumber,
                                        bedConfig,
                                        price,
                                        paymentType);

            string checkoutNumber = "5";

            // Act
            var result = checkOut_Form.performCheckout(checkoutNumber);
            Assert.IsTrue(result);

        }

        [TestMethod]
        public void performCheckOut_RoomIsNotOccupied_ReturnsFalse()
        {


            CheckOut_Form checkOut_Form = new CheckOut_Form();
            CheckIn_Form checkIn_Form = new CheckIn_Form();
            Payment payment = new Payment();

            // Arrange
            string firstName = "Michael";
            string lastName = "Granberry";
            string age = "32";
            string stayLength = "6";
            string roomNumber = "5";
            string bedConfig = "1";
            string price = payment.CalculatePrice(Convert.ToDecimal(bedConfig), Convert.ToDecimal(stayLength)).ToString();
            string paymentType = "Cash";
            Guest guest = new Guest();

            checkIn_Form.performCheckIn(guest,
                                        firstName,
                                        lastName,
                                        age,
                                        stayLength,
                                        roomNumber,
                                        bedConfig,
                                        price,
                                        paymentType);

            string checkoutNumber = "40";

            // Act
            var result = checkOut_Form.performCheckout(checkoutNumber);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void performCheckOut_InvalidInput_ReturnsFalse()
        {


            CheckOut_Form checkOut_Form = new CheckOut_Form();

            // Arrange
            string roomNumberTooHigh = "50";
            string roomNumberNegative = "-1";

            // Act
            var result = checkOut_Form.performCheckout(roomNumberTooHigh);
            Assert.IsFalse(result);

            result = checkOut_Form.performCheckout(roomNumberNegative);
            Assert.IsFalse(result);
        }

    }
}
