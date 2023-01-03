using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_work_8._6
{
    internal class Task1
    {
        public void Task1Main()
        {
            List<int> list = GenList();
            ListShow(list);
            list = DelItemList(list);
            ListShow(list);
        }

        static void ListShow(List<int> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                Console.Write(list[i].ToString() + " ");
            }
            Console.WriteLine("\n\n");
        }

        static List<int> DelItemList(List<int> list)
        {
            list.RemoveAll(x => x < 25);
            list.RemoveAll(x => x > 50);
            return list;
        }

        static List<int> GenList() 
        {
            List<int> list = new List<int>();
            Random random = new Random();
            for (int i = 0; i < 100; i++)
            {
                list.Add(random.Next(0, 100));
            }
            return list; 
        }
    }
}
