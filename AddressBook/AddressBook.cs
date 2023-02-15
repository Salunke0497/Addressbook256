using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public class AddressBook
    {
        Contact contact = new Contact();
        public void CreateContact()
        {
            Console.WriteLine("Enter FirstName here");
            contact.FirstName= Console.ReadLine();
            Console.WriteLine("Enter LastName here");
            contact.LastName= Console.ReadLine();
            Console.WriteLine("Enter Email here");
            contact.Email= Console.ReadLine();
            Console.WriteLine("Enter PhoneNumber here");
            contact.PhoneNumber= Console.ReadLine();
            Console.WriteLine("Enter city here");
            contact.City= Console.ReadLine();
            Console.WriteLine("Enter Address here");
            contact.Address= Console.ReadLine();
            Console.WriteLine("Enter ZipCode here");
            contact.ZipCode= Console.ReadLine();
            Console.WriteLine("Enter Country here");
            contact.Country= Console.ReadLine();
            Console.WriteLine("Enter State here");
            contact.State= Console.ReadLine();            
        }
        public void Display()
        {
            Console.WriteLine("contact Details"+"\n"+"FirstNmae : "+contact.FirstName+"\n"+"LastName : "+contact.LastName+"\n"+"Email : "+contact.Email+"\n"+"PhoneNumber : "+contact.PhoneNumber+"\n"+"City : "+contact.City+"\n"+"Address : "+contact.Address+"\n"+"ZipCode : "+contact.ZipCode+"\n"+"Country : "+contact.Country+"\n"+"State : "+contact.State+"\n");
        }
    }
}
