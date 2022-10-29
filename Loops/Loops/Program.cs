using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10, y = 12;
            int i = 0;
            int sum = 0;
            for (i = x; i <= y; i++)
                sum += i;
            Console.WriteLine(sum);

            Console.WriteLine("Enter 2 numbers: ");
            
            int x1 = Convert.ToInt32(Console.ReadLine());
            int y1 = Convert.ToInt32(Console.ReadLine());
            int sum1 = 0;
            int i1 = 0;
            for (i1 = x1; i1 <= y1; i1++)
                sum1 += i1;

            Console.WriteLine(sum1);
            Console.ReadKey();
        }
    }
}
