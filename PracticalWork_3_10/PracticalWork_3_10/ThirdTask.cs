using System;

namespace PracticalWork_3_10
{
    internal class ThirdTask
    {
        public static void ThirdTaskMain()
        {
            Console.WriteLine("Задание 3:");
            ThirdTaskMet();
            Console.WriteLine("-----------------------------------------");
        }

        static void ThirdTaskMet()
        {
            Console.WriteLine("Введите простое целое чило");
            bool isParsed = int.TryParse(Console.ReadLine(), out int num);
            bool flag = false;

            if (isParsed)
            {
                int i = 2;
                while (i < num - 1)
                {
                    if (num % i == 0)
                    {
                        flag = true;
                    }
                    i++;
                }

                if (flag)
                {
                    Console.WriteLine("Число не являеться простым!");
                }
                else { Console.WriteLine("Число являеться простым!"); }
            }
            else { Console.WriteLine("Вы ввели не целое число!"); }
        }
    }
}
