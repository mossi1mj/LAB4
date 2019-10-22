using System;
using System.Linq;

namespace LAB4
{
    class Program
    {
        static void Main(string[] args)
        {
            string answer = "y";
            bool continueApp = true;
            Console.WriteLine("Learn your Squares and Cubes!");
            do
            {
                //prompt user for integer
                Console.Write("Enter an integer: ");
                int num = int.Parse(Console.ReadLine());

                //input loop and shows calculations for squares and cubes
                Console.WriteLine("Number\tSquared\tCubed\n" + "======\t=======\t=====");
                for (int i = 1; i <= num; i++)
                {
                    int number = i;
                    int squared = i * i;
                    int cubed = i * i * i;
                    Console.WriteLine($"{number}\t{squared}\t{cubed}");
                }

                //promt user to continue application
                Console.WriteLine("Continue? (y/n)");
                answer = Console.ReadLine().ToLower();

                //loop if user enters wrong prompt to continue application
                while (answer != "y" && answer != "n")
                {
                    Console.Write("Please enter either (y/n): ");
                    answer = Console.ReadLine().ToLower();
                }

                //ends application if user chooses
                if (answer == "n")
                {
                    Console.WriteLine("Good bye!");
                    continueApp = false;
                }

            } while (continueApp);
        }
    }
}
