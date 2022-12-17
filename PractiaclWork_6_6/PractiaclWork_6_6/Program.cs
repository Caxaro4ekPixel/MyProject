using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractiaclWork_6_6
{
    internal class Program
    {

        static void Main(string[] args)
        {
            string filePath = ".\\text.txt";
            while (true)
            {
                Console.WriteLine("Введите 1, что бы просмотреть все данные. Введите 2, что бы добавить данные");
                int task = int.Parse(Console.ReadLine());

                if (!File.Exists(filePath))
                    File.Create(filePath);

                switch (task)
                {
                    case 1:
                        ShowData(filePath);
                        break;
                    case 2:
                        AddData(filePath);
                        break;
                }
            }
        }

        static void ShowData(string filePath)
        {
            StreamReader streamReader = new StreamReader(filePath);
            while (!streamReader.EndOfStream)
            {
                string[] userInfo = streamReader.ReadLine().Split('#', (char)StringSplitOptions.RemoveEmptyEntries);
                Console.WriteLine($"ID: {userInfo[0]}\nДата и время добавления записи: {userInfo[1]}\nФ. И. О.: {userInfo[2]}" +
                    $"\nВозраст: {userInfo[3]}\nРост: {userInfo[4]}\nДата рождения: {userInfo[5]}\nМесто рождения: {userInfo[6]}");
                Console.WriteLine();
            }
            streamReader.Close();
        }

        static void AddData(string filePath)
        {
            StreamWriter streamWriter = new StreamWriter(filePath);
            string[] structUser = { "ID", "Дата и время добавления записи", "Ф. И. О.", "Возраст", "Рост", "Дата рождения", "Место рождения"};
            string[] userInfo = new string[structUser.Length];

            
            for (int i = 0; i < structUser.Length; i++)
            {
                switch (structUser[i])
                {
                    case "Дата и время добавления записи":
                        userInfo[i] = DateTime.Now.ToString();
                        break;
                    default:
                        Console.WriteLine($"Введите {structUser[i]}:");
                        userInfo[i] = Console.ReadLine();
                        break;
                }
                
            }
            string temp = string.Join("#", userInfo);

            streamWriter.WriteLine(temp);
            streamWriter.Close();
        }
    }
}
    