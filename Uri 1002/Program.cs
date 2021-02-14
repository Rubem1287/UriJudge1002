using System;
using System.Globalization;

namespace Uri_1002
{
    class Program
    {
        static void Main(string[] args)
        {
            double area, radio, n,r;

            n = 3.14159;
            
            

            Console.WriteLine();
            Console.Write("Digite o valor do raio : ");
            r = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            radio = Math.Pow(r, 2);

            area = radio * n;

            Console.WriteLine();
            Console.Write("A = "+area.ToString("F4", CultureInfo.InvariantCulture));

        }
    }
}
