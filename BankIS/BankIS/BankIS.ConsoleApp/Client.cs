using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


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
        public Client(string name, string street, string city, int age)
        {
            HomeAddress = new Address();
            Name = name;
            HomeAddress.Street = street;
            HomeAddress.City = city;
            Age = age;
        }
        public string Name { get; set; }

        //public int Age { get; set; }
        private int _age;
        private bool _isOverAge = false;

        public int Age
        {
            get
            {
                if (_isOverAge)
                    return _age;
                else
                    return -2;
            }

            set
            {
                if (value >= 18)
                    _isOverAge = true;
                else
                    _isOverAge = false;

                _age = value;
            }
        }

        public int ID { get; set; }
        public Address HomeAddress { get; set; }

        public void Print()
        {

            Console.WriteLine(Name + ", "+ Age);
           


            if (HomeAddress != null && !string.IsNullOrEmpty(HomeAddress.Street))
            {
                HomeAddress.Print(HomeAddress.Street,HomeAddress.City);
            }
            else
            {
                Console.WriteLine("Adresa nezadana!\n");
            }
            //Console.WriteLine(HomeAddress.City);

        }

        //internal void Print()
        //{
        //    throw new NotImplementedException();
        //}

        public void SaveToFile(string filePath)
        {
            File.WriteAllText(filePath, ToString());
        }

        public override string ToString()
        {
            if (HomeAddress != null && !string.IsNullOrEmpty(HomeAddress.Street))
            {
                return $"{Name};{Age};{HomeAddress.Street};{HomeAddress.City}";
            }
            else
            {
                return $"{Name};{Age}";
            }


        }
            public static void ListToFile(IEnumerable<Client> clients, string filepath)
        {
            foreach (var client in clients)
            {
                var newLine = Environment.NewLine;
                var clientWithNewLine = client.ToString() + newLine;
                File.AppendAllText(filepath, clientWithNewLine);

            }
        }

        public static  List<Client> LoadClients(string filepath)
        {
            List<Client> result = new List<Client>();

            var lines = File.ReadAllLines(filepath);

            foreach(var line in lines)
            {
                var items = line.Split(';');
                var name = items[0];
                var age = int.Parse(items[1]);
                var street = items[2];
                var city = items[3];

                Client c = new Client(name, street, city, age);

                result.Add(c);
            }

            return result;
        }
    }
}
