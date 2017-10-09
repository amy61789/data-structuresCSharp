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
            for (int i = word.Length - 1; i >= 0; i--)
            {
                reversed += word[i];
            }

            Console.WriteLine(reversed);
        }
    }
}
