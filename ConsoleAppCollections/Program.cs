using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppCollections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<String, String> dictionary = new Dictionary<String, String>();
            dictionary.Add("Pencil", "Kalem");
            dictionary.Add("Brush", "Fırça");
            dictionary.Add("Screen", "Ekran");

            foreach (var key in dictionary)
            {
                Console.WriteLine(key.Value);
            }

            Console.WriteLine(dictionary.ContainsKey("glass"));
            Console.WriteLine(dictionary.ContainsKey("Brush"));

            //ArrayList();
            //List();
            Console.ReadLine();
        }

        public static void ArrayList()
        {
            ArrayList cities = new ArrayList();

            cities.Add("Ankara");
            cities.Add("Sivas");

            foreach (string city in cities)
            {
                Console.WriteLine(city);
            }

        }
        public static void List()
        {
            List<String> lists = new List<String>();
            lists.Add("Erdem");
            lists.Add("Doğanay");
            foreach (String list in lists)
            {

                Console.WriteLine(list);
            }

            List<Customer> customers = new List<Customer>();
            customers.Add(new Customer { Id = 58, Age = 23, Weight = 71 });

            foreach (Customer customer in customers)
            {
                Console.WriteLine("ID : {0} Yaş : {1} Boy : {2}", customer.Id, customer.Age, customer.Weight);
            }

            // 2. Yazma biçimi.
            List<Customer> customers1 = new List<Customer>
            {
             new Customer { Id = 06},
             new Customer { Age = 23},
             new Customer { Weight = 71}
             };
        }

        class Customer
        {
            public int Id { get; set; }
            public int Age { get; set; }
            public int Weight { get; set; }
        }
    }
}
