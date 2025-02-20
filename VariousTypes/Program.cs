using System;
using System.Text;

namespace VariousTypes
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8; 
            sbyte a = -128;
            byte b = 255;
            short c = 32767;
            ushort d = 65535;
            int e = 2147483647;
            uint f = 4294967295;
            long g = 9223372036854775807;
            ulong h = 18446744073709551615;
            char cruz = '\u2020';
            char tesoura = '\u2702';

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.WriteLine(e);
            Console.WriteLine(f);
            Console.WriteLine(g);
            Console.WriteLine(h);
            Console.WriteLine(cruz);
            Console.WriteLine(tesoura);
        }
    }
}
