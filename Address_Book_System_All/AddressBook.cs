using System;
using System.Collections.Generic;
using System.Text;

namespace Address_Book_System_All
{
    class AddressBook
    {
        private static List<PersonDetails> contacts = new List<PersonDetails>();

        private static Dictionary<string, List<PersonDetails>> addressBook = new Dictionary<string, List<PersonDetails>>();

        public static void AddTo(string name)
        {
            addressBook.Add(name, contacts);
        }
        public static void AddContact()
        {
            PersonDetails person = new PersonDetails();

            Console.Write(" Enter your First name : ");
            person.Firstname = Console.ReadLine();
            Console.Write(" Enter your Last name : ");
            person.LastName = Console.ReadLine();
            Console.Write(" Enter your Address : ");
            person.Address = Console.ReadLine();
            Console.Write(" Enter your City : ");
            person.City = Console.ReadLine();
            Console.Write(" Enter your State : ");
            person.State = Console.ReadLine();
            Console.Write(" Enter your Zip Code : ");
            person.ZipCode = Console.ReadLine();
            Console.Write(" Enter your Phone Number : ");
            person.PhoneNumber = Console.ReadLine();
            Console.Write(" Enter your Email-ID : ");
            person.Email = Console.ReadLine();

            contacts.Add(person);
            Console.WriteLine("\n {0}'s contact succesfully added", person.Firstname);
        }

        public static void Details()
        {
            if (contacts.Count == 0)
            {
                Console.WriteLine("Currently there are no people added in your address book.");
            }
            else
            {
                Console.WriteLine("Here is the list and details of all the contacts in your addressbook.");

                foreach (var Detailing in contacts)
                {
                    Console.WriteLine("First name : " + Detailing.Firstname);
                    Console.WriteLine("Last name : " + Detailing.LastName);
                    Console.WriteLine("Address : " + Detailing.Address);
                    Console.WriteLine("State : " + Detailing.State);
                    Console.WriteLine("City : " + Detailing.City);
                    Console.WriteLine("Zip Code : " + Detailing.ZipCode);
                    Console.WriteLine("Phone number = " + Detailing.PhoneNumber);
                }
            }
        }

        public static void SearchCity()
        {
            Console.WriteLine("Please Enter Name of city");
            string city = Console.ReadLine();
            foreach (var Details in contacts)
            {
                var person = contacts.Find(p => p.City.Equals(city));
                if (person != null)
                {
                    Console.WriteLine("{0} person in the {1}", Details.Firstname, city);
                }
                else
                {

                }
            }

        }

        //This method for search person using state name
        public static void SearchState()
        {
            Console.WriteLine("Please Enter Name of State");
            string state = Console.ReadLine();
            foreach (var Details in contacts)
            {
                var person = contacts.FindAll(p => p.State.Equals(state));
                if (person != null)
                {
                    Console.WriteLine("{0} person in the {1}", Details.Firstname, state);
                }
                else
                {

                }
            }

        }
    }
}
