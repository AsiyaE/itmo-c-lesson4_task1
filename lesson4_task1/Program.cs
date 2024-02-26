using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson4_task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число N > 0");
            int N = Convert.ToInt32(Console.ReadLine());
            int sum = 0;

            if (N <= 0)
            {
                Console.WriteLine("число N - неположительное");
            }
            else
            {
                for (int i = 1; i <= N; i++)
                {
                    sum += 2 * i - 1; ;
                    Console.Write("{0} ", 2 * i - 1);
                }

                Console.WriteLine("сумма - {0} ", sum);
            }
            
            Console.Write("Нажмите любую клавишу");
            Console.ReadKey();
        }
    }
}
