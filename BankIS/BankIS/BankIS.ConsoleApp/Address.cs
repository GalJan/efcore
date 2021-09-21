using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankIS.ConsoleApp
{
    public class Address
    {
        public Address(string street, string city) 
        {
            Street = street;
            City = city;
        }
        public string Street { get; set; }

        public string City {  get; set; }  
    }
}
