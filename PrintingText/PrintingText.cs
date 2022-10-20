using System;

namespace PrintingText
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("C# is cool"); // This is a basic print command in C#
            int x = 89; // Declare a variable with a 'int'eger value of 89
            Console.WriteLine(x); // Print the value of the variable to the terminal



            int a = 10; // Declare an integer 'a' with a value of 10
            double b = 20; // 'double' is C# syntax for 'float"
            string c = "gamer"; // Declare a string 'gamer'
            Console.WriteLine("a = {2}; b = {0}", a, b, c);
            /* Within the above print statement '{}' directs the program to replace 
            the value within the braces with the value of a declared variable, relative
            to its position when it's listed after the string: '(... , a, b, c);'
            
            This is known as a FORMATTED STRING
            
            0 = a(10)
            1 = b(20)
            2 = c("gamer")
            */

        }
    }
}