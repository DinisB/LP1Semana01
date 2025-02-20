using System;
using System.Text;

namespace ManyStrings
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8; 
            string str1 = "\tBom dia";
            string nome = "\nJubileu";
            char cruz = '\u2020';
            Console.WriteLine(str1);
            Console.WriteLine(nome + " morreu " + cruz);
        }
    }
}
