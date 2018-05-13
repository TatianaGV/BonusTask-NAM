using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NAM
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите все символы алфавита через пробел или нажмите Enter, чтобы задать алфавит по умолчанию (a-z, A-Z, 0-9, .!?`~@#№$%^&(){}[]<>;:'-_=+*/|\\), 'пробел', 'запятая'");
            var abc = Console.ReadLine().Split(' ').Distinct().ToArray();

            Console.WriteLine("\nВведите формулы подстановки в формате: исходное_слово Enter преобразованное_слово Enter\nПосле заключительной формулы введите 'stop'");
            string inWord, outWord;
            var rules = new List<Tuple<string, string>>();
            while ((inWord = Console.ReadLine()) != "stop")
            {
                outWord = Console.ReadLine();
                rules.Add(Tuple.Create(inWord, outWord));
            }

            Console.WriteLine("\nВведите слово, которое будет преобразовано алгоритмом");
            var word = Console.ReadLine();

            int k;
            Console.WriteLine();
            foreach (var i in rules)
            {
                while ((k = word.IndexOf(i.Item1)) != -1)
                {
                    word = word.Remove(k, i.Item1.Length).Insert(k, i.Item2);
                    Console.WriteLine(word);
                }
            }

            Console.ReadKey();
        }
    }
}