using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_work_8._6
{
    internal class Task3
    {
        public void Task3Main()
        {
            HashSet<int> ints = new HashSet<int>();
            string str;
            int num;
            while (true)
            {
                Console.WriteLine("Введите число (введите q что бы выйти):");
                str = Console.ReadLine();
                if (str == "q")
                    break;
                num = int.Parse(str);
                if (ints.Contains(num))
                    Console.WriteLine("Такое число уже существует!");
                else
                {
                    ints.Add(num);
                    Console.WriteLine("Добавлено!");
                }
            }

            foreach(var i in ints)
                Console.Write(i.ToString() + " ");
            Console.WriteLine();
        }
    }
}
