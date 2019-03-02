using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    class Program
    {
        static void Main(string[] args)
        {
            //task1();
            //task2();
            //task3();
            //task4();
            task5();
            //task6();
        }
        ///Задание №1
        public static void task1()
        {
            double a, b, c, r;
            Console.WriteLine("Input a:");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Input b:");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Input c:");
            c = Convert.ToDouble(Console.ReadLine());
            r = ((b + (Math.Sqrt(b * b + 4 * a * c)) / 2 * a) - (Math.Pow(a, 3) * c + Math.Pow(b, -2)));
            Console.WriteLine("r = " + r);
        }
        ///Задание №2
        public static void task2()
        {
            /*Console.WriteLine("Задание №2");
            Console.Read();*/
            double a, b, c, d, t;
            Console.WriteLine("Input a:");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Input b:");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Input c:");
            c = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Input d:");
            d = Convert.ToDouble(Console.ReadLine());
            //t = (a * b) / (c * d) - ((a * b - c) / (c * d));
            t = ((a / c) * (b / d)) - (((a * b) - c) / (c * d));
            Console.WriteLine("t = " + t);
        }
        ///Задание №3
        public static void task3()
        {
            double x = 2, y = 5, n;
            if ((Math.Cos(x) - Math.Sin(y)) == 0)
                Console.WriteLine("No solutions");
            else
            {
                n = ((Math.Sin(x) + Math.Cos(y)) / (Math.Cos(x) - Math.Sin(y))) * Math.Tan(x * y);
                Console.WriteLine("n = " + n);
            }
            //Console.WriteLine("Input x:");
            //x = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Input y:");
            //y = Convert.ToDouble(Console.ReadLine());
            //n = ((Math.Sin(x) + Math.Cos(y)) / (Math.Cos(x) - Math.Sin(y))) * Math.Tan(x * y);
            //Console.WriteLine("n = " + n);
        }
        ///Задание №4
        public static void task4()
        {
            double x, y, m;
            Console.WriteLine("Input x:");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Input y:");
            y = Convert.ToDouble(Console.ReadLine());
            m = (x + y) / (y + 1) - (x * y - 12) / (34 + x);
            Console.WriteLine("m = " + m);
        }
        /// Задание №5 
        public static void task5()
        {
            double x = 0.2, y = 12, z;
            if (Math.Cos(x) == 0)
                Console.WriteLine("No solutions");
            else
            {
                
                z = (3 + Math.Pow(Math.E, y - 1)) /
                    (1 + Math.Pow(x, 2) * Math.Abs(y - Math.Tan(x)));                
                Console.WriteLine($"{String.Format("{0:F03}", z)}");
            }
            //Console.WriteLine("Input x:");
            //x = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Input y:");
            //y = Convert.ToDouble(Console.ReadLine());
            //z = (3 + Math.Pow(Math.E, y - 1)) / (1 + Math.Pow(x, 2) * Math.Abs(y - Math.Tan(x)));
            //Console.WriteLine("Z = " + z);
        }
        /// Задание №6 
        public static void task6()
        {
            double x, y;
            Console.WriteLine("Input x:");
            x = Convert.ToDouble(Console.ReadLine());
            y = (x - (Math.Pow(x, 3) / 3)) + (Math.Pow(x, 5) / 5);
            Console.WriteLine("Y = " + y);
        }
    }
}