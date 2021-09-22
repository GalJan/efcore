using System;
using System.Collections.Generic;
using System.Linq;

namespace BankIS.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            //Address ostrava = new Address("Tovarni 13", "Ostrava");

            //ostrava.City = "Ostrava";
            //ostrava.Street = "Tovarni 13";

            //Client client1=new Client("Machova 77","Machova");

            //client1.Name = "Jan Novak";
            //client1.Age = 31;

            var filepath = "dataset_1.txt";
            Console.WriteLine($"Nacitam z: {filepath}!");

            //var client1 = new Client("Pepa Koutny", "Machova 126", "Myslocovice",46);
            //var client2 = new Client("Jan Novak", "Myslocovice 26", "Myslocovice", 26);
            //var client3 = new Client("Veronika Dlouha", "Sevcova 55", "Zlin", 36);
            //var client4 = new Client("Magda Novakova", "Maleninskeho 6", "Malenovice", 44);
            //var client5 = new Client("Jiri Dvorak", "Hlavni 23", "Brno", 37);

            var clients = Client.LoadClients(filepath);

            //clients.Add(client1); 
            //clients.Add(client2);
            //clients.Add(client3);
            //clients.Add(client4);
            //clients.Add(client5);

            var cnt = clients.Count;

            Console.WriteLine("Pocet klientu v seznamu: {0}\n",cnt);

            //foreach(var client in clients)
            //{
            //    Console.WriteLine($"Klient: {client}");
            //}

            //var result = clients.OrderBy(c => c.Age);

            //var result = clients.Where(c => c.Age >= 37).OrderBy(c => c.Age).ToList();
            var result = clients
                .Where(c => c.HomeAddress.City == "Brno").ToList();
            
            var brno = result.Count;
            // OR -> || , AND -> &&

            //.Where(c => c.HomeAddress.City == "Brno")
            //.OrderBy(c => c.Name)
            //.Max(c => c.Age);
            //.ToList();

            //var over30 = clients.Where(client => client.Age > 36).ToList();

            //Console.WriteLine($"\n Clients from Brno: \n");
            Console.WriteLine($"Lide z Brna: {brno}");
            //foreach (var client in result)
            //{
            //    Console.WriteLine(client);
            //}


            //Client.ListToFile(clients, "ListOfClients.txt");

            //var ListOfClients = Client.LoadClients("ListOfClients.txt");


            //Console.WriteLine(cnt);


            //client1.HomeAddress = ostrava;
            //client1.HomeAddress.Street = "Sochorova 23";
            //client1.HomeAddress.City = "Brno";

            //Client client2 = new Client();

            //client2.Name = "Petr Skocdopole";
            //client2.Age = 25;
            //client2.HomeAddress = new Address("2.Ulice","Praha");
            //client2.HomeAddress.Street = "2. Ulice";
            //client2.HomeAddress.City = "Praha";

            //Console.WriteLine("Client1: " + client1.ToString() + "\n");

            //client1.Print(client1.HomeAddress.Street,client1.HomeAddress.City);

            //client2.Print(client2.HomeAddress.Street, client2.HomeAddress.City);

            //client1.SaveToFile("Client1.txt");
            //client2.SaveToFile("Client2.txt");

            //Console.WriteLine("Hello World!");

            //var c1 = new Client(city: "Brno", street: "Kopečná 23", jmeno: "Martin Novák", age: 55);
            //var c2 = new Client("Tovární 13", "Ostrava", "Martina Veselá", 33);

            //// připravte metodu "SaveToFile(string filePath) na klientovi

            //Console.WriteLine("c1: " + c1.ToString());

            //c1.Print();

            //Console.WriteLine();
            //var num = int.Parse("32");

            //var spojene = string.Join(", ", "Slovo1", "Slovo2", "tři", "atd..");
            //Console.WriteLine(spojene);

            //c2.Print();

            //c1.SaveToFile("klient1.txt");
            //c2.SaveToFile("klient2.txt");

            //bool allowed = Address.IsCityAllowed("xxx");

            //double cos = Math.Cos(3.2);

            //using (HttpClient webClient = new HttpClient())
            //{
            //    var response = webClient.GetAsync("https://API.projekt.cz").Result;
            //    if (response.StatusCode == System.Net.HttpStatusCode.OK)
            //    {
            //        //response OK HTTP 200
            //    }
            //}

            //string[] pole_stringu = new string[23];

            //List<string> list = new List<string>();

            //pole_stringu[5] = "sesty prvek";

            //list.Add("prvni item");

            //List<Client> clients = new List<Client>();

            //clients.Add(c1);
            //clients.Add(c2);

            //foreach (var client in clients)
            //{
            //    client.Age = 22;
            //    client.Print();
            //}
        }

    }
}
