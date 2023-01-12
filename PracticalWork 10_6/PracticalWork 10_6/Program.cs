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
            TempData tempData = new TempData();
            Random random = new Random();


            List<BankA> bankA = new List<BankA>();

            for (int i = 0; i < 8; i++)
            {
                bankA.Add(new BankA(
                    surName: tempData.tempSurName[random.Next(0,8)],
                    name: tempData.tempName[random.Next(0,8)],
                    middleName: tempData.tempMiddleName[random.Next(0,8)],
                    phoneNumber: tempData.tempPhoneNumber[random.Next(0,8)],
                    pasNumber: tempData.tempPasNumber[random.Next(0,8)]
                    ));
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
                            foreach(var i in bankA)
                            {
                                i.GetUserInfo();
                                Console.WriteLine("------------------------------------------------");
                            }
                            break;
                        case "2":
                            Console.WriteLine("Введите номер пользователя:");
                            string temp = Console.ReadLine();
                            foreach (var i in bankA)
                                if (temp == i.PhoneNumber)
                                {
                                    Console.WriteLine("Введите номер на который вы хотите изменить:");
                                    i.PhoneNumber = Console.ReadLine();
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
                List<BankB> bankB = new List<BankB>();
                while (flag)
                {
                    Console.WriteLine("Введите:\n1, что бы добавить данные.\n2, что бы просмотреть все данные\n3, что бы изменить данные\n4, что бы выйти.");
                    switch (Console.ReadLine())
                    {
                        case "1":
                            //Console.WriteLine("Введите данные для создания нового пользователя!");
                            //Console.WriteLine("Введите фамилию: ");
                            //string surName = Console.ReadLine();
                            //Console.WriteLine("Введите имя: ");
                            //string name = Console.ReadLine();
                            //Console.WriteLine("Введите отчество: ");
                            //string middleName = Console.ReadLine
                            //Console.WriteLine("Введите номер телефона: ");
                            //string phoneNumber = Console.ReadLine
                            //Console.WriteLine("Введите номер паспорта: ");
                            //string pasNumber = Console.ReadLine();
                            //bankB.Add(new BankB(surName, name, middleName, phoneNumber, pasNumber));

                            bankB.Add(new BankB(surName: tempData.tempSurName[random.Next(0, 8)],
                                                    name: tempData.tempName[random.Next(0, 8)],
                                                    middleName: tempData.tempMiddleName[random.Next(0, 8)],
                                                    phoneNumber: tempData.tempPhoneNumber[random.Next(0, 8)],
                                                    pasNumber: tempData.tempPasNumber[random.Next(0, 8)],
                                                    address: tempData.tempAddress[random.Next(0, 8)]));
                            break; 

                        case "2":
                            foreach (var i in bankB)
                            {
                                i.GetUserInfoB();
                                Console.WriteLine("------------------------------------------------");
                            }
                            break; 

                        case "3":
                            Console.WriteLine("Что хотите изменить?\n1 - номер телефона\n2 - адрес");
                            string temp = Console.ReadLine();
                            if (temp == "1")
                            {
                                Console.WriteLine("Введите номер пользователя:");
                                temp = Console.ReadLine();
                                foreach (var i in bankB)
                                    if (temp == i.PhoneNumber)
                                    {
                                        Console.WriteLine("Введите номер на который вы хотите изменить:");
                                        i.PhoneNumber = Console.ReadLine();
                                    }
                            }
                            else if (temp == "2")
                            {
                                Console.WriteLine("Введите номер пользователя:");
                                temp = Console.ReadLine();
                                foreach (var i in bankB)
                                    if (temp == i.PhoneNumber)
                                    {
                                        Console.WriteLine("Введите адресс на который вы хотите изменить:");
                                        i.Address = Console.ReadLine();
                                    }
                                    else
                                        Console.WriteLine("Номер не найден!");
                            }
                            break;




                        case "4":
                            flag = false;
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
