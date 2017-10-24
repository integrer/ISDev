using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kv_ur
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, D;
            Console.Write("Введите переменные:\n\ta = ");
            a = Double.Parse(Console.ReadLine());
            Console.Write("\tb = ");
            b = Double.Parse(Console.ReadLine());
            Console.Write("\tc = ");
            c = Double.Parse(Console.ReadLine());
            D = Math.Pow(b, 2) - 4 * a * c;
            if (D<0) {
                Console.WriteLine("\nРешений нет.");
                Console.ReadKey();
                return;
            }
            D = Math.Sqrt(D);
            Console.WriteLine("\nx1 = "+((-b - D)/2*a)+ ", x2 = " + ((-b + D) / 2 * a));
            Console.ReadKey();
        }
    }
}
