using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppStaticClass
{
    static class HelperMethods
    {
        public static string CharacterChange(string str)
        {
            return str.Replace("ü", "u")
                .Replace("ş", "s")
                .Replace("ı", "i")
                .Replace("ö", "o")
                .Replace("ç", "c")
                .Replace("ğ", "g");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "ölçme ve değerlendirme karışıklığı üzdü bizi";
            string str2 = HelperMethods.CharacterChange(str);

            Console.WriteLine(str2);
            Console.Read();
        }
    }
}
