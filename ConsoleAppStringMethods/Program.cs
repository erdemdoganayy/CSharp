using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppStringMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Sentence = "Hello My Name Is Erdem";

            var result0 = Sentence.Length;
            Console.WriteLine(result0);
            Console.WriteLine("↑↑↑↑↑↑↑↑↑ Karakter Sayısını Verir ↑↑↑↑↑↑↑↑↑");
            Console.WriteLine("");

            var result1 = Sentence.Clone();
            Console.WriteLine(result1);
            Console.WriteLine("↑↑↑↑↑↑↑↑↑ Cümleyi Klonlar ↑↑↑↑↑↑↑↑↑");
            Console.WriteLine("");

            bool result2 = Sentence.EndsWith("Erdem");
            Console.WriteLine(result2);
            Console.WriteLine("↑↑↑↑↑↑↑↑↑ Cümlenin Sonundaki Kelimeyi Doğrular ↑↑↑↑↑↑↑↑↑");
            Console.WriteLine("");

            bool result3 = Sentence.StartsWith("W");
            Console.WriteLine(result3);
            Console.WriteLine("↑↑↑↑↑↑↑↑↑ Cümlenin Başındaki Kelimeyi Doğrular ↑↑↑↑↑↑↑↑↑");
            Console.WriteLine("");

            var result4 = Sentence.IndexOf("My");
            Console.WriteLine(result4);
            Console.WriteLine("↑↑↑↑↑↑↑↑↑ Yazılan Değerin Kaçıncı Sırada Olduğunu Belirtir ↑↑↑↑↑↑↑↑↑");
            Console.WriteLine("");

            var result5 = Sentence.LastIndexOf("Erdem");
            Console.WriteLine(result5);
            Console.WriteLine("↑↑↑↑↑↑↑↑↑ Yazılan Değerin Sondan Kaçıncı Sırada Olduğunu Belirtir ↑↑↑↑↑↑↑↑↑");
            Console.WriteLine("");

            var result6 = Sentence.Insert(22," Doğanay");
            Console.WriteLine(result6);
            Console.WriteLine("↑↑↑↑↑↑↑↑↑ Belirtilen Boşluk Kadar Sonra Yazılan Değeri Ekler ↑↑↑↑↑↑↑↑↑");
            Console.WriteLine("");

            var result7 = Sentence.Substring(5 ,7);
            Console.WriteLine(result7);
            Console.WriteLine("↑↑↑↑↑↑↑↑↑ Belirtilen Boşluk Sayıları Arasını Verir ↑↑↑↑↑↑↑↑↑");
            Console.WriteLine("");

            var result8 = Sentence.ToLower();
            Console.WriteLine(result8);
            Console.WriteLine("↑↑↑↑↑↑↑↑↑ Tüm Harfleri Küçük Verir ↑↑↑↑↑↑↑↑↑");
            Console.WriteLine("");

            var result9 = Sentence.ToUpper();
            Console.WriteLine(result9);
            Console.WriteLine("↑↑↑↑↑↑↑↑↑ Tüm Harfleri Büyük Verir ↑↑↑↑↑↑↑↑↑");
            Console.WriteLine("");

            var result10 = Sentence.Replace(" ","-");
            Console.WriteLine(result10);
            Console.WriteLine("↑↑↑↑↑↑↑↑↑ Belirlenen Yeri Belirlenen Şekilde Değiştirir ↑↑↑↑↑↑↑↑↑");
            Console.WriteLine("");

            var result11 = Sentence.Remove(0,5);
            Console.WriteLine(result11);
            Console.WriteLine("↑↑↑↑↑↑↑↑↑ Belirlenen Yeri Belirlenen Şekilde Siler ↑↑↑↑↑↑↑↑↑");
            Console.Read();
        }
    }
}
