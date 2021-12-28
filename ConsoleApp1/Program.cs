using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NameAdd("Erdem", "Doğanay");
            Console.WriteLine("--------------NameAdd Finish-------------------");

            Calculotor(2, 4);
            Console.WriteLine("--------------Calculator Finish-------------------");

            var number1 = 20;
            var number2 = 100;
            var result = Challange(number1, number2);
            Console.WriteLine(result);
            Console.WriteLine(number1);
            Console.WriteLine("--------------Challange Finish-------------------");

            Console.WriteLine(Multiply(2, 4, 8));
            //Aynı isimde 2 method olabilir ve ekstra paramatre alabilir. !
            Console.WriteLine(Multiplys(2, 4, 8, 14, 22));
            // MethodAdi(params int[] numbers ) Birden fazla paramatre alabilir. !
            Console.ReadLine();
        }
        static void NameAdd(string name, string surname)
        {
            Console.WriteLine(name + " " + surname);
        }
        
        static void Calculotor(int number1, int number2)
        {
            Console.WriteLine(number1 + number2);
        }

        static int Challange(int number1, int number2)
        {
            number1 = 30;
            return number1 + number2;
        }

        static int Multiply(int number1, int number2)
        {
            return number1 * number2;
        }
        static int Multiply(int number1, int number2, int number3)
        {
            return number1 * number2 * number3;
        }

        static int Multiplys(params int[] numbers)
        {
            return numbers.Sum();
        }
    }
}
