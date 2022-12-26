using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace Practical_work_7_8
{
    class Repository
    {
        private const string _filePath = ".\\text.txt";
        public Worker[] GetAllWorkers()
        {
            int count = System.IO.File.ReadAllLines(_filePath).Length;
            Worker[] workers = new Worker[count];
            StreamReader streamReader = new StreamReader(_filePath);
            int i = 0;
            while (!streamReader.EndOfStream)
            {
                string[] userInfo = streamReader.ReadLine().Split('#', (char)StringSplitOptions.RemoveEmptyEntries);
                workers[i].Id = int.Parse(userInfo[0]);
                workers[i].DateCreate = DateTime.Parse(userInfo[1]);
                workers[i].FIO = userInfo[2];
                workers[i].Age = int.Parse(userInfo[3]);
                workers[i].Height = int.Parse(userInfo[4]);
                workers[i].Birthdate = DateTime.Parse(userInfo[5]);
                workers[i].Birthplace = userInfo[6];
                i++;
            }
            streamReader.Close();
            return workers;
        }

        public Worker GetWorkerById(int id)
        {
            Worker[] workers = GetAllWorkers();
            int temp = 0;
            for (int i = 0; i < workers.Length; i++)
            {
                if (workers[i].Id == id)
                {
                    temp = i;
                    break;
                }  
            }
            return workers[temp];
        }

        public void DeleteWorker(int id)
        {
            Worker[] workers = GetAllWorkers();
            int temp = 0;
            for (int i = 0; i < workers.Length; i++)
            {
                if (workers[i].Id == id)
                {
                    temp = i;
                    break;
                }
            }
            workers = workers.Where((val, idx) => idx != temp).ToArray();
            System.IO.File.WriteAllText(_filePath, string.Empty);
            StreamWriter streamWriter = new StreamWriter(_filePath);
            for (int i = 0; i < workers.Length; i++)
                streamWriter.WriteLine($"{workers[i].Id}#{workers[i].DateCreate}#{workers[i].FIO}#{workers[i].Age}#{workers[i].Height}#{workers[i].Birthdate}#{workers[i].Birthplace}");
            streamWriter.Close();
        }

        public void CreateWorker(Worker worker)
        {
            string[] rows = System.IO.File.ReadAllLines(_filePath);
            StreamWriter streamWriter = new StreamWriter(_filePath, append: true);

            if (rows.Length > 0)
                worker.Id = int.Parse(rows[rows.Length - 1].Split('#', (char)StringSplitOptions.RemoveEmptyEntries)[0]) + 1;
            else
                worker.Id = 0;
            streamWriter.WriteLine($"{worker.Id}#{worker.DateCreate}#{worker.FIO}#{worker.Age}#{worker.Height}#{worker.Birthdate}#{worker.Birthplace}");
            streamWriter.Close();

        }

        public Worker[] GetWorkersBetweenTwoDates(DateTime dateFrom, DateTime dateTo)
        {
            Worker[] workers = GetAllWorkers();
            Worker[] workersFiltred = new Worker[] { };
            for (int i = 0; i < workers.Length; i++)
            {
                if (workers[i].DateCreate > dateFrom && workers[i].DateCreate < dateTo)
                    workersFiltred.Append(workers[i]);
            }
            return workersFiltred;
        }

        public static void CheckFile()
        {
            if (!File.Exists(_filePath))
                File.Create(_filePath).Close();
        }
    }
}
