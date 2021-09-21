using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankIS.ConsoleApp
{
    public class Client
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public Address HomeAddress {  get; set; }   

        public void Print(string street, string city)
        {
              
            Console.WriteLine(Name);
            Console.WriteLine("{0},{1}",street,city);
            //Console.WriteLine(HomeAddress.City);
        }
    }
}
