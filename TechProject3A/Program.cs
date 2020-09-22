/// Tech Proj #3a: Methods
/// ISM 4300
/// Programmed by Lewis Morgan
using System;

namespace TechProject3A
{
    class Program
    {
        static void Main(string[] args)
        {

            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("Hello, what's your name?");

                // Get the users name
                string name = Console.ReadLine();
                // Print the name using a method
                printName(name);

                // Ask the user if they want to run the program again
                Console.WriteLine("Would you like to run the program again? Press 'Y' key if so.");

                // Exit the program if the 'Y' key was not pressed
                var key = Console.ReadKey();
                if (!(key.KeyChar == 'y' || key.KeyChar == 'Y'))
                {
                    exit = true;
                } 
                else
                {
                    // Add in an empty line at the start of the next loop otherwise the 'y' key will be smushed.
                    Console.WriteLine();
                }
            }
        }

        static void printName(string name)
        {
            string output = name;

            // Add in a custom message to the output based on the entered name... for fun :D
            switch (name.ToLower())
            {
                case "tom brady":
                    output += " - Go Bucs!";
                    break;
                case "darth vader":
                    output += " - How's Luke doin'?";
                    break;
                case "luke skywalker":
                    output += " - Pretty sure that Darth Vader is your father...";
                    break;
                case "michael travis":
                case "michael":
                case "travis":
                    output += " - Hey professor is that you?!";
                    break;
                case "lewis morgan":
                case "lewis":
                    output += " - My Creator!";
                    break;
                default:
                    output += "!";
                    break;
            }

            Console.WriteLine("Hello " + output);
        }
    }
}
