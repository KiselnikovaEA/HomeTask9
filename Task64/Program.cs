using System;

namespace HomeTasks_KisEA
{
    class Program
    {
        static void Main (string[] args)        // Программа выводит все натуральные числа в промежутке от N до M
        {
            void showIntegers(int n, int m)
            {
                if(m > n)
                    showIntegers(n, m - 1);
                Console.Write($"{m} ");              
            }
            
            try
            {
                Console.WriteLine("Программа покажет все натуральные числа в промежутке от N до M");
                Console.Write("N: ");
                int n = Convert.ToInt32(Console.ReadLine());
                Console.Write("M: ");
                int m = Convert.ToInt32(Console.ReadLine());
                
                if(n < m) showIntegers(n,m);
                else Console.WriteLine("Число N должно быть меньше M");

            }
            catch
            {
                Console.WriteLine("Данные необходимо вводить цифрами");
            }

        }
    }
}