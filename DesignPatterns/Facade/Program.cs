using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Save();
            Console.ReadLine();
        }
    }

    class Logging : ILogging
    {
        public void Log()
        {
            Console.WriteLine("Logged !");
        }

    }

    internal interface ILogging
    {
        void Log();
    }

    class Caching : ICaching
    {
        public void Cache()
        {
            Console.WriteLine("Cached !");
        }
    }

    internal interface ICaching
    {
        void Cache();
    }

    class Authorize : IAuthorize
    {
        public void ChecUser()
        {
            Console.WriteLine("User Checked !");
        }
    }

    internal interface IAuthorize
    {
        void ChecUser();
    }

    class CustomerManager
    {
        private CrossCuttongConcernsFacede _concerns;
        public CustomerManager()
        {
            _concerns = new CrossCuttongConcernsFacede();
        }

        public void Save()
        {
            _concerns.Logging.Log();
            _concerns.Caching.Cache();
            _concerns.Authorize.ChecUser();
            Console.WriteLine("Saved");
           
        }
    }

    class CrossCuttongConcernsFacede
    {
        public ILogging Logging;
        public ICaching Caching;
        public IAuthorize Authorize;

        public CrossCuttongConcernsFacede()
        {
            Logging = new Logging();
            Caching = new Caching();
            Authorize = new Authorize();
        }
    }
}
