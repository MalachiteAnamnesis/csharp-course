using System;

namespace userInput
{
    class Program
    {
        static void Main(string[] args)
        {
            string yourName; // string declaration
            Console.WriteLine("What is your name?");
            yourName = Console.ReadLine();

            Console.WriteLine("Hello {0}", yourName);
        }
    }
}
