using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp23
{
    internal class Program
    {
        public static int Min(int x, int y)
        {
            if (x < y)
                return x;
            else
                return y;
        }

        static void Main(string[] args)
        {
            
            Console.WriteLine("Введите значение a:");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите значение b:");
            int b = Convert.ToInt32(Console.ReadLine());

            
            int part1 = Min(2 * a, b + a);  
            int part2 = Min(2 * a - b, b); 
            int z = part1 + part2;
            Console.WriteLine($"Значение z: {z}");
            Console.ReadKey();
        }
    }
}
