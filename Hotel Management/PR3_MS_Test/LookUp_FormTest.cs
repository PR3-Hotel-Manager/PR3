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
        public void PerformSearch_ResultOneMatch_ReturnsOne()
        {
            db.StartFirebase();
            setupDB();
            CheckIn_Form checkIn_Form = new CheckIn_Form();
            Payment payment = new Payment();
            LookUp_Form lookUp_Form = new LookUp_Form(); //New instance

            // Arrange 
            string firstName = "Ralph";
            string lastName = "Frem";
            string age = "32";
            string stayLength = "6";
            string roomNumber = "1";
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

            string firstNameTest = "Ralph";
            string lastNameTest = "Frem";
            var testVar = 1;

            //Act 
            var result = lookUp_Form.performSearch(firstNameTest, lastNameTest);

            //Assert
            Assert.AreEqual(testVar, result);
        }

        [TestMethod]
        public void PerformSearch_NoMatch_ReturnsZero()
        {
            LookUp_Form lookUp_Form = new LookUp_Form(); //New instance

            string firstNameTest = "Tyler";
            string lastNameTest = "Hampsten";
            var testVar = 0;

            //Act 
            var result = lookUp_Form.performSearch(firstNameTest, lastNameTest);

            //Assert
            Assert.AreEqual(testVar, result);

        }
    }
}
