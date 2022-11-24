using System;

namespace PracticalWork_3_10
{
    internal class SecondTask
    {
        public static void SecondTaskMain()
        {
            Console.WriteLine("Задание 2:");
            SecondTaskMet();
            Console.WriteLine("-----------------------------------------");
        }

        static void SecondTaskMet()
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
                    switch (card)
                    {
                        case "J":
                            sum += 10;
                            break;
                        case "Q":
                            sum += 10;
                            break;
                        case "K":
                            sum += 10;
                            break;
                        case "T":
                            sum += 10;
                            break;
                        case "6":
                            sum += 6;
                            break;
                        case "7":
                            sum += 7;
                            break;
                        case "8":
                            sum += 8;
                            break;
                        case "9":
                            sum += 9;
                            break;
                        case "10":
                            sum += 10;
                            break;
                    }
                }
                Console.WriteLine($"А не плохо!) У вас: {sum} очков");
            }
            else { Console.WriteLine("Вы явно ввели что-то не то ;("); }
        }
    }
}
