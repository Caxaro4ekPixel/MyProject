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

            string[] splitText = SplitText(text);



            ShowText(splitText);
            Console.WriteLine(Reverse(splitText));
            Console.ReadKey();
        }

        static string[] SplitText(string text)
        {
            return text.Split(' ');
        }

        static void ShowText(string[] text)
        {
            for(int i = 0; i < text.Length; i++)
            {
                Console.WriteLine(text[i]);
            }
        }

        static string Reverse(string[] text)
        {
            string res = "";

            for(int i = text.Length - 1; i >= 0; i--)
                res+= text[i] + " ";

            return res;
        }
    }
}
