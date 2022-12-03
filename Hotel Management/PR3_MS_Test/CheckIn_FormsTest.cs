using Hotel_Management__Beta_1;
using Hotel_Management__Beta_1._0_;

namespace PR3_MS_Test
{
    [TestClass]
    public class CheckIn_FormsTest
    {
        FirebaseSingleton db = FirebaseSingleton.Instance;


        void setupDB()
        {
            Main_Form main_Form = new Main_Form();
            db.DeleteGuestDictionary();
            main_Form.InitGuestData();
        }



        [TestMethod]
        public void performCheckIn_RoomIsNotOppucied_ReturnsTrue()
        {
            db.StartFirebase();
            setupDB();
            CheckIn_Form checkIn_Form = new CheckIn_Form();
            Payment payment = new Payment();

            // Arrange
            string firstName = "Michael";
            string lastName = "Granberry";
            string age = "32";
            string stayLength = "6";
            string roomNumber = "1";
            string bedConfig = "1";
            string price = payment.CalculatePrice(Convert.ToDecimal(bedConfig), Convert.ToDecimal(stayLength)).ToString();
            string paymentType = "Cash";
            Guest guest = new Guest();

            // Act
            var result = checkIn_Form.performCheckIn(guest,
                                                      firstName,
                                                      lastName,
                                                      age,
                                                      stayLength,
                                                      roomNumber,
                                                      bedConfig,
                                                      price,
                                                      paymentType);

            // Assert
            Assert.IsTrue(result);
        }


        [TestMethod]
        public void performCheckIn_RoomIsOppucied_ReturnsFalse()
        {
            db.StartFirebase();
            CheckIn_Form checkIn_Form = new CheckIn_Form();
            Payment payment = new Payment();

            // Arrange
            string firstName = "Raymond";
            string lastName = "B";
            string age = "26";
            string stayLength = "4";
            string roomNumber = "1";
            string bedConfig = "1";
            string price = payment.CalculatePrice(Convert.ToDecimal(bedConfig), Convert.ToDecimal(stayLength)).ToString();
            string paymentType = "Cash";
            Guest guest = new Guest();

            // Act
            var result = checkIn_Form.performCheckIn(guest,
                                                      firstName,
                                                      lastName,
                                                      age,
                                                      stayLength,
                                                      roomNumber,
                                                      bedConfig,
                                                      price,
                                                      paymentType);

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void performCheckIn_InvalidInput_ReturnsFalse()
        {
            db.StartFirebase();
            CheckIn_Form checkIn_Form = new CheckIn_Form();
            Payment payment = new Payment();

            // Arrange
            string firstName = "Raymond";
            string lastName = "B";
            string age = "26";
            string stayLength = "4";
            string roomNumber = "-1";
            string bedConfig = "1";
            string price = payment.CalculatePrice(Convert.ToDecimal(bedConfig), Convert.ToDecimal(stayLength)).ToString();
            string paymentType = "Cash";
            Guest guest = new Guest();

            // Act
            var result = checkIn_Form.performCheckIn(guest,
                                                      firstName,
                                                      lastName,
                                                      age,
                                                      stayLength,
                                                      roomNumber,
                                                      bedConfig,
                                                      price,
                                                      paymentType);

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void VerifyInputs_ValidInput_ReturnsTrue()
        {
            CheckIn_Form checkIn_Form = new CheckIn_Form();
            // Arrange
            string firstName = "Raymond";
            string lastName = "B";

            // Act
            var result = checkIn_Form.verifyInputs(firstName, lastName);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void VerifyInputs_InvalidInput_ReturnsFalse()
        {
            CheckIn_Form checkIn_Form = new CheckIn_Form();
            // Arrange
            string firstName = "Raymond";
            string lastName = "";

            // Act
            var result = checkIn_Form.verifyInputs(firstName, lastName);

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void VerifyInputs_NoInput_ReturnsFalse()
        {
            CheckIn_Form checkIn_Form = new CheckIn_Form();
            // Arrange
            string firstName = "";
            string lastName = "";

            // Act
            var result = checkIn_Form.verifyInputs(firstName, lastName);

            // Assert
            Assert.IsFalse(result);
        }
    }
}