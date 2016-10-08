using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = { "hello", "wonderful", "LINQ", "beautiful", "world" };

            //Get only short words
            var shortWords = from word in words
                             where word.Length <= 5
                             select word;

            //Print each word out
            foreach (var word in shortWords)
            {
                Console.WriteLine(word);
            }

            Console.WriteLine(String.Empty.PadRight(40, '='));
            var longwords = from w in words where w.Length > 5 select w;

            //Get only long words
            foreach (var word in longwords)
            {
                Console.WriteLine(word);
            }

            Console.WriteLine(String.Empty.PadRight(40, '-'));


            //Get only long words by lambda-expression
            longwords = words.Where(w => w.Length > 5);

            foreach (var word in longwords)
            {
                Console.WriteLine(word);
            }

            Console.ReadLine();
        }
    }
}
