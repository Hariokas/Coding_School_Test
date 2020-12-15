using System;

namespace _1_task
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] letter = new string[3];

            for (int i = 0; i < letter.Length; i++)
            {
                Console.Write("Enter letter: ");
                letter[i] = Console.ReadLine();
            }

            for (int i = 0; i < letter.Length; i++)
            {
                Console.Write($"{letter[letter.Length - 1 - i]} ");
            }

        }
    }
}
