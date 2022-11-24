using System;

namespace PracticalWork_3_10
{
    internal class FirstTask
    {
        public static void FirstTaskMain()
        {
            Console.WriteLine("Задание 1:");
            FirstTaskMet();
            Console.WriteLine("-----------------------------------------");
        }

        static void FirstTaskMet()
        {
            Console.WriteLine("Введите целое число!");
            string str = Console.ReadLine();

            bool isParse = int.TryParse(str, out int num);
            if (isParse)
            {
                if (num % 2 == 0)
                {
                    Console.WriteLine("Вы ввели чётное число!");
                }
                else
                {
                    Console.WriteLine("Вы ввели не чётное число!");
                }
            }
            else { Console.WriteLine("Вы ввели не целое число!"); }
        }
    }
}
