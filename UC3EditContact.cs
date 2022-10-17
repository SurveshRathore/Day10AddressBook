using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    internal class UC3EditContact
    {

        private string firstName;
        private string lastName;
        private string city;
        private string state;
        private int zip;
        private int phoneNumber;
        private string email;

        public UC3EditContact(string fName, string lName, string city, string state, int zip, int number, string mail)
        {
            this.firstName = fName;
            this.lastName = lName;
            this.city = city;
            this.state = state;
            this.zip = zip;
            this.phoneNumber = number;
            this.email = mail;
        }

        public void personDetails()
        {
            Console.WriteLine("Name: {0} {1} City: {2} State: {3} Zip: {4} Phone Number: {5} Email: {6}", firstName, lastName, city, state, zip, phoneNumber, email);
        }

        public string getFName()
        {
            return firstName;
        }
             
    }
}
