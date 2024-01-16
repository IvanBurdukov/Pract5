using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pract5
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[] array = new int[7];
            int S = 0;
            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine("Введите число {0}:", i+1);
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int j = 0; j < 7; j++)
            {
                S += array[j];
            }
            Console.WriteLine();
            Console.WriteLine(((double)S)/7);
            Console.ReadKey();
        }
    }
}