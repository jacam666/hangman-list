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
            List<string> wordsList = new List<string>();

            wordsList.Add("hello");
            wordsList.Add("football");
            wordsList.Add("england");
            wordsList.Add("bitcoin");
            wordsList.Add("bodybuilding");
            wordsList.Add("cameron");

            Console.WriteLine("\t\t\t Welcome to my Hangman game, Good luck!");

            //activating my random word
            Random rng = new Random();

            int rndWordIndex = rng.Next(0, wordsList.Count);   //warning! magic number ?!?!

            char[] currentWord = wordsList[rndWordIndex].ToCharArray();

            char[] displayWord = new char[currentWord.Length];
            int lives = currentWord.Length + 2;
            int number = 0;
            
            Console.WriteLine("guess for a {0} letter word", currentWord.Length);
            Console.WriteLine("you have {0} lives", lives);
            
            // moved this code from the while loop so it doesnt repeat itself
            for (int i = 0; i < currentWord.Length; i++)
            { //hides my word
                displayWord[i] = '*';
            }
            while (lives > 0) // while lives are more than 0, the code in these brackets will execute
            {
                number = 0;
                Console.WriteLine(" Guess a letter");
                Console.WriteLine(displayWord); // displays my hidden word.
                char letterGuessed = char.Parse(Console.ReadLine());// checks to see if letter is in the array.
                for (int i = 0; i < currentWord.Length; i++)
                {
                    if (letterGuessed == currentWord[i])
                    {
                        number = number + 1;
                        displayWord[i] = letterGuessed;
                    }        
                }
                if (number >0)
                {
                    Console.WriteLine("This is an amazing guess ITS COOOOREEEECT!");
                }
                else
                {
                    Console.WriteLine("That is the worst guess ever");
                }
                Console.WriteLine(displayWord);
                lives = lives - 1;
            }Console.WriteLine("You are now out of lives!");
















                //{
                //    if (letterGuessed == currentWord[i])
                //    {
                //        if (correctLetter)
                //        {
                //            //Console.WriteLine(displayWord[i]);
                //            displayWord[i] = letterGuessed;     //if the guess is correct, set the character for the final output
                //        }
                //        else
                //        {
                //            Console.WriteLine("Sorry that guess was incorrect");
                //        }
                //    }
                //}Console.WriteLine("That is a correct guess");









        }
    }
}

