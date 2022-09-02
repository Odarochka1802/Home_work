using System;
 
namespace HelloApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число: ");
            int b = Convert.ToInt32(Console.ReadLine());
 
            if(a > b)
            {
                Console.WriteLine($"Первое число {a} больше второго {b}");
            }
            else if (a < b)
            {
                Console.WriteLine($"Первое число {a} меньше второго {b}");
            }
            else
            {
                Console.WriteLine("Оба числа равны");
            }

        }
    }
}