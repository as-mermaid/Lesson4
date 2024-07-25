using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            int n = Convert.ToInt32(Console.ReadLine());
            int result = 0;

            for (int i = 1; i <= n; i++)
            {
                result += 2 * i - 1;
                Console.WriteLine($"Квадрат числа {i} равен {result}");
            }
            Console.ReadKey();
        }
    }
}
