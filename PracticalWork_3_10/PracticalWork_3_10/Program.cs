using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticalWork_3_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 1:");
            FirstTask();
            Console.WriteLine("-----------------");
            Console.WriteLine();
            Console.WriteLine("Задание 2:");
            SecondTask();
            Console.WriteLine("-----------------");
            Console.WriteLine();
            Console.WriteLine("Задание 3:");
            ThirdTask();
            Console.WriteLine("-----------------");
            Console.WriteLine();
            Console.WriteLine("Задание 4:");
            FourthTask();
            Console.WriteLine("-----------------");
            Console.WriteLine();
            Console.WriteLine("Задание 5:");
            FifthTask();
            Console.WriteLine("-----------------");
            Console.ReadKey();
        }

        static void FirstTask()
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

        static void SecondTask()
        {
            Console.WriteLine("Сколько карт у вас на руках?");
            string str = Console.ReadLine();

            int sum = 0;

            bool isParse = int.TryParse(str, out int num);

            if (isParse)
            {
                for (int i = 0; i < num; i++)
                {
                    Console.WriteLine("Введите вашу карту (наменалом от 6 до 10 и картинки: Валет = J, Дама = Q, Король = K, Туз = T)");
                    string card = Console.ReadLine();
                    if (card == "J" || card == "Q" || card == "K" || card == "T")
                    {
                        sum+=10;
                    }
                    else if (int.TryParse(card, out int a) && a > 5 && a < 11)
                    {
                        sum += int.Parse(card);
                    }
                    else
                    {
                        Console.WriteLine("Вы ввели не верное значение)");
                        i--;
                    }
                }
                Console.WriteLine($"А не плохо!) У вас: {sum} очков");
            }
            else { Console.WriteLine("Вы явно ввели что-то не то ;("); }
        }

        static void ThirdTask()
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
        
        static void FourthTask()
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

        static void FifthTask()
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
                    if (int.Parse(usenum) < num)
                    {
                        Console.WriteLine("Вы ввели число меньше загадонного");
                    }
                    else if (int.Parse(usenum) > num)
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
