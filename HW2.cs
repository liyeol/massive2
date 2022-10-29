using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleHW
{
    class Program
    {
       
        public static void Main(string[] args)
        {
            //Console.WriteLine("1 task");
            //int a = 5, b = 7;
            //float c = 5.9f, d = 3.2f;
            //double e = 2.3, f = 1.9;
            //char g = '\x41';
            //string str1 = "hello";
            //string str2 = "world";

            //string str3 = str1 + " " + str2;
            //Console.WriteLine(str3);
            //Console.WriteLine(a + b);
            //Console.WriteLine(a - b);
            //Console.WriteLine(a * b);
            //Console.WriteLine(a / b);
            //Console.WriteLine(a % b);

            //Console.WriteLine(c + d);
            //Console.WriteLine(c - d);
            //Console.WriteLine(c - d);
            //Console.WriteLine(c * d);
            //Console.WriteLine(c / d);
            //Console.WriteLine(c % d);

            //Console.WriteLine(e + f);
            //Console.WriteLine(e - f);
            //Console.WriteLine(e * f);
            //Console.WriteLine(e / f);
            //Console.WriteLine(e % f);

            //Console.WriteLine(a - c);
            //Console.WriteLine(c + f);
            //Console.WriteLine(str1 + " " + g);C

            Console.Write("Enter number x: ");
            int? x = Convert.ToInt32(Console.ReadLine());

            //double pow = Math.Pow(x, 3);
            //double pow1 = Math.Pow(x, 2);
            //Console.WriteLine(-6 * pow + 5 * pow1 - 10 * x + 15);
            Console.Write(" -6 * x^3 + 5 * x^2 - 10 * x + 15 = ");
            Console.WriteLine(-6 * x * x * x + 5 * x * x - 10 * x + 15);

            Console.Write("Enter new number y: ");
            int y = Convert.ToInt32(Console.ReadLine());
            double r = Math.Abs(y);
            double r1 = Math.Sin(y);
            double Res = r * r1;

            Console.WriteLine("Abs(y)*Sin(y) = ");
            Console.WriteLine(Res);

            Console.Write("Enter new number z: ");
            int z = Convert.ToInt32(Console.ReadLine());
            double rez = 2 * Math.PI * z;
            Console.WriteLine("2*Pi*z =");
            Console.WriteLine(rez);

            Console.Write("Enter new numbers db1, db2: ");
            int db1 = Convert.ToInt32(Console.ReadLine());
            int db2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Math.Max Method (Double, Double) = " + Math.Max(db1, db2));
            Console.ReadKey();










        }
    }
}
