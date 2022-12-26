using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_work_7_8
{
    struct Worker
    {
        public int Id { get; set; }
        public DateTime DateCreate { get; set; }
        public string FIO { get; set; }
        public int Age { get; set; }
        public int Height { get; set; }
        public DateTime Birthdate { get; set; }
        public string Birthplace { get; set; }

        public Worker(int id, DateTime dateCreate, string fIO, int age, int height, DateTime birthdate, string birthplace)
        {
            Id = id;
            DateCreate = dateCreate;
            FIO = fIO;
            Age = age;
            Height = height;
            Birthdate = birthdate;
            Birthplace = birthplace;
        }

        public void ShowWorker()
        {
            Console.WriteLine(
                $"ID: {this.Id}\n" +
                $"Дата создания: {this.DateCreate}\n" +
                $"ФИО: {this.FIO}\n" +
                $"Возраст: {this.Age}\n" +
                $"Рост: {this.Height}\n" +
                $"Дата рождения: {this.Birthdate}\n" +
                $"Место рождения: {this.Birthplace}\n");
        }
    }
}
