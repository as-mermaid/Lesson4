using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размеры прямоугольника А и В");
            int a = Convert.ToInt32(Console.ReadLine());  
            int b = Convert.ToInt32(Console.ReadLine());  
            Console.WriteLine("Введите сторону вписываемого квадрата С");
            int c = Convert.ToInt32(Console.ReadLine());  

            int i = b;  
            int sum = 0;

            while (a >= c) 
            {
                while (i >= c) 
                {
                    sum++; 
                    i -= c; 
                }

                a -= c;
                i = b;
            }

            Console.WriteLine($"Количество вписанных квадратов {sum}");
            Console.ReadKey();
        }
    }
}
