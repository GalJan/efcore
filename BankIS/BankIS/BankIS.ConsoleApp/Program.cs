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

            client1.Print();
        }
    }
}
