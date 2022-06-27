using AddressBook;
using AddressBookMultiThreding;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;

namespace ContactDetailsTest
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            List<Contact> AddresDetails = new List<Contact>();
            AddresDetails.Add(new Contact(Firstname: "Sun", Lastname: "Sharma", Address: "AtalColony", City: "Gwa", State: "MP", Zip: 250020, Phone: "758925487", Email: "sun@12gmail.com"));

            AddingOperations emppayroll = new AddingOperations();
            DateTime StartDateTime = DateTime.Now;
            emppayroll.AddEmployee(AddresDetails);
            DateTime StopDateTimes = DateTime.Now;

            Console.WriteLine("Duration without threads: " + (StopDateTimes - StartDateTime));
        }
    }
}