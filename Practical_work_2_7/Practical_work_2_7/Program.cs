using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_work_2_7
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string fullName = "Завадский Андрей Андреевич";
            int age = 20;
            string email = "моя почта ХD";
            double scoresProg = 9.0;
            double scoresMath = 8.5;
            double scoresPhys = 8.0;
            double scoresSumm = scoresMath + scoresPhys + scoresProg;
            double scoresAverage = scoresSumm / 3;

            Console.WriteLine(
                $"ФИО: {fullName}" +
                $"\nВозраст: {age}" +
                $"\nE-mail: {email}" +
                $"\nБалл по программированию: {scoresProg}" +
                $"\nБалл по математике: {scoresMath}" +
                $"\nБалл по физике: {scoresPhys}"
                );

            Console.ReadKey();
            Console.WriteLine(
                $"Средний балл по всем придметом: {scoresAverage}");
            Console.ReadKey();
        }
    }
}
