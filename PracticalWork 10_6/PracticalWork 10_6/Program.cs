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

            bool flag1 = true; 
            while (flag1)
            {
                bool flag2 = true;
                Console.WriteLine("Введите кто работает: 1 - менеджер, 2 - консультант.");
                if (Console.ReadLine() == "1")
                {
                    List<BankA> persons = new List<BankA>();
                    while (flag2)
                    {
                        Console.WriteLine("1, просмотреть все данные\n2, добавить новые\n3, изменить номер телефона\n4, выйти");
                        switch (Console.ReadLine())
                        {
                            case "1":
                                foreach (var i in persons)
                                    i.ShowInfoUser();
                                break;
                            case "2":
                                persons.Add(new BankA(
                                        lastName: tempData.tempSurName[random.Next(0, 8)],
                                        firstName: tempData.tempName[random.Next(0, 8)],
                                        midleName: tempData.tempMiddleName[random.Next(0, 8)],
                                        phoneNumber: tempData.tempPhoneNumber[random.Next(0, 8)],
                                        passportNum: tempData.tempPasNumber[random.Next(0, 8)]
                                        ));
                                Console.WriteLine("Добавлено!");
                                break;
                            case "3":
                                Console.WriteLine("Введите номер телефона который хотите изменить: ");
                                string oldPhoneNum = Console.ReadLine();
                                foreach (var i in persons)
                                {
                                    if (i.PhoneNumber == oldPhoneNum)
                                    {
                                        Console.WriteLine("Введите новый номер телефона: ");
                                        string newPhoneNum = Console.ReadLine();
                                        i.PhoneNumber = newPhoneNum;
                                    }
                                    else
                                        Console.WriteLine("Номер телефона не найден!");
                                }
                                break;
                            case "4":
                                flag2 = false;
                                break;
                        }
                    }
                }
                else
                {
                    List<BankB> persons = new List<BankB>();
                    for (int i = 0; i < 10; i++)
                    {
                        persons.Add(new BankB(
                                        lastName: tempData.tempSurName[random.Next(0, 8)],
                                        firstName: tempData.tempName[random.Next(0, 8)],
                                        midleName: tempData.tempMiddleName[random.Next(0, 8)],
                                        phoneNumber: tempData.tempPhoneNumber[random.Next(0, 8)],
                                        passportNum: tempData.tempPasNumber[random.Next(0, 8)]
                                        ));
                    }
                    Console.WriteLine("1, просмотреть все данные\n2, изменить номер телефона\n3, выйти");
                    switch (Console.ReadLine())
                    {
                        case "1":
                            foreach (var i in persons)
                                i.ShowInfoUser();
                            break;
                        case "2":
                            Console.WriteLine("Введите номер телефона который хотите изменить: ");
                            string oldPhoneNum = Console.ReadLine();
                            foreach (var i in persons)
                            {
                                if (i.PhoneNumber == oldPhoneNum)
                                {
                                    Console.WriteLine("Введите новый номер телефона: ");
                                    string newPhoneNum = Console.ReadLine();
                                    i.PhoneNumber = newPhoneNum;
                                }
                                else
                                    Console.WriteLine("Номер телефона не найден!");
                            }
                            break;
                        case "3":
                            flag2 = false;
                            break;
                    }
                }
            }
            
        }
    }
}
