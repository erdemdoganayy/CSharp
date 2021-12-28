using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes2
{
    class Person
    {
        public string Name;
        public string Surname;
        public string Age;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Person Person = new Person();

            Person.Name = "Erdem";
            Person.Surname = "Doğanay";
            Person.Age = "23";

            Console.WriteLine("Name = {0} Surname = {1} Age = {2}" ,Person.Name,Person.Surname,Person.Age);
            Console.ReadLine();
        }
    }
}
