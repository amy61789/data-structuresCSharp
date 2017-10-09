using System;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter in a word you would like to be reversed!");
            Reverse(Console.ReadLine());
            Console.Read();

        }

        static void Reverse(string word)
        {
            string reversed = "";
            for (int i = 0; i < word.Length; i--)
            {
                reversed += [i];
            }

            Console.WriteLine(reversed);
        }
    }
}
