using System;

namespace HomeTasks_KisEA
{
    class Program
    {
        static void Main (string[] args)        // Программа выводит все натуральные числа в промежутке от N до M
        {
            void showIntegers(int n, int m)
            {
                if(n < m)
                    for(int i = n; i <= m; i ++) Console.Write($"{i} ");
                else if(n > m)
                    for(int i = m; i <= n; i++) Console.Write($"{i} ");
                
                Console.WriteLine();
            }
            
            try
            {
                Console.WriteLine("Программа покажет все натуральные числа в промежутке от N до M");
                Console.Write("N: ");
                int n = Convert.ToInt32(Console.ReadLine());
                Console.Write("M: ");
                int m = Convert.ToInt32(Console.ReadLine());
                showIntegers(n,m);
            }
            catch
            {
                Console.WriteLine("Данные необходимо вводить цифрами");
            }

        }
    }
}