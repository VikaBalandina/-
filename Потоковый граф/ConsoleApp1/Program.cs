using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static int Main(string[] args)
        {
            Console.WriteLine("Впишите n: ");
            int n = int.Parse(Console.ReadLine());
           
            if (n < 0)
            {
                Console.WriteLine("Результат равен: 0");
                return 0;
            }

            else if (n == 0 || n == 1)
            {
                Console.WriteLine("Результат равен: 1");
                return 1;
            }
            
            else
            {
                int result = 1;
                
                for (int i = 2; i <= n; i++)
                {
                    result *= i;
                }
                Console.WriteLine("Результат равен: " + result);
                return result;

            }

            /* 
                 потоковый граф  
            
                     0 < 0
                       |
                  0 <= n <= 1 
                       |
                      n > 1 
                       |
                   result = 1  
                       |
                      i = 2       
                       |
                    result *= i 
                       |
                      i++       
                       |
                    i <= n 
                       |
                  return result 

            Независимые маршруты:
                1. 0 < 0
                2. 0 <= n <= 1
                3.n > 1, i = 2, result = 1, i <= n, result *= i, i++, i <= n, return result

            Цикломатическая сложность: 3 

            Тесты:
                1. n = -1, результат: 0
                2. n = 0,  результат: 1
                3. n = 1,  результат: 1
                4. n = 5,  результат: 120
            */
        }
    }
}
