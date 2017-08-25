using System;
using WordCounter.Counter;

namespace WordCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let's calculate words. Type In text. Characters, dots and numbers Are allowed.");

            var input = Console.ReadLine();

            var countIt = new CountIt();
            Console.WriteLine(countIt.CountWords(input));
            Console.WriteLine();
            Console.WriteLine("Good Bye!");
            Console.ReadLine();
        }
    }
}
