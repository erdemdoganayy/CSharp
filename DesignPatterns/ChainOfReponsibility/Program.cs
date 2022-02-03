using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfReponsibility
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Manager manager = new Manager();
            VicePresident vicePresident = new VicePresident();
            President president = new President();

            manager.SetSuccessor(vicePresident);
            vicePresident.SetSuccessor(president);

            Expense expense = new Expense { Detail = "Course", Amount = 1020 };
            manager.HandleExpensive(expense);
            Console.ReadLine();
        }
    }

    class Expense
    {
        public string Detail { get; set; }
        public decimal Amount { get; set; }
    }

    abstract class ExpensiveHandlerBase
    {
        protected ExpensiveHandlerBase Successor;
        public abstract void HandleExpensive(Expense expense);
        public void SetSuccessor(ExpensiveHandlerBase successor)
        {
            Successor = successor; 
        }
    }

    class Manager : ExpensiveHandlerBase
    {
        public override void HandleExpensive(Expense expense)
        {
            if (expense.Amount <=100)
            {
                Console.WriteLine("Manager handled the Expensive");
            }
            else if (Successor != null)
            {
                Successor.HandleExpensive(expense);
            }
        }
    }

    class VicePresident : ExpensiveHandlerBase
    {
        public override void HandleExpensive(Expense expense)
        {
            if (expense.Amount > 100 && expense.Amount <= 1000)
            {
                Console.WriteLine("VicePresident handled the Expensive");
            }
            else if (Successor != null)
            {
                Successor.HandleExpensive(expense);
            }
        }
    }

    class President : ExpensiveHandlerBase
    {
        public override void HandleExpensive(Expense expense)
        {
            if (expense.Amount > 1000)
            {
                Console.WriteLine("President handled the Expensive");
            }
        }
    }
}
