using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankIS.ConsoleApp
{
    public class Client
    {

        public Client()
        {
            HomeAddress = new Address();

        }
        public Client(string street, string city)
        {
            HomeAddress = new Address();
            HomeAddress.Street = street;
            HomeAddress.City = city;    
        }
        public Client(string name, string street, string city)
        {
            HomeAddress = new Address();   
            Name = name;
            HomeAddress.Street = street;   
            HomeAddress.City = city;    
        }
        public string Name { get; set; }

        public int Age { get; set; }

        public Address HomeAddress {  get; set; }

        public void Print(string street, string city)
        {

            Console.WriteLine(Name);
            
            if (HomeAddress != null && !string.IsNullOrEmpty(HomeAddress.Street))
            {
                Console.WriteLine("{0}, {1}", street, city);
            }
            else
            {
                Console.WriteLine("Adresa nezadana!");
            }
            //Console.WriteLine(HomeAddress.City);
        }
    }
}
