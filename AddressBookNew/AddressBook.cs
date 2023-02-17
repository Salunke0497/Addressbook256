using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AddressBookNew
{
    public class AddressBook
    {
        Contact contact = new Contact();
        List<Contact> contactList = new List<Contact>();
        public void CreateContact()
        {
            Contact contact = new Contact();
            Console.WriteLine("Enter FirstName here");
            contact.FirstName = Console.ReadLine();
            Console.WriteLine("Enter LastName here");
            contact.LastName = Console.ReadLine();
            Console.WriteLine("Enter Email here");
            contact.Email = Console.ReadLine();
            Console.WriteLine("Enter PhoneNumber here");
            contact.PhoneNumber = Console.ReadLine();
            Console.WriteLine("Enter city here");
            contact.City = Console.ReadLine();
            Console.WriteLine("Enter Address here");
            contact.Address = Console.ReadLine();
            Console.WriteLine("Enter ZipCode here");
            contact.ZipCode = Console.ReadLine();
            Console.WriteLine("Enter Country here");
            contact.Country = Console.ReadLine();
            Console.WriteLine("Enter State here");
            contact.State = Console.ReadLine();

            contactList.Add(contact);
        }
        public void Display()
        {
            foreach (var contact in contactList)
            {
                Console.WriteLine("contact Details" + "\n" + "FirstNmae : " + contact.FirstName + "\n" + "LastName : " + contact.LastName + "\n" + "Email : " + contact.Email + "\n" + "PhoneNumber : " + contact.PhoneNumber + "\n" + "City : " + contact.City + "\n" + "Address : " + contact.Address + "\n" + "ZipCode : " + contact.ZipCode + "\n" + "Country : " + contact.Country + "\n" + "State : " + contact.State + "\n");
            }
        }
        public void EditContact()
        {
            Console.WriteLine("Enter FirstNmae Here");
            string name = Console.ReadLine();
            foreach (var contact in contactList)
            {
                if (contact.FirstName.Equals(name))
                {
                    Console.WriteLine("select what you want to edit \n1.Address\n2.email\n3.Phone Number\n4.state\n5.state\n6.city\n7.country\n8.zipcode\n9.exit");
                    int option = Convert.ToInt32(Console.ReadLine());
                    switch (option)
                    {
                        case 1:
                            Console.WriteLine("Enter New Address Here");
                            contact.Address = Console.ReadLine();
                            break;
                        case 2:
                            Console.WriteLine("Enter New email Here");
                            contact.Email = Console.ReadLine();
                            break;
                        case 3:
                            Console.WriteLine("Enter New Phone Number Here");
                            contact.PhoneNumber = Console.ReadLine();
                            break;
                        case 4:
                            Console.WriteLine("Enter New state Here");
                            contact.State = Console.ReadLine();
                            break;
                        case 5:
                            Console.WriteLine("Enter New city Here");
                            contact.City = Console.ReadLine();
                            break;
                        case 6:
                            Console.WriteLine("Enter New country Here");
                            contact.Country = Console.ReadLine();
                            break;
                        case 7:
                            Console.WriteLine("Enter New region Here");
                            contact.Region = Console.ReadLine();
                            break;
                        case 8:
                            Console.WriteLine("Enter New zipcode Here");
                            contact.ZipCode = Console.ReadLine();
                            break;
                        case 9:
                            Console.WriteLine("Exit");
                            break;

                    }
                }
                else
                {
                    Console.WriteLine("Contact Not Found");
                }
            }
        }
        public void DeleteContact()
        {
            Contact DeletContact = new Contact();
            Console.WriteLine("Enter FirstNmae Here");
            string name = Console.ReadLine();
            foreach (var contact in contactList.ToList())
            {
                if (contact.FirstName.Equals(name))
                {
                    DeletContact = contact;
                }
                contactList.Remove(DeletContact);
                Console.WriteLine("contact has been deleted successfully");
            }
        }
    }
}
