﻿using System;

namespace BankIS.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //Address ostrava = new Address("Tovarni 13", "Ostrava");

            //ostrava.City = "Ostrava";
            //ostrava.Street = "Tovarni 13";

            Client client1=new Client("Machova 126","Machova");

            client1.Name = "Jan Novak";
            client1.Age = 31;

            Client client2 = new Client("Jan Gala", "Machova 126", "Myslocovice");
            //client1.HomeAddress = ostrava;
            //client1.HomeAddress.Street = "Sochorova 23";
            //client1.HomeAddress.City = "Brno";

            //Client client2 = new Client();

            //client2.Name = "Petr Skocdopole";
            //client2.Age = 25;
            //client2.HomeAddress = new Address("2.Ulice","Praha");
            //client2.HomeAddress.Street = "2. Ulice";
            //client2.HomeAddress.City = "Praha";

            

            client1.Print(client1.HomeAddress.Street,client1.HomeAddress.City);
            Console.WriteLine();
            client2.Print(client2.HomeAddress.Street, client2.HomeAddress.City);
        }

    }
}
