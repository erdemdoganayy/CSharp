﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new Log4NetAdapter());
            productManager.Save();
            Console.ReadLine();
        }
    }

    class ProductManager
    {
        private ILogger _logger;
        public ProductManager(ILogger logger)
        {
            _logger = logger;
        }
        public void Save()
        {
            _logger.Log("User Data");
            Console.WriteLine("Saved");
        }
    }
    interface ILogger
    {
        void Log(string message);
    }

    class EdLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine("Logged with Erdem Doğanay, {0}",message);
        }
    }
    class Log4net
    {
        public void LogMessage(string message)
        {
            Console.WriteLine("Logged with Log4Net, {0}", message);
        }
    }

    class Log4NetAdapter : ILogger
    {
        public void Log(string message)
        {
            Log4net log4Net = new Log4net();
            log4Net.LogMessage(message);
        }
    }
}
