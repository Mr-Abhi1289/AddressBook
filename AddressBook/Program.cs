﻿using AddressBook;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public class Program
    {
        static void Main(string[] args)
        {
            addressbook book = new addressbook();
            book.CreateContact();
            while (true)
            {
                Console.WriteLine("1.Create Contact\n2.DisplayContact\n3.EditContact");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        book.CreateContact();
                        break;
                    case 2:
                        book.DisplayContact();
                        break;
                    case 3:
                        book.EditContact();
                        break;

                }

            }
        }
    }
}