﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Address_Book_System_All
{
    class AddressBook
    {
        public static List<PersonDetails> addressBook = new List<PersonDetails>();

        public static void AddContact()
        {
            Console.Write("How many contacts do you want to add ? : ");
            int contactsNum = Convert.ToInt32(Console.ReadLine());
            while (contactsNum > 0)
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

                addressBook.Add(person);
                Console.WriteLine("\n {0}'s contact succesfully added", person.Firstname);
                contactsNum--;
            }
        }
        public static void Display()
        {
            if (addressBook.Count > 0)
            {
                Console.Write("\n Enter the name of the person to get all the contact details : ");
                string nameKey = Console.ReadLine();
                foreach (PersonDetails contact in addressBook)
                {
                    if (nameKey.ToLower() == contact.Firstname.ToLower())
                    {
                        Console.WriteLine("\n First name-->{0}", contact.Firstname);
                        Console.WriteLine(" Last name-->{0}", contact.LastName);
                        Console.WriteLine(" Address-->{0}", contact.Address);
                        Console.WriteLine(" City-->{0}", contact.City);
                        Console.WriteLine(" State-->{0}", contact.State);
                        Console.WriteLine(" Zip code-->{0}", contact.ZipCode);
                        Console.WriteLine(" Phone number-->{0}", contact.PhoneNumber);
                        Console.WriteLine(" E-Mail ID-->{0}", contact.Email);
                        break;
                    }
                    else
                    {
                        Console.WriteLine(" Contact of the person {0} does not exist", nameKey);
                    }
                }
            }
            else
            {
                Console.WriteLine(" Your address book is empty");
            }
        }
    }
}
