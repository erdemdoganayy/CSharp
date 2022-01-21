using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer
            {
                FirstName = "Erdem",
                LastName = "Doğanay",
                City = " Ankara",
                Id = 1
            };

            Console.WriteLine(customer.FirstName);
            Customer customer2 =  (Customer)customer.Clone();
            customer2.FirstName = "Derya";

            Console.WriteLine(customer.FirstName);
            Console.WriteLine(customer2.FirstName);

            Console.ReadLine();

        }
    }


    public abstract class Person
    {
        public abstract Person Clone();
        public int Id{ get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }

    public class Customer : Person
    {
        public string City { get; set; }

        public override Person Clone()
        {
           return (Person)MemberwiseClone();
        }
    }

    public class Employee : Person
    {
        public decimal Salary  { get; set; }

        public override Person Clone()
        {
            return (Person)MemberwiseClone();
        }
    }
}
