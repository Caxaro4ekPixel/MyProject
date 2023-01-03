using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_work_8._6
{
    internal class Task2
    {
        public void Task2Main()
        {
            Dictionary<string, string> dict = new Dictionary<string, string>();

            bool flag = true;
            string phone;
            string FIO;

            while (flag)
            {
                Console.WriteLine("Введите номер телефона");
                phone = Console.ReadLine();
                Console.WriteLine("Введите номер ФИО");
                FIO = Console.ReadLine();

                if (phone == "" || FIO == "")
                    break;
                dict[phone] = FIO;
            }

            Console.WriteLine("Введите искомый номер");
            phone = Console.ReadLine();
            if (dict.TryGetValue(phone, out FIO))
                Console.WriteLine(FIO);
            else
                Console.WriteLine("Такого номера не существует");
        }
    }
}
