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

        void addTestGuests()
        {
            //ADDING FOLLOWING GUESTS:
            //Ralph Frem 
            //Ralph Granberry
            //John Frem 
            //Joe Frem 
            //
            //First Name Return 2
            //Last Name Return 3

            db.StartFirebase();
            setupDB();
            CheckIn_Form checkIn_Form = new CheckIn_Form();
            Payment payment = new Payment();

            //ONE FULL MATCH DATA// 
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
            //-------END-------//

            //FIRST MATCH DATA//
            string firstName1 = "Ralph";
            string lastName1 = "Granberry";
            string age1 = "33";
            string stayLength1 = "7";
            string roomNumber1 = "2";
            string bedConfig1 = "1";
            string price1 = payment.CalculatePrice(Convert.ToDecimal(bedConfig1), Convert.ToDecimal(stayLength1)).ToString();
            string paymentType1 = "Cash";
            Guest guest1 = new Guest();

            checkIn_Form.performCheckIn(guest1,
                                                    firstName1,
                                                    lastName1,
                                                    age1,
                                                    stayLength1,
                                                    roomNumber1,
                                                    bedConfig1,
                                                    price1,
                                                    paymentType1);
            //-------END-------//

            //LAST NAME MATCH DATA//
            string firstName2 = "John";
            string lastName2 = "Frem";
            string age2 = "34";
            string stayLength2 = "8";
            string roomNumber2 = "3";
            string bedConfig2 = "1";
            string price2 = payment.CalculatePrice(Convert.ToDecimal(bedConfig2), Convert.ToDecimal(stayLength2)).ToString();
            string paymentType2 = "Cash";
            Guest guest2 = new Guest();

            checkIn_Form.performCheckIn(guest2,
                                                    firstName2,
                                                    lastName2,
                                                    age2,
                                                    stayLength2,
                                                    roomNumber2,
                                                    bedConfig2,
                                                    price2,
                                                    paymentType2);
            //-------END-------//

            //LAST NAME MATCH DATA 2//
            string firstName3 = "Joe";
            string lastName3 = "Frem";
            string age3 = "32";
            string stayLength3 = "6";
            string roomNumber3 = "4";
            string bedConfig3 = "1";
            string price3 = payment.CalculatePrice(Convert.ToDecimal(bedConfig3), Convert.ToDecimal(stayLength3)).ToString();
            string paymentType3 = "Cash";
            Guest guest3 = new Guest();

            checkIn_Form.performCheckIn(guest3,
                                                    firstName3,
                                                    lastName3,
                                                    age3,
                                                    stayLength3,
                                                    roomNumber3,
                                                    bedConfig3,
                                                    price3,
                                                    paymentType3);
            //-------END-------//
        }

        [TestMethod]
        public void PerformSearch_ResultOneMatch_ReturnsOne()// One match found 
        {

            LookUp_Form lookUp_Form = new LookUp_Form(); //New instance

            // Arrange 
            string firstNameTest = "Ralph";
            string lastNameTest = "Frem";
            var testVar = 1;

            //Act 
            var result = lookUp_Form.performSearch(firstNameTest, lastNameTest);

            //Assert
            Assert.AreEqual(testVar, result);
        }

        [TestMethod]
        public void PerformSearch_NoMatch_ReturnsZero()//0 Matches found 
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

        [TestMethod]
        public void PerformSearch_FirstNameMatch_ReturnsTwo()//First Name Match found 
        //GUESTS:
        //Ralph Frem 
        //Ralph Granberry
        //John Frem 
        //Joe Frem 
        //First Name Return 2
        //Last Name Return 3
        {
            addTestGuests();
            LookUp_Form lookUp_Form = new LookUp_Form(); //New instance

            string firstNameTest = "Ralph";
            string lastNameTest = "";
            int testVar = 2;

            //Act 
            int result = lookUp_Form.performSearch(firstNameTest, lastNameTest);

            //Assert
            Assert.AreEqual(testVar, result);
        }

        [TestMethod]
        public void PerformSearch_LastNameMatch_ReturnsThree()//Last Name Match found 
        //GUESTS:
        //Ralph Frem 1
        //Ralph Granberry 2
        //John Frem 3
        //Joe Frem 4
        //First Name Return 2
        //Last Name Return 3
        {
            LookUp_Form lookUp_Form = new LookUp_Form(); //New instance

            string firstNameTest = "";
            string lastNameTest = "Frem";
            var testVar = 3;

            //Act 
            var result = lookUp_Form.performSearch(firstNameTest, lastNameTest);

            //Assert
            Assert.AreEqual(testVar, result);
        }
    }
}