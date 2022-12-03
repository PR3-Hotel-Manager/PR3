# PR3 Hotel Management System <br />

Software Engineers: Michael Granberry, Raymond Babayans, Ralph Frem, Ziv Gabay <br />


Our project will allow the front desk employee to perform necessary operations such as check-in/check-out of a guest, view a report of available/occupied rooms, and look up the name of a particular guest along with their room number. In terms of limitations, the hotel’s capacity is only 40 rooms, and it accepts guests who are 18 years or older. All the required information will be stored in a local or potentially online database. <br />

## Main Form <br />

![](images/mainForm.png) <br />

## Check-In Form <br />

The guest check in page should allow for the end user to input guest information to check in the guest efficiently. This page should include the guest first name, last name, email address, phone number, number of beds, room #, length of stay, price, accommodations, and payment method to be entered. This section should also allow for a unique confirmation code that can be linked with their hotel key card. <br />

![](images/checkInForm.png) <br />

* Confirmation Number <br />
![](images/CheckInConfirmation.png) <br />

* Guest Inserted Into Firebase Realtime Database <br />
![](images/firebaseCheckIn.png) <br />

### Capacity Form <br />

The Room Capacity page will allow the front desk staff to see the number of rooms available, as well as which rooms are occupied and which ones are available. <br />

![](images/roomCapForm.png) <br />

## Look-Up Form <br />

The guest look up page will allow the front desk staff to search the guest list based on name/last name. <br />

![](images/lookUpForm2.png) <br />

## ReportForm <br />

The guest activity/report page will show a log of guests that have checked in and out, along with the time, their room#, payment method, etc. This graphical user interface should be clear and clean to the end user allowing for a seamless experience. Look up feature for the report will also be implemented. <br />
* Guest Log <br />
![](images/reportForm.png) <br />
* Search Log File <br />
![](images/reportForm2.png) <br />

## Room Estimation Form
The guest estimation page will allow the front desk staff to provide an estimated price to the guest depending on the numbers of stays and bed numbers. <br />
![](images/estimateForm2.png) <br />

## Check-Out Form

The guest check-out page will allow the front desk staff to perform checking out of a guest. On this page after selecting a room number, the guest is checked out. <br />
* Only Shows Occupied Rooms to be Checked-Out <br />
![](images/checkOutList.png) <br />
* Check-Out Confirmation <br />
![](images/checkOutConfirmation.png) <br />

