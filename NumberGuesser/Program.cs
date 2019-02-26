using System; // Imports - external namespaces brought into this project

namespace NumberGuesser // Namespace = A container for classes and functions
{
    // Main Class Reference
    class Program
    {
        // Entry Point Method
        // Static refers to the class itself - object instantiation (static = no instances)
        static void Main(string[] args)
        {
            GetAppInfo(); // Runs function for appInfo
            GreetUser(); // Runs greetings function

            while (true) { 

            // Create random number for game (1-10)
            Random rng = new Random();
            int correctNumber = rng.Next(1, 10);

            // Init guess variable (Initialise var)
            int guess = 0;

            // Prompt user for a number (guess)
            Console.WriteLine("Guess a Number between 1-10");

            // While guess made is incorrect (loop)
            while (guess != correctNumber)
            {
                // Reads user input
                string input = Console.ReadLine();

                // Ensure value is a number
                if (!int.TryParse(input, out guess))
                {
                        PrintColorMessage(ConsoleColor.Red, "Please enter numbers only");

                    // Keeps user going
                    continue;
                }

                // Function Int32.Parse (Parses 'guess' into integer)
                guess = Int32.Parse(input); 

                // Match guess to correctNumber
                if (guess != correctNumber)
                {
                    PrintColorMessage(ConsoleColor.Red, "Your guess was incorrect, please try again");
                }

                    PrintColorMessage(ConsoleColor.Yellow, "Your are correct, well done!");

                    // Ask to play again
                    Console.WriteLine("Play Again? [Y or N]");
                    String answer = Console.ReadLine().ToUpper();

                    if (answer == "Y")
                    {
                        continue;
                    }
                    else if (answer == "N")
                    {
                        return;
                    }
                    else
                    {
                        return;
                    }
                }

            }

        }

        // Get and display appInfo
        static void GetAppInfo() 
        {
            // Set application variables
            String appName = "Number Guesser";
            String appVersion = "1.0.0";
            String appAuthor = "Lee Barnes";

            // Changes text color of terminal output
            Console.ForegroundColor = ConsoleColor.Green;

            // Defines basic app infromation
            Console.WriteLine("{0} -- Version {1} -- {2}", appName, appVersion, appAuthor);

            // Reset text color post appInfo (Header-Title)
            Console.ResetColor();
        }

        // Ask user's name and greet
        static void GreetUser() 
        {
            // Prompt user for user's name (User Interaction)
            Console.WriteLine("What is your name?");

            // Gets user input (name == input)
            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}, Let's play a game", inputName);
        }

        // Prints color message
        static void PrintColorMessage(ConsoleColor color, string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Please enter numbers only");
            Console.ResetColor();
        }
    }
}
