using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int positiveCount = 0;
            int negativeCount = 0;
            int number;

            do
            {
                Console.WriteLine("Введите число (0 для завершения)");
                number = Convert.ToInt32(Console.ReadLine());

                if (number> 0)
                {
                    positiveCount++;
                }
                else if (number <0)
                {
                    negativeCount++;
                }

            } while (number != 0);

            if (positiveCount > negativeCount)
            {
                Console.WriteLine("Количество положительных числе больше, чем отрицательных");
            }
            else if (positiveCount < negativeCount)
            {
                Console.WriteLine("Количество положительных числе меньше, чем отрицательных");
            }
            else
            {
                Console.WriteLine("Количество положительных и отрицательных числе равно");
            }
            Console.ReadKey();
        }
    }
}
