using System;

namespace PracticalWork_3_10
{
    internal class FifthTask
    {
        public static void FifthTaskMain()
        {
            Console.WriteLine("Задание 5:");
            FifthTaskMet();
            Console.WriteLine("-----------------------------------------");
        }

        static void FifthTaskMet()
        {
            Console.WriteLine("Введите максимальное число диапозона: ");
            int max = int.Parse(Console.ReadLine());
            Random rnd = new Random();
            int num = rnd.Next(0, max);

            Console.WriteLine("Попробуйте отгодать число");
            while (true)
            {
                Console.WriteLine("Введите ваше предположение:");
                string usenum = Console.ReadLine();
                if (usenum != "")
                {
                    int temp = int.Parse(usenum);
                    if (temp < num)
                    {
                        Console.WriteLine("Вы ввели число меньше загадонного");
                    }
                    else if (temp > num)
                    {
                        Console.WriteLine("Вы ввели число больше загадонного");
                    }
                    else
                    {
                        Console.WriteLine($"Вы совершенно правы! Это: {num}");
                        break;
                    }
                }
                else
                {
                    Console.WriteLine($"Загаданное число: {num}");
                    break;
                }
            }
        }
    }
}
