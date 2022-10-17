// See https://aka.ms/new-console-template for more information
using AddressBookSystem;

Console.WriteLine("Welcome to Address Book Program");

/*

UC1AddressBook contact = new UC1AddressBook();

Console.WriteLine("Enter the person First Name: ");
String fName = Console.ReadLine();
Console.WriteLine("Enter the person last Name: ");
String lName = Console.ReadLine();
Console.WriteLine("Enter the person city: ");
String city = Console.ReadLine();
Console.WriteLine("Enter the person state: ");
String state = Console.ReadLine();
Console.WriteLine("Enter the person zip: ");
int zip = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the person phone number: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the person email: ");
String email = Console.ReadLine();

UC2AddContact addContact = new(fName, lName, city, state, zip, number, email);
addContact.personDetails();

/*************************************UC3******************************************/ /*
UC3EditContact editContact = new(fName, lName, city, state, zip, number, email);
editContact.personDetails();
   
Console.WriteLine("Enter the person first name to edit ");
fName = Console.ReadLine();

if(fName == editContact.getFName())
{
    Console.WriteLine("Enter the person last Name: ");
    lName = Console.ReadLine();
    Console.WriteLine("Enter the person city: ");
    city = Console.ReadLine();
    Console.WriteLine("Enter the person state: ");
    state = Console.ReadLine();
    Console.WriteLine("Enter the person zip: ");
    zip = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter the person phone number: ");
    number = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter the person email: ");
    email = Console.ReadLine();
    editContact = new(fName, lName, city, state, zip, number, email);
    editContact.personDetails();
}
else
{
    Console.WriteLine("No person found.");
}

/*************************************UC4******************************************/ /*
UC4DeleteContact delContact = new(fName, lName, city, state, zip, number, email);
delContact.personDetails();

Console.WriteLine("Enter the person first name to edit ");
fName = Console.ReadLine();

if (fName == delContact.getFName())
{
    delContact.deletePersonDetails();
    delContact.personDetails();
}
else
{
    Console.WriteLine("No person found.");
}

/*************************************UC5******************************************/
UC5MultiplePerson multiple = new();
multiple.addMultiplePerson();
multiple.printPersons();