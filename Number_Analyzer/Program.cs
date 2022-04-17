using System;

namespace Number_Analyzer
{
    class Program
    {
        static void Main(string[] args)
        {
            string answer;
            Console.Write("Hello and welcome to the number analyzer! Please enter your name: ");
            string name = Console.ReadLine();

            do
            {
                Console.Write($"{name}, please enter a whole number between 1 and 100: ");
                int entry = int.Parse(Console.ReadLine());

                if (entry <= 0 || entry > 100)
                {
                    Console.WriteLine("Sorry that entry is invalid.");
                }
                if (entry % 2 != 0 && entry > 0 && entry < 60)
                {
                    Console.WriteLine($"{entry} is odd and less than 60!");
                }
                else if (entry % 2 == 0 && entry >= 2 && entry <= 24)
                {
                    Console.WriteLine($"{entry} is even and less than 25!");
                }
                else if (entry % 2 == 0 && entry >= 26 && entry <= 60)
                {
                    Console.WriteLine($"{entry} is even and between 26 and 60 inclusive!");
                }
                else if (entry % 2 == 0 && entry > 60 && entry <= 100)
                {
                    Console.WriteLine($"{entry} is even and greater than 60!");
                }
                else if (entry % 2 != 0 && entry > 60 && entry < 100)
                {
                    Console.WriteLine($"{entry} is odd and greater than 60!");
                }

                Console.WriteLine("Would you like to enter another number?");
                answer = Console.ReadLine();
            }

            while (answer == "yes" || answer == "y" || answer == "Yes" || answer == "Y");
            Console.WriteLine("");
            Console.WriteLine($"Goodbye, {name}!");

        }
    }
}
