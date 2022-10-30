using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter count of elements: ");

            int ElementsCount = int.Parse(Console.ReadLine());
            int[] Array = new int[ElementsCount];

            Console.Write("Enter numbers for array: ");

            for (int i = 0; i < Array.Length; i++)
            {
                Console.Write($"\nEnter number for index{i}:\t ");
                Array[i] = int.Parse(Console.ReadLine());
          
            }

            for (int i = 0; i < Array.Length; i++)
            {
                Console.WriteLine(Array[i]);
            }

            Console.WriteLine("Max value: ");
            Console.Write(MaxValue(Array));

            Console.WriteLine("\nMin value: ");
            Console.Write(MinValue(Array));

            Console.Write("\nEnter 2 numbers: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int k = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(TrySumIfOdd(n, k));

            Console.ReadKey();
        }
        public static int MaxValue(int[] Array)
        {
            int maxElement = Array[0];
            for (int i = 1; i < Array.Length; i++)
            {
                if (Array[i] > maxElement)
                    maxElement = Array[i];
            }

            return maxElement;
        }
        public static int MinValue(int[] Array)
        {

            int minElement = int.MaxValue;
            foreach (var i in Array)
            {
                if (i < minElement)
                {
                    minElement = i;
                }
            }
            return minElement;

        }
        static public int TrySumIfOdd(int n, int k)
        {
            int sum = n + k;
            if(sum % 2==0)
            {
                Console.Write("FALSE\n");
                Console.Write("Sum = ");
                Console.WriteLine(sum);
                Console.Write("  ");

            }
            else
            {
                Console.Write("TRUE\n");
                Console.Write("Sum = ");
                Console.WriteLine(sum);
                Console.Write("  ");

            }
            return 0;
        }
        
    }
}
