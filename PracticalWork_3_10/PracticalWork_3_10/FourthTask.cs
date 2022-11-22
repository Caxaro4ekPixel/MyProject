using System;

namespace PracticalWork_3_10
{
    internal class FourthTask
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 4:");
            FourthTaskMet();
        }

        static void FourthTaskMet()
        {
            Console.WriteLine("Введите кол-во элементов");
            int range = int.Parse(Console.ReadLine());
            int min = int.MaxValue;
            for (int i = 0; i < range; i++)
            {
                Console.WriteLine("Введите число: ");
                int num = int.Parse(Console.ReadLine());
                if (num < min)
                {
                    min = num;
                }
            }
            Console.WriteLine($"Минимальное значение: {min}");
        }
    }
}
