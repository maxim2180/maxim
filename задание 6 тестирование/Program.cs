using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, x1, y, y1, z, z1, l1, l2, m1, m2, n1, n2,k;
            Console.WriteLine("введите кординаты первой прямой");
            Console.WriteLine("введите кординату х");
            x = Convert.ToDouble(Console.ReadLine());//ввод х
            Console.WriteLine("введите координату y");
            y = Convert.ToDouble(Console.ReadLine());//ввод у
            Console.WriteLine("введите координату z");
            z = Convert.ToDouble(Console.ReadLine());//ввод z
            Console.WriteLine("введите кординаты второй прямой");
            Console.WriteLine("введите кординату х1");
            x1 = Convert.ToDouble(Console.ReadLine());//ввод x1
            Console.WriteLine("введите координу у1");
            y1 = Convert.ToDouble(Console.ReadLine());//ввод y1
            Console.WriteLine("введите координату z");
            z1 = Convert.ToDouble(Console.ReadLine());//ввод z1
            l1 = x1 - x;
            m1 = y1 - y;
            l2 = x - x1;
            m2 = y - y1;
            n1 = z1 - z;
            n2 = z - z1;
            k = (l1 * m1 * n2) + (m1 * n1 * l2) + (l1 * m2 * n1) - (l2 * m1 * n1) - (m1 * l1 * n2) - (m2 * n1 * l1);
            if ( k == 0)
            {
                Console.WriteLine("прямые лежат в одной плоскости");
            }
            if ((l1 / l2 == m1 / m2) && (m1 / m2 == n1 / n2) && (l1/l2==n1/n2))
            {
                Console.WriteLine("прямые параллельны");
            }


        }
    }
}
