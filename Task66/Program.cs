using System;

namespace HomeTasks_KisEA
{
    class Program
    {
        static void Main (string[] args)        // Программа выводит сумму натуральных элементов в промежутке от N до M
        {
            int showSumIntegers(int n, int m)
            {
                int sum = 0;
                if(n < m)
                    for(int i = n; i <= m; i ++) sum = sum + i;
                
                else if(n > m)
                    for(int i = m; i <= n; i++) sum = sum + i;

                return sum;
            }
            
            try
            {
                Console.WriteLine("Программа покажет все сумму чисел в промежутке от N до M");
                Console.Write("N: ");
                int n = Convert.ToInt32(Console.ReadLine());
                Console.Write("M: ");
                int m = Convert.ToInt32(Console.ReadLine());
                Console.Write($"Сумма элементов в промежутке от N до M равна: {showSumIntegers(n,m)}");
            }
            catch
            {
                Console.WriteLine($"Данные необходимо вводить цифрами");
            }

        }
    }
}