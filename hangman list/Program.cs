using System;
using System.Collections.Generic;

namespace hangman_list
{
    class Program
    {
        static void Main(string[] args)
        {
            // trying to use lists.
            //chose 10 different words that will be randomly generated hopefully.
            //string[] words = new string[10];
            //words[0] = "hello";
            //words[1] = "football";
            //words[2] = "england";
            //words[3] = "euros";
            //words[4] = "bitcoin";
            //words[5] = "bycicle";
            //words[6] = "hello";
            //words[7] = "bodybuilding";
            //words[8] = "cameron";
            //words[9] = "coding";


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

            Console.WriteLine("guess for a {0} letter word", currentWord.Length);
            Console.WriteLine("you have {0} lives", lives);

            for (int i = 0; i < currentWord.Length; i++)
            { //hides my word
                displayWord[i] = '*';
            }
            Console.WriteLine(displayWord);

            Console.WriteLine(" Guess a letter");
            char letterGuessed = Char.Parse(Console.ReadLine());













            //for (int i = 0; i < currentWord.Length + 2; i--)
            //{


            //    for (int j = 0; j < currentWord.Length; j++)
            //    {
            //        if (userLetter == currentWord[j])
            //        {
            //            Console.WriteLine(displayWord);
            //        }
            //        else
            //        {
            //            Console.WriteLine("sorry that guess was incorrect");
            //        }
            //    }
            //}
            //while (true)   //loops forever
            //{

            //    for (int k = 0; k < currentWord.Length; k++)
            //    {
            //        if (userLetter == currentWord[k])
            //            displayWord[k] = userLetter;     //if the guess is correct, set the character for the final output
            //        Console.WriteLine("That guess is correct!");
            //    }

            //    Console.WriteLine(displayWord);
            //}



            //char playerGuess = char.Parse(Console.ReadLine());
            //for (int k = 0; k < currentWord.Length; k++)  //loops for each letter in current word
            //{
            //    if (playerGuess == currentWord[k])  //currentword = abcde  / userletter is b
            //    {
            //        Console.Write(playerGuess);
            //    }
            //    else
            //    {
            //        Console.WriteLine("sorry that guess was incorrect");
            //    }

            //}

            //while (true)   //loops forever
            //{

            //    for (int k = 0; k < currentWord.Length; k++)
            //    {
            //        if (playerGuess == currentWord[k])
            //            displayWord[k] = playerGuess;     //if the guess is correct, set the character for the final output
            //        Console.WriteLine("That guess is correct!");
            //    }

            //    Console.WriteLine(displayWord);
            //}
        }
    }
}
