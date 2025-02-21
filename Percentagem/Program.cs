using System;
using System.Globalization;

namespace Percentagem
{
    public class Program
    {
        private static void Main(string[] args)
        {
            CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;
            string num1str;
            string num2str;
            string num3str;
            string num4str;
            decimal num1;
            decimal num2;
            decimal num3;
            decimal num4;
            Console.WriteLine("Insere 4 números reais entre 0 a 1:");
            num1str = Console.ReadLine();
            num2str = Console.ReadLine();
            num3str = Console.ReadLine();
            num4str = Console.ReadLine();
            num1 = Convert.ToDecimal(num1str);
            num2 = Convert.ToDecimal(num2str);
            num3 = Convert.ToDecimal(num3str);
            num4 = Convert.ToDecimal(num4str);
            if (num1 > 0 && num1 < 1 || num2 > 0 && num2 < 1 || num3 > 0 && num3 < 1 || num4 > 0 && num4 < 1) {
                Console.WriteLine("\t{0:P1}", num1);
                Console.WriteLine("\t{0:P1}", num2);
                Console.WriteLine("\t{0:P1}", num3);
                Console.WriteLine("\t{0:P1}", num4);
            }
            else {
                Console.WriteLine("O número tem de ser entre 0 e 1!");
            }
        }
    }
}
