using System;
using System.Security.Cryptography;
using System.Text;

namespace ManyStrings
{
    public class Program
    {
        private static void Main(string[] args)
        {
            double xx = 1.23456;
            int ii = 19;
            Console.OutputEncoding = Encoding.UTF8; 
            string str1 = "\tBom dia";
            string nome = "\nJubileu";
            string str2 = str1 + " " + nome;
            char cruz = '\u2020';
            string astr = "a";
            string numa = astr + 5;
            int x = 4;
            int y = 9;
            string xato = astr + x;
            string soma = $"{x} mais {y} é igual a {x+y}";
            string valor = $"valor de x é {x}";
            Console.WriteLine(str2 += "!");
            Console.WriteLine(nome + " morreu " + cruz);
            Console.WriteLine(numa);
            Console.WriteLine(xato);
            Console.WriteLine(valor);
            Console.WriteLine(soma);
            Console.WriteLine("{0:F2}", xx);
            Console.WriteLine("{0:P1}", xx);
            Console.WriteLine("{0:X}", ii);
            Console.WriteLine("{0:C}", ii);
        }
    }
}
