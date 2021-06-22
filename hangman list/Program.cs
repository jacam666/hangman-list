using System;

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
            words[6] = "trivia";
            words[7] = "bodybuilding";
            words[8] = "cameron";
            words[9] = "coding";

            //activating my random word
            Random rng = new Random();
            int rndWordIndex = rng.Next(0, 10);

            char[] currentWord = words[rndWordIndex].ToCharArray();

            char[] displayWord = new char[currentWord.Length];

            for (int i = 0; i < currentWord.Length; i++)
            { //hides my word
                displayWord[i] = '*';
            }
            Console.WriteLine(displayWord);

            Console.WriteLine(" Guess a letter");
            char userLetter = Char.Parse(Console.ReadLine());

            char[] guess = new char[currentWord.Length];
            for (int i = 0; i < currentWord.Length; i++)
            {
                if (userLetter == currentWord[i])
                {
                    Console.Write(userLetter);
                }
                else
                {
                    Console.WriteLine("sorry that guess was incorrect");
                }
                
                while (true)
                {
                    char playerGuess = char.Parse(Console.ReadLine());
                    for (int j = 0; j < currentWord.Length; j++)
                    {
                        if (playerGuess == currentWord[j])
                            guess[j] = playerGuess;
                    }
                    Console.WriteLine(guess);
                }
            }
        }
    }
}
