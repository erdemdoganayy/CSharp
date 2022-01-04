using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDelegates
{
    internal class Program
    {
        //Delegates bir nevi method taşımaya yardımcı olur.
        public delegate void MyDelegate();
        static void Main(string[] args)
        {
            CustomManager customManager = new CustomManager();
            MyDelegate myDelegate = customManager.SendMessage;
            myDelegate += customManager.Alert;
            myDelegate();
            Console.Read();
        }
    }
    public class CustomManager
    {
        public void SendMessage()
        {
            Console.WriteLine("This is a Message !");
        }
        public void Alert()
        {
            Console.WriteLine("This is a Alert !");
        }
    }
}
