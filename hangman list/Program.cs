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
            bool correctLetter = true;

            // moved this code from the while loop so it doesnt repeat itself
            for (int i = 0; i < currentWord.Length; i++)
            { //hides my word
                displayWord[i] = '*';
            }
            while (lives > 0) // while lives are more than 0, the code in these brackets will execute
            {

                Console.WriteLine(" Guess a letter");
                Console.WriteLine(displayWord); // displays my hidden word.
                char letterGuessed = char.Parse(Console.ReadLine());// checks to see if letter is in the array.
                for (int i = 0; i < currentWord.Length; i++)

                    if (letterGuessed == currentWord[i])
                        if (correctLetter)
                        {
                            //Console.WriteLine(displayWord[i]);
                            displayWord[i] = letterGuessed;     //if the guess is correct, set the character for the final output
                            Console.WriteLine("That is a correct guess");

                        }

                        else
                        {
                            Console.WriteLine("Sorry that guess was incorrect");
                        }


                Console.WriteLine(displayWord);
            }

            //    if (!correctLetter)
            //{

            //}
            //
            //if (lives <= 0)
            //    Console.WriteLine("End of game");





            //loops forever


            //    for (int j = 0; j < currentWord.Length; j++)
            //    {
            //        if (letterGuessed == currentWord[j])
            //            displayWord[j] = letterGuessed;     //if the guess is correct, set the character for the final output
            //        Console.WriteLine("That guess is correct!")
            //            else
            //        {
            //            Console.WriteLine("Sorry that guess was incorrect");
            //        }
            //    }

            //Console.WriteLine(displayWord);




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
