using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppReferanceAndValueType
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int number1 = 10;
            int number2 = 20;
            number2 = number1;
            number1 = 50;

            Console.WriteLine(number2);

            Console.WriteLine("---------------------------------");

            string[] cities1 = { "Ankara", "Adana", "Afyon" };
            string[] cities2 = { "İzmir", "İstanbul", "İzmit" };

            cities2 = cities1;
            cities1[0] = "Sivas";
            Console.WriteLine(cities2[0]);
            Console.ReadLine();

        }
    }
}
