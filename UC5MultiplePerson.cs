using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    internal class UC5MultiplePerson
    {
        ArrayList firstName = new ArrayList();
        ArrayList lastName = new ArrayList();
        ArrayList city = new ArrayList();
        ArrayList state = new ArrayList();
        ArrayList zip = new ArrayList();
        ArrayList phoneNumber = new ArrayList();
        ArrayList email = new ArrayList();

        int personCount;

        public void addMultiplePerson()
        {
            
            Console.WriteLine("Enter the number of person: ");
            personCount = Convert.ToInt32(Console.ReadLine()); 

            for (int i = 0; i < personCount; i++)
            {
                Console.WriteLine("Enter the person {0} details:", i+1);
                Console.WriteLine("Enter the First Name: ");
                firstName.Add(Console.ReadLine());
                Console.WriteLine("Enter the last Name: ");
                lastName.Add(Console.ReadLine());
                Console.WriteLine("Enter the city: ");
                city.Add(Console.ReadLine());
                Console.WriteLine("Enter the state: ");
                state.Add(Console.ReadLine());
                Console.WriteLine("Enter the zip: ");
                zip.Add(Convert.ToInt32(Console.ReadLine()));
                Console.WriteLine("Enter the phone number: ");
                phoneNumber.Add(Convert.ToInt32(Console.ReadLine()));
                Console.WriteLine("Enter the email: ");
                email.Add(Console.ReadLine());
                
            }
        }

        public void printPersons()
        {
            for(int i = 0; i <personCount; i++)
            {
                Console.WriteLine("Person {0} details are:",i+1);
                Console.WriteLine("Name {0} {1}", firstName[i], lastName[i]);
                Console.WriteLine("City: " + city[i]);
                Console.WriteLine("State: " + state[i]);
                Console.WriteLine("Zip: " + zip[i]);
                Console.WriteLine("Phone Number: " + phoneNumber[i]);
                Console.WriteLine("Email: " + email[i]);
            }
        }
        /*
        UC5MultiplePerson(string fName, string lName, string city, string state, int zip, int number, string mail)
        {
            this.firstName.Add(fName);
            this.lastName.Add(lName);
            this.city.Add(city);
            this.state.Add(state);
            this.zip.Add(zip);
            this.phoneNumber.Add(number);
            this.email.Add(mail);
        }

        */
    }
}
