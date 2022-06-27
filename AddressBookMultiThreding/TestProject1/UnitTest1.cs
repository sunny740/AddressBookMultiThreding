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
            AddresDetails.Add(new Contact(Firstname: "Rajesh", Lastname: "Verma", Address: "Bemetara", City: "Durg", State: "Chhattisgarh", Zip: 490020, Phone: "7898625487", Email: "sahu@12gmail.com"));

            AddingOperations emppayroll = new AddingOperations();
            DateTime StartDateTime = DateTime.Now;
            emppayroll.AddEmployee(AddresDetails);
            DateTime StopDateTimes = DateTime.Now;

            Console.WriteLine("Duration without threads: " + (StopDateTimes - StartDateTime));
        }
    }
}