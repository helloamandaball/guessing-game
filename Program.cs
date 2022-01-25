using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {

        //Phase 1:
            // The program should...
            // Display a message to the user asking them to guess the secret number.
            // Display a prompt for the user's guess.
            // Take the user's guess as input and save it as a variable.
            // Display the user's guess back to the screen.

            //--used string because I'm not sure what else to add to get int to work just yet
                // Console.WriteLine("*~*Guess the Secret Number!*~*");
                // string NumberGuessed = Console.ReadLine();
                // Console.WriteLine($"You guessed: {NumberGuessed}");


        //Phase 2:
            // The program should be updated to...
            // Create a variable to contain the secret number. This number should be hard-coded for now. 42 is a nice number.
            // No longer display the user's guess. They know what they guessed, right?
            // Compare the user's guess with the secret number. Display a success message if the guess is correct, otherwise display a failure message.
                // Console.WriteLine("*~*Guess the Secret Number!*~*");
                // string NumberGuessed = Console.ReadLine();

                // //--use and if/else statement:
                // if (NumberGuessed == "42")
                // {
                //     Console.WriteLine("Yep! You've guessed it! :)");
                // }
                // else{
                //     Console.WriteLine("Better luck next time :(");
                // }


        //Phase 3:
            // The program should be updated to...
            // Give the user four chances to guess the number.
            // Continue to display the success or failure messages as in phase 2
                // Console.WriteLine("*~*Guess the Secret Number!*~*");
                // string? NumberGuessed = Console.ReadLine();
                // //--create variable that gives number of tries:
                // //List has to be a string, but I'm not sure why, I'm guessing bc it just needs parsed somewhere else? Add the ? after string to get rid of the null warning.
                // List<string?> NumberOfTries = new List<string?> ();
                // //This below NumberOfTries.Add(NumberGuessed);, is so it counts on of the four guesses:
                // NumberOfTries.Add(NumberGuessed);
                // //--loop through 4x (for each guess)
                //     // for (int i = 0; i < 4; i++) -- this doesn't exactly work
                // //.Count is the same as .length in JS
                // while (NumberOfTries.Count < 4)
                // {
                //     // Console.WriteLine($"number of loops is {i}");////this was used when i wanted to see if t he for loop would solve this.

                //     //--use and if statement:
                //     if (NumberGuessed == "42")
                //     {
                //         Console.WriteLine("Yep! You've guessed it! :)");
                //         //break; will break the while loop
                //         break;
                //     }
                //     if (NumberGuessed != "42" && NumberOfTries.Count < 4) {
                //         NumberOfTries.Add(NumberGuessed);
                //         Console.WriteLine("Give it another try! ;)");
                //         //If I don't put the ReadLine(); in there, it gives me the console sentence above 3 times in a row.
                //         NumberGuessed = Console.ReadLine();
                //     }
                //     if (NumberGuessed != "42" && NumberOfTries.Count == 4) {
                //         Console.WriteLine("Better luck next time :(");
                //     }
                // }


        // Phase 4
            //The program should be updated to...
            // Display the number of the user's current guess in the prompt. For example, if the user has already guessed one time, the prompt should say something like Your guess (2)>.
            //End the loop early if the user guesses the correct number.
                // Console.WriteLine("*~*Guess the Secret Number!*~*");
                // string? NumberGuessed = Console.ReadLine();
 
                // List<string?> NumberOfTries = new List<string?> ();
                // NumberOfTries.Add(NumberGuessed);

                // int TotalGuessesAllowed = 4;

                // //--loop through 4x (for each guess)
                // //.Count is the same as .length in JS
                // while (NumberOfTries.Count < 4)
                // {
                //     //--use and if statement:
                //     if (NumberGuessed == "42")
                //     {
                //         Console.WriteLine("Yep! You've guessed it! :)");
                //         //break; will break the while loop
                //         break;
                //     }
                //     if (NumberGuessed != "42" && NumberOfTries.Count < 4) {
                //         NumberOfTries.Add(NumberGuessed);
                //         //I want the number of guesses so far subtracted from the total guesses allowed. NumberOfTries should be how many guesses have been entered, so I need to declare a variable for TotalGuessesAllowed as a starting point?
                //         Console.WriteLine($"You have {TotalGuessesAllowed - NumberOfTries.Count + 1} guesses left. Give it another try!");
                //         NumberGuessed = Console.ReadLine();
                //     }
                //     if (NumberGuessed != "42" && NumberOfTries.Count == 4) {
                //         Console.WriteLine("Better luck next time :(");
                //     }
                // }


        //Phase 5:
            // The program should be updated to...
            // Use a random number between 1 and 100 instead of a hard-coded number.
            // The prompt should display the number of guesses the user has left.
                // Console.WriteLine("");
                // Console.WriteLine("*~*Guess the Secret Number!*~*");
                // string? NumberGuessed = Console.ReadLine();
 
                // List<string?> NumberOfTries = new List<string?> ();
                // NumberOfTries.Add(NumberGuessed);

                // int TotalGuessesAllowed = 4;
                // //See rolling-dice we did in Ch.6 Translate Part 1 for how to do the random
                // int RandomNumber = new Random().Next(0, 100);
                // //This just turns NumberGuessed from a string into an integer. I didn't know how to do it another way and this one seemed to work.
                // int NumberGuessedParseInt = Int32.Parse(NumberGuessed);

                // //--loop through 4x (for each guess)
                // //.Count is the same as .length in JS
                // while (NumberOfTries.Count < 4)
                // {
                //     //--use and if statement:
                //     if (NumberGuessedParseInt == RandomNumber)
                //     {
                //         Console.WriteLine("Yep! You've guessed it! :)");
                //         //break; will break the while loop
                //         break;
                //     }
                //     if (NumberGuessedParseInt != RandomNumber && NumberOfTries.Count < 4) {
                //         NumberOfTries.Add(NumberGuessed);
                //         Console.WriteLine($"You have {TotalGuessesAllowed - NumberOfTries.Count + 1} guesses left. Give it another try!");
                //         NumberGuessed = Console.ReadLine();
                //     }
                //     if (NumberGuessedParseInt != RandomNumber && NumberOfTries.Count == 4) {
                //         Console.WriteLine($"Actually, the number was {RandomNumber}. Better luck next time :(");
                //         Console.WriteLine("");
                //     }
                // }

        //Phase 6:
            // The program should be updated to...
            // Inform the user if their guess was too high or too low, when they guess incorrectly.
                Console.WriteLine("");
                Console.WriteLine("*~*Guess the Secret Number!*~*");
                //Change this to an int instead of a string like it was in Phase 5
                int NumberGuessed = Convert.ToInt32(Console.ReadLine());
 
                List<int> NumberOfTries = new List<int> ();
                NumberOfTries.Add(NumberGuessed);

                int TotalGuessesAllowed = 4;
                //See rolling-dice we did in Ch.6 Translate Part 1 for how to do the random
                int RandomNumber = new Random().Next(0, 100);

                //--loop through 4x (for each guess)
                //.Count is the same as .length in JS
                while (NumberOfTries.Count < 4)
                {
                    //--use and if statement:
                    if (NumberGuessed == RandomNumber)
                    {
                        Console.WriteLine("Yep! You've guessed it! :)");
                        //break; will break the while loop
                        break;
                    }
                    else {
                        //NumberGuesses is more than RandomNumber generated, it's logged as too high
                        if (NumberGuessed > RandomNumber && NumberGuessed != RandomNumber && NumberOfTries.Count < 4) {
                            NumberOfTries.Add(NumberGuessed);
                            Console.WriteLine($"Too high! You have {TotalGuessesAllowed - NumberOfTries.Count + 1} guesses left. Give it another try!");
                            NumberGuessed = Convert.ToInt32(Console.ReadLine());
                        }
                        //NumberGuesses is less than RandomNumber generated, it's logged as too low
                        if (NumberGuessed < RandomNumber && NumberGuessed != RandomNumber && NumberOfTries.Count < 4) {
                            NumberOfTries.Add(NumberGuessed);
                            Console.WriteLine($"Too low! You have {TotalGuessesAllowed - NumberOfTries.Count + 1} guesses left. Give it another try!");
                            NumberGuessed = Convert.ToInt32(Console.ReadLine());;
                        }
                    }
                    if (NumberGuessed != RandomNumber && NumberOfTries.Count == 4) {
                        Console.WriteLine($"Actually, the number was {RandomNumber}. Better luck next time :(");
                        Console.WriteLine("");
                    }
                }

    


        }
    }
}
