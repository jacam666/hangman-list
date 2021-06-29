using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;



namespace hangman_list
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> wordsList = new List<string>();  //implement a GetRandomWord Method instead of all this

            wordsList.Add("hello");
            wordsList.Add("football");
            wordsList.Add("england");
            wordsList.Add("bitcoin");
            wordsList.Add("bodybuilding");
            wordsList.Add("cameron");

            Console.WriteLine("\t\t\t Welcome to my Hangman game, Good luck!");

            //gets user birthdate year
            //checks if user is >18
            //does wha

            //activating my random word
            Random rng = new Random();

            int rndWordIndex = rng.Next(0, wordsList.Count);   //warning! magic number ?!?!

            char[] currentWord = wordsList[rndWordIndex].ToCharArray();

            char[] displayWord = new char[currentWord.Length];
            int lives = currentWord.Length + 2;
            int number = 0;

            Console.WriteLine("guess for a {0} letter word", currentWord.Length);
            Console.WriteLine("you have {0} lives", lives);

            displayWord = GenerateStarCharArray(currentWord.Length);


            while (lives > 0)  // while lives are more than 0, the code in these brackets will execute
            {
                number = 0;
                Console.WriteLine(" Guess a letter");
                Console.WriteLine(displayWord); // displays my hidden word.
                char letterGuessed = char.Parse(Console.ReadLine());

                for (int i = 0; i < currentWord.Length; i++) // checks to see if letter is in the array. 
                {                                            // and if it's contained also replaces the letter in displayword and also increses number +1
                    if (letterGuessed == currentWord[i])    //***********implement a DoLetterCheck method************
                    {
                        number = number + 1;
                        displayWord[i] = letterGuessed;
                    }
                }

                DisplayRoundFeedback(number);

                Console.WriteLine(displayWord); // displays my hidden word.
                lives = lives - 1;
            }

            Console.WriteLine("You are now out of lives!");

            Console.WriteLine("\t\t\t Welcome to my Hangman game, Good luck!");



        }

        private static void DisplayRoundFeedback(int number)
        {
            if (number > 0) //depeding on nubmer value , inform user if guess is correct
            {
                Console.WriteLine("This is an amazing guess ITS COOOOREEEECT!");
            }
            else
            {
                Console.WriteLine("That is the worst guess ever");
            }
        }

        static char[] GenerateStarCharArray(int numberOfStars)
        {
            char[] fullOfStars = new char[numberOfStars];

            for (int i = 0; i < numberOfStars; i++)  
            {
                fullOfStars[i] = '*';
            }

            return fullOfStars;
        }
    }
}

