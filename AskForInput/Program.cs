using System;

namespace AskForInput
{
    public class Program
    {
        private static void Main(string[] args)
        {
            string numintstr;
            numintstr = Console.ReadLine();
            int numint = Convert.ToInt32(numintstr);
            string numrealstr;
            numrealstr = Console.ReadLine();
            double numreal = Convert.ToDouble(numrealstr);
            Console.WriteLine($"Soma de {numint} e {numreal} é {numint + numreal}");
        }
    }
}
