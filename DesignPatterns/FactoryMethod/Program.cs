﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Save();
            Console.Read();
        }

    }
    public class LoggerFactory : ILoggerFactory
    {
        public ILogger CreateLogger()
        {
            return new EdLogger();
        }
    }
    public interface ILoggerFactory
    {

    }
    public interface ILogger
    {
        void Log();
    }
    public class EdLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged with EdLogger");
            Console.ReadLine();
        }

    }
    public class CustomerManager
    {
        public void Save()
        {
            Console.WriteLine("Saved !");
            ILogger logger = new LoggerFactory().CreateLogger();
            logger.Log();
        }
    }
}
