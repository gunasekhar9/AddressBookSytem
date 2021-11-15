using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBookSystem
{
    public class ContactBook
    {
        List<ContactBook> addressList = new List<ContactBook>();
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public void AddContact()
        {
            ContactBook contact = new ContactBook();
            Console.Write("Enter First Name : ");
            contact.FirstName = Console.ReadLine();
            Console.Write("Enter Last Name : ");
            contact.LastName = Console.ReadLine();
            Console.Write("Enter Address : ");
            contact.Address = Console.ReadLine();
            Console.Write("Enter City : ");
            contact.City = Console.ReadLine();
            Console.Write("Enter State : ");
            contact.State = Console.ReadLine();
            Console.Write("Enter the Zip code : ");
            contact.Zip = Console.ReadLine();
            Console.Write("Enter Phone Number : ");
            contact.PhoneNumber = Console.ReadLine();
            Console.Write("Enter Email ID : ");
            contact.Email = Console.ReadLine();
            addressList.Add(contact);
        }
        public void Display()
        {
            foreach (var contactBook in addressList)
            {
                Console.WriteLine(contactBook.FirstName + " " + contactBook.LastName + "\n" + contactBook.PhoneNumber);
            }
        }
    }
}