using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите предложение, где слова разделены пробелами и знаки препинания не используются");
            string sentence = Console.ReadLine();
            string sentenceWithoutSpaces = sentence.Replace(" ", "");
            sentenceWithoutSpaces = sentenceWithoutSpaces.ToLower();
            string sentenceInverted = "";
            foreach (char c in sentenceWithoutSpaces)
            {
                sentenceInverted = c + sentenceInverted;
            }
            if (sentenceInverted == sentenceWithoutSpaces)
            {
                Console.WriteLine("Введенное вами предложение - палиндром!");
            }
            else
            {
                Console.WriteLine("Введенное вами предложение не палиндром!");
            }
             Console.ReadLine();
        }
    }
}
