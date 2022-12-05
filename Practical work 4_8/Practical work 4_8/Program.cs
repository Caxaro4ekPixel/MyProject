using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_work_4_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите кол-во строк в матрице:");
            int n = int.Parse(Console.ReadLine());
            int[,] arrey1 = GenArray(n);
            int sum = 0;

            Console.WriteLine($"1 матрица:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"{arrey1[i, j]} ");
                    sum += arrey1[i, j];
                }
                Console.WriteLine();
            }

            Console.WriteLine($"\nСумма всех элементов: {sum}");
            Console.WriteLine();

            int[,] array2 = GenArray(n);
            

            Console.WriteLine($"2 матрица:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"{array2[i, j]} ");
                }
                Console.WriteLine();
            }


            int[,] tempArray = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    tempArray[i, j] = arrey1[i, j] + array2[i, j];
                }
            }

            Console.WriteLine();
            Console.WriteLine($"сумма 2-х матриц:");

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"{tempArray[i, j]} ");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }

        static int[,] GenArray(int n)
        {
            int[,] arrey = new int[n, n];
            Random random = new Random();
            

            for (int i = 0; i < arrey.GetLength(0); i++)
            {
                for (int j = 0; j < arrey.GetLength(1); j++)
                {
                    arrey[i, j] = random.Next(0, 100);
                }
            }
            return arrey;
        }
    }
}
