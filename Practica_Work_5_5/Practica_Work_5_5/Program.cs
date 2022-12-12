using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_Work_5_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите набор слов через пробел");
            string text = Console.ReadLine();
            ShowText(text);
            Reverse(text);

            Console.ReadKey();
        }

        static string[] SplitText(string text)
        {
            return text.Split(' ');
        }

        static void ShowText(string text)
        {
            string[] textSplit = SplitText(text);
            for (int i = 0; i < textSplit.Length; i++)
            {
                Console.WriteLine(textSplit[i]);
            }
        }

        static void Reverse(string text)
        {
            string[] textSplit = SplitText(text);
            string res = "";

            for(int i = textSplit.Length - 1; i >= 0; i--)
                res+= textSplit[i] + " ";

            Console.WriteLine(res);
        }
    }
}
