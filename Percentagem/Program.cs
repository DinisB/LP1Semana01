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
            if (num1str.Length > 8 || num2str.Length > 8 || num3str.Length > 8 || num4str.Length > 8){
                Console.WriteLine("\t{0:P2}", num1);
                Console.WriteLine("\t{0:P2}", num2);
                Console.WriteLine("\t{0:P2}", num3);
                Console.WriteLine("\t{0:P2}", num4);
            }
            else {
                Console.WriteLine("O numero não pode ter mais de 7 casas");
            }
        }
    }
}
