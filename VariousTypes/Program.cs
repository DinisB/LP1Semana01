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
            float i = 3.1415f;
            double j = 3.1415926535;
            decimal k = 3.14159265358979323846m;
            bool ltrue = true;
            bool lfalse = false;

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
            Console.WriteLine(i);
            Console.WriteLine(j);
            Console.WriteLine(k);
            Console.WriteLine(ltrue);
            Console.WriteLine(lfalse);
        }
    }
}
