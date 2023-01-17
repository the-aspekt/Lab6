using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите предложение, где слова разделены пробелами и знаки препинания не используются");
            string sentence = Console.ReadLine();
            string longestWord = "";
            string[] sentenceArray;
            sentenceArray = sentence.Split();
            foreach (string word in sentenceArray)
            {
                if (longestWord.Length < word.Length)
                    longestWord = word;
            }
            Console.WriteLine("Самое длинное слово в предложении - {0}", longestWord);
            Console.ReadLine();
        }
    }
}
