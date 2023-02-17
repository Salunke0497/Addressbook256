using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookNew
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AddressBook addressBook = new AddressBook();
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Choose One :\n1.Add contact\n2.Edit Contact\n3.Delet Contat");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1://UC1-UC2 Add New Person details 
                        addressBook.CreateContact();
                        Console.WriteLine("-----------------------------");
                        Console.WriteLine("-----------------------------");
                        addressBook.Display();
                        break;
                    case 2://UC3 Edit Contact
                        addressBook.CreateContact();
                        addressBook.EditContact();
                        Console.WriteLine("-----------------------------");
                        Console.WriteLine("-----------------------------");
                        addressBook.Display();
                        Console.ReadLine();
                        break;
                    case 3://UC4 Delete contact
                        //addressBook.CreateContact();
                        addressBook.DeleteContact();
                        Console.WriteLine("-----------------------------");
                        Console.WriteLine("-----------------------------");
                        addressBook.Display();
                        Console.ReadLine();
                        break;
                    case 4:
                        addressBook.Display();
                        break;

                    case 5:
                        flag = false;
                        break;
                }
            }
        }
    }
}
