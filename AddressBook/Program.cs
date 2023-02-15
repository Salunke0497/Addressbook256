using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AddressBook addressBook = new AddressBook();
            addressBook.CreateContact();
            Console.WriteLine("-----------------------------");
            Console.WriteLine("-----------------------------");
            addressBook.Display();
            Console.ReadLine();
        }
    }
}
