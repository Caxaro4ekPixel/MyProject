using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticalWork_10_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] tempName = { "Владимир", "Алексей", "Артур", "Олег", "Тимофей", "Святослав", "Ермолай", "Емельян" };
            string[] tempSurName = { "Карандашев", "Апостол", "Ягодкин", "Меркьюри", "Королёв", "Петросян", "Усачев", "Вересков" };
            string[] tempMiddleName = { "Себастьянович", "Демьянович", "Иванович", "Жоржович", "Никонович", "Гавриилович", "Адамович", "Осипович" };
            string[] tempPhoneNumber = { "375(25)258-98-85", "375(44)136-29-87", "375(33)621-95-34", "375(29)059-88-60", "375(25)108-19-18", "375(44)429-75-26", "375(25)146-46-75", "375(33)556-63-21" };
            string[] tempPasNumber = { "4230902А067РВ5", "5221019В011РВ4", "6110101А019РВ3", "5190303М011РВ2", "5040505А071РВ2", "6221013А013РВ2", "5010101А001РВ1", "6221002А071РВ5" };

            Random random = new Random();

            BankA[] bankA = new BankA[8];

            for (int i = 0; i < 8; i++)
            {
                bankA[i] = new BankA(
                    surName: tempSurName[random.Next(0,8)],
                    name: tempName[random.Next(0,8)],
                    middleName: tempMiddleName[random.Next(0,8)],
                    phoneNumber: tempPhoneNumber[random.Next(0,8)],
                    pasNumber: tempPasNumber[random.Next(0,8)]
                    );
            }

            bool flag = true;

            Console.WriteLine("Кто работает?\n1 - консультант\n2 - менеджер");
            string worker = Console.ReadLine();
            if (worker == "1")
            {
                while (flag)
                {
                    Console.WriteLine("Введите:\n1, что бы просмотреть данные.\n2, что бы изменить номер.\n3, что бы выйти.");
                    switch (Console.ReadLine())
                    {
                        case "1":
                            for (int i = 0; i < 8; i++)
                            {
                                bankA[i].GetUserInfo();
                                Console.WriteLine("------------------------------------------------");
                            }
                            break;
                        case "2":
                            Console.WriteLine("Введите номер пользователя:");
                            string temp = Console.ReadLine();
                            for (int i = 0; i < 8; i++)
                                if (temp == bankA[i].PhoneNumber)
                                {
                                    Console.WriteLine("Введите номер на который вы хотите изменить:");
                                    bankA[i].PhoneNumber = Console.ReadLine();
                                }
                            break;
                        case "3":
                            flag = false;
                            break;
                        default:
                            Console.WriteLine("Вы ввели неверное число!");
                            break;
                    }
                }
            }
            else if (worker == "2")
            {
                while (flag)
                {
                    Console.WriteLine("Введите:\n1, что бы добавить даннык.\n2, что бы выйти.");
                    switch (Console.ReadLine())
                    {
                        case "1":
                            Console.WriteLine("Введите данные для создания нового пользователя!");

                            Console.WriteLine("Введите фамилию: ");
                            string surName = Console.ReadLine();

                            Console.WriteLine("Введите имя: ");
                            string name = Console.ReadLine();

                            Console.WriteLine("Введите отчество: ");
                            string middleName = Console.ReadLine();

                            Console.WriteLine("Введите номер телефона: ");
                            string phoneNumber = Console.ReadLine();

                            Console.WriteLine("Введите номер паспорта: ");
                            string pasNumber = Console.ReadLine();

                            BankB bankB = new BankB(surName, name, middleName, phoneNumber, pasNumber);
                            break; 
                        case "2":
                            break; 
                        default:
                            Console.WriteLine("Вы ввели неверное число!");
                            break;
                    }
                }
            }
        }
    }
}
