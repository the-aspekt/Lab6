using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите предложение. Весь текст, заключенный в фигурные скобки будет удалён!");
            string sentence = Console.ReadLine();
            int flag = 0;
            string sentenceResult = "";
            foreach (char c in sentence)
            {
                if (c.Equals('{'))
                {
                    flag++;
                }
                else if (c.Equals('}'))
                {
                    flag--;
                }
                else if (flag <= 0)
                {
                    sentenceResult = sentenceResult + c;
                }
            }
            Console.WriteLine("Ваше предложение без текста в фигурных скобках:");
            Console.WriteLine(sentenceResult);
            Console.ReadLine();
        }
    }
}
