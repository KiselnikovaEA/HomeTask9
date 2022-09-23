using System;

namespace HomeTasks_KisEA
{
    class Program
    {
        static void Main (string[] args)        // Программа выводит сумму натуральных элементов в промежутке от N до M
        {

            int showSumIntegers(int n, int m)
            {
                if(n == m)
                    return n;
                return m + showSumIntegers(n, m - 1);
            }
            
            try
            {
                Console.WriteLine("Программа покажет все сумму чисел в промежутке от N до M");
                Console.Write("N: ");
                int n = Convert.ToInt32(Console.ReadLine());
                Console.Write("M: ");
                int m = Convert.ToInt32(Console.ReadLine());

                if(n < m)
                    Console.Write($"Сумма элементов в промежутке от N до M равна: {showSumIntegers(n,m)}");
                else Console.Write($"Число N должно быть меньше M");
            }
            catch
            {
                Console.WriteLine($"Данные необходимо вводить цифрами");
            }

        }
    }
}