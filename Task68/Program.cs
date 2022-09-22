using System;

namespace HomeTasks_KisEA
{
    class Program
    {
        static void Main (string[] args)        // Программа находит функцию Аккермана
        {
            int findAckermann(int m, int n)
            {  
                if(m == 0)
                    return n+1;
                else if(m > 0 && n ==0)
                    return findAckermann(m - 1, 1);
                else
                    return findAckermann(m - 1, findAckermann(m, n - 1));
            }

            int checkInput(int m, int n)
            {
                if (m >=0 && n >=0) return 1;
                else return 0;
            }

            try
            {
                Console.WriteLine("Программа находит значение функции Аккермана A(m,n)");
                Console.Write("Введите m: ");
                int m = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите n: ");
                int n = Convert.ToInt32(Console.ReadLine());

                if(checkInput(m,n) == 1)
                    Console.WriteLine($"Функция Аккермана равна {findAckermann(m,n)}");
                else
                    Console.WriteLine("Значения m и n должны быть неотрицательными");
            }
            catch
            {
                Console.WriteLine("Данные необходимо вводить цифрами");
            }
            
            
        }
    }
}