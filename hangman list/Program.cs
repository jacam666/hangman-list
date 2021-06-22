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
            string[] words = new string[10];
            words[0] = "hello";
            words[1] = "football";
            words[2] = "england";
            words[3] = "euros";
            words[4] = "bitcoin";
            words[5] = "bycicle";
            words[6] = "hello";
            words[7] = "bodybuilding";
            words[8] = "cameron";
            words[9] = "coding";


            List<string> wordsList = new List<string>();

            wordsList.Add("hello");
            wordsList.Add("second string");
            wordsList.Add("third thing");
            wordsList.Add("hello");
            wordsList.Add("second string");
            wordsList.Add("third thing");


            Console.WriteLine(wordsList.Count);

            //activating my random word
            Random rng = new Random();

            int rndWordIndex = rng.Next(0, words.Length);   //warning! magic number ?!?!

            char[] currentWord = words[rndWordIndex].ToCharArray();

            char[] displayWord = new char[currentWord.Length];

            for (int i = 0; i < currentWord.Length; i++)
            { //hides my word
                displayWord[i] = '*';
            }
            Console.WriteLine(displayWord);

            Console.WriteLine(" Guess a letter");
            char userLetter = Char.Parse(Console.ReadLine());

            char[] finalOutput = new char[currentWord.Length];  //whats your intention there?


            for (int i = 0; i < currentWord.Length; i++)  //loops for each letter in current word
            {
                if (userLetter == currentWord[i])  //currentword = abcde  / userletter is b
                {
                    Console.Write(userLetter);
                }
                else
                {
                    Console.WriteLine("sorry that guess was incorrect");
                }
                
                while (true)   //loops forever
                {
                    char playerGuess = char.Parse(Console.ReadLine());
                    for (int j = 0; j < currentWord.Length; j++)
                    {
                        if (playerGuess == currentWord[j])
                            finalOutput[j] = playerGuess;     //if the guess is correct, set the character for the final output
                    }
                    Console.WriteLine(finalOutput);
                }
            }
        }
    }
}
