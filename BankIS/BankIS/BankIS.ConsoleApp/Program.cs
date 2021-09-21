using System;

namespace BankIS.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Client client1=new Client();

            client1.Name = "Jan Novak";
            client1.Age = 31;

            Client client2 = new Client();

            client2.Name = "Petr Skocdopole";
            client2.Age = 25;

            client1.Print();
            client2.Print();
        }

    }
}
