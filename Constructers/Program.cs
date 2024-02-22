using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructers
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer() { Id=1, FirsName="Hll",LastName="Atc",City="Eskişehir"};

            Customer customer2 = new Customer(2,"Esra","Akın","Konya");

            Customer customer3 = new Customer();
            customer3.Id = 3;

            Console.ReadLine(); 
        }
    }
    class Customer
    {
        public Customer()
        {
            Console.WriteLine("Yapıcı blok çalıştı..");
        }
        public Customer(int id, string firstname, string lastname, string city)
        {
            Id=id;
            FirsName=firstname;
            LastName=lastname;
            City=city;
        }
        public int Id { get; set; }
        public string FirsName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
    }
}
