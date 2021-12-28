using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppInterface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // InterfaceIntro();  interface ile verilere ulaşma
            // InterfaceSqlSettings(); Interface İçerisine Veri Ekleme, güncelleme, silme

            ICustomerDal[] customerDals = new ICustomerDal[2]
            {
                new SqlServerCustomerDal(),
                new OracleCustomerDal(),

            };
            foreach (var customerDal in customerDals)
            {
                customerDal.Add();
            }

            Console.ReadLine();

        }

        public static void InterfaceSqlSettings()
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(new OracleCustomerDal());
        }

        public static void InterfaceIntro()
        {
            PersonManager manager = new PersonManager();
            Students student = new Students
            {
                Id = 1,
                FirstName = "Erdem",
                SurName = "Doğanay",
                School = "Ankara University",
            };
            manager.Add(student);
        }
    }

    public interface IPerson
    {
        int Id { get; set; }
        string FirstName { get; set; }
        string SurName { get; set; }
        string Birthday { get; set; }

        bool Run();
    }

    public class Students : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string SurName { get; set; }
        public string School { get; set; }
        public bool Run()
        {
            return true;
        }
    }
    class Worker : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string SurName { get; set; }
        public string Address { get; set; }
    }

    class PersonManager
    {
        public void Add(IPerson person)
        {
            Console.WriteLine(person.FirstName);
            Console.WriteLine(person.SurName);
            Console.Read();
        }
    }
}
