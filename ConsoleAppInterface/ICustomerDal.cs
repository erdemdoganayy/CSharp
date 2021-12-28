using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppInterface
{
    internal interface ICustomerDal
    {
        void Add();
        void Update();
        void Delete();
    }

    class SqlServerCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("I am a Sql Server Add");
        }

        public void Delete()
        {
            Console.WriteLine("I am a Sql Server Delete");
        }

        public void Update()
        {
            Console.WriteLine("I am a Sql Server Update");
        }
    }

    class OracleCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("I am a Oracle Server Add");
        }

        public void Delete()
        {
            Console.WriteLine("I am a Oracle Server Delete");
        }

        public void Update()
        {
            Console.WriteLine("I am a Oracle Server Update");
        }
    }

    class CustomerManager
    {
        public void Add(ICustomerDal customerDal)
        {
            customerDal.Add();
        }
    }
}
