using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1.Array tanımlama şekli
            string[] fruits = { "Apple", "Banana", "Strawberry" };
            //2. Array tanımlama şekli
            string[] vegetables = new string[3];
            vegetables[0] = "Cucumber";
            vegetables[1] = "Tomato";
            vegetables[2] = "Pepper";

            //foreach (var vegetable in vegetables)
            //{
            //    Console.WriteLine(vegetable);
            //}

            //3. Çoklu Array tanımalama şekli
            string[,] names = new string[7, 2]
            {
                {"Erdem","Doğanay"},
                {"--------","--------"},
                {"Songül","Doğanay"},
                {"--------","--------"},
                {"Muharrem","Doğanay"},
                {"--------","--------"},
                {"Ali Haydar","Doğanay"},
            };
            for (int i = 0; i <= names.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= names.GetUpperBound(1); j++)
                {
                    Console.WriteLine(names[i,j]);
                }
            }

            Console.ReadLine();
        }
    }
}
