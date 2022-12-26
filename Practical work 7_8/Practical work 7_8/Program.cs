using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_work_7_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Repository repository = new Repository();
            Repository.CheckFile();
            bool is_work = true;
            int id;
            Worker worker;
            Worker[] workers;

            while (is_work)
            {
                Console.WriteLine("1 - Просмотр всех записей." +
                    "\n2 - Просмотр одной записи. (по ID)" +
                    "\n3 - Создание записи." +
                    "\n4 - Удаление записи." +
                    "\n5 - Загрузка записей в выбранном диапазоне дат." +
                    "\n6 - Выход из программы"
                    );
                int task = int.Parse(Console.ReadLine());

                switch (task)
                {
                    case 1:
                        workers = repository.GetAllWorkers();
                        foreach (var wor in workers)
                            wor.ShowWorker();
                        break;
                    case 2:
                        Console.WriteLine("Введите искомый ID:");
                        id = int.Parse(Console.ReadLine());
                        worker = repository.GetWorkerById(id);
                        worker.ShowWorker();
                        break;
                    case 3:
                        worker = new Worker();
                        worker.DateCreate = DateTime.Now;
                        Console.WriteLine("Введите ФИО: ");
                        worker.FIO = Console.ReadLine();
                        Console.WriteLine("Возраст: ");
                        worker.Age = int.Parse(Console.ReadLine());
                        Console.WriteLine("Рост: ");
                        worker.Height = int.Parse(Console.ReadLine());
                        Console.WriteLine("Дата рождения: ");
                        worker.Birthdate = DateTime.Parse(Console.ReadLine());
                        Console.WriteLine("Место рождения: ");
                        worker.Birthplace = Console.ReadLine();
                        repository.CreateWorker(worker);
                        break;
                    case 4:
                        Console.WriteLine("Введите удаляемы ID:");
                        id = int.Parse(Console.ReadLine());
                        repository.DeleteWorker(id);
                        break;
                    case 5:
                        Console.WriteLine("Введите дату 'от': ");
                        DateTime from = DateTime.Parse(Console.ReadLine());
                        Console.WriteLine("Введите дату 'до': ");
                        DateTime to = DateTime.Parse(Console.ReadLine());
                        workers = repository.GetWorkersBetweenTwoDates(from, to);
                        foreach (var wor in workers)
                            wor.ShowWorker();
                        break;
                    case 6:
                        is_work = false;
                        break;
                }
            }
        }
    }
}
