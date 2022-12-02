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

            // Arrange
            string roomNumber1 = "15";
            Payment payment1 = new Payment(101, "Cash");
            Room room1 = new Room(roomNumber1, "1", true);
            Guest guest1 = new Guest("Michael", "Granberry", "32", "6", room1, payment1);

            // Act
            var result1 = checkIn_Form.performCheckIn(guest1, roomNumber1);

            // Assert
            Assert.IsTrue(result1);
        }


        [TestMethod]
        public void performCheckIn_RoomIsOppucied_ReturnsFalse()
        {
            db.StartFirebase();
            CheckIn_Form checkIn_Form = new CheckIn_Form();

            // Arrange
            string roomNumber2 = "15";
            Payment payment2 = new Payment(140, "Cash");
            Room room2 = new Room(roomNumber2, "1", true);
            Guest guest2 = new Guest("Raymond", "B", "26", "3", room2, payment2);

            // Act
            var result2 = checkIn_Form.performCheckIn(guest2, roomNumber2);

            // Assert
            Assert.IsFalse(result2);
        }
    }
}