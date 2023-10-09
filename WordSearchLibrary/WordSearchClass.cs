using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordSearchLibrary
{
    public class WordSearchClass
    {
        /// <summary>
        /// Реализовать метод, который бы определял количество слов word в тексте textString. Предполагается, что словом является любая последовательность букв, ограниченная двумя или одним пробелом (в случае начала или конца строки). Предполагается, что слова проверяются без учета регистра символов.
        /// </summary>
        /// <param name="textString">Метод принимает две строки: textString и word. Строка textString содержит исходный текст, строка word представляет собой слово, которое нужно искать.Для упрощения задачи гарантируется, что переменная textString содержит только буквы и пробелы;</param>
        /// <param name="word">Значение переменной word всегда состоит из букв и содержит по крайней мере два символа.</param>
        /// <returns>Метод возвращает целое число - количество слов word в тексте textString.</returns>
        public static int WordCount(string textString, string word)
        {
            int count = 0;
            if (String.IsNullOrWhiteSpace(textString)||String.IsNullOrWhiteSpace(word))
            {
                throw new Exception();
            }
            textString = textString.ToLower().Trim();
            word= word.ToLower().Trim();
            string[] words = textString.Split(new char[] { ' ' });
            foreach (string s in words)
            {
                if (s == word)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
