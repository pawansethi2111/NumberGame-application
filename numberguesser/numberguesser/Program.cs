// See https://aka.ms/new-console-template for more information
using System;
using System.Runtime.InteropServices;

//namespace
namespace NumberGuesser
{
    // Main Class
    class Program
    {
        //entry point method
        static void Main(string[] args)
        {
           
            GetAppInfo(); //run getapp info function to get info

            GreetUser(); //ask for users name and greet 

            //refer to:https://www.youtube.com/watch?v=GcFJjpMFJvI&ab_channel=TraversyMedia
            while (true)
            {
                //init correct number
                // int correctNumber = 7;

                // create a new random object 
                Random random = new Random();

                //init correct number
                int correctNumber = random.Next(1, 10);

                //init guess var 
                int guess = 0;

                //ask user for number 
                Console.WriteLine("Guess a number between 1 and 10");

                //while guess is not correct 
                while (guess != correctNumber)
                {
                    //get users input

                    string input = Console.ReadLine();

                    //make sure it's a number 
                    if (!int.TryParse(input, out guess))
                    {


                        //print error message 
                        PrintColorMessage(ConsoleColor.Red, "Please use an actual number");

                        //keep going 
                        continue;

                    }

                    // cast to int and put in guess

                    guess = Int32.Parse(input);

                    // match guess to correct number 

                    if (guess != correctNumber)
                    {
                        //print error message 
                        PrintColorMessage(ConsoleColor.Red, "Wrong number, please try again ");
                    }

                }

                //print success message 
                PrintColorMessage(ConsoleColor.Yellow, "Correct !! you guessed it ! ");


                //ask to play again
                Console.WriteLine("Play again ? [Y or N]");

                //get answer 

                string answer = Console.ReadLine().ToUpper();

                if (answer== "Y")
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
        //get and display app info
        static void GetAppInfo()
        {
            //Set app vars
            string appName = " Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Pawan Sethi ";

            //change text color 
            Console.ForegroundColor = ConsoleColor.Green;

            //write out app info
            Console.WriteLine("{0} : Version {1} by {2}", appName, appVersion, appAuthor);

            //reset text color 
            Console.ResetColor();

        }

        //ask users name and greet
        static void GreetUser()
        {
            //ask users name
            Console.WriteLine("What is your name ?");

            //get user input
            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}, let's a play a game....", inputName);
        }

        //print color message 

        static void PrintColorMessage(ConsoleColor color, string message)
        {
            //change text color 
            Console.ForegroundColor = color;

            //tell user its not a number
            Console.WriteLine(message);

            //reset text color 
            Console.ResetColor();
        }
    }
}


