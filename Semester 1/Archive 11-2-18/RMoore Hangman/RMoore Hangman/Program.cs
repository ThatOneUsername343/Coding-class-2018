using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace RMoore_Hangman
{
    class Program
    {
        static void Main(string[] args)
        {
            //Starting the game
            //int AllThoseTurns = 6;
            string[] Word = new string[20];

            //string HangmanWord;

            //Rules of the game
            Console.WriteLine("How to play Hangman:");
            Console.WriteLine("You will have a limited number of attempts to guess what the word is. Each time you get it wrong, you lose a turn, as");
            Console.WriteLine("well as several metric tons of self-esteem.");

            //All those dank words
            Word[0] = "dank memes";
            Word[1] = "gonna make me drop my croissant";
            Word[2] = "hello There";
            Word[3] = "why are you running";
            Word[4] = "what are thoooose";
            Word[5] = "deja vu";
            Word[6] = "ligma balls";
            Word[7] = "get shrekd";
            Word[8] = "wombo combo";
            Word[9] = "mom get the camera";
            Word[10] = "in me mums car";
            Word[11] = "gas gas gas";
            Word[12] = "its a piece of cake to bake a pretty cake";
            Word[13] = "we are number one";
            Word[14] = "hail lord tachanka";
            Word[15] = "oof";
            Word[16] = "wingardiem leviosaaaaaa";
            Word[17] = "smoke weed everyday";
            Word[18] = "spooky scary skeletons";
            Word[19] = "tunnel snakes rule";

            int LengthOfArray = Word.Length;
            Random Words = new Random();
            string Randomword = Word[Words.Next(0, 20)];
            char[] Letters = new char[Randomword.Length];
            List<char> GuessedLetters = new List<char>();
            bool YesIWon = false;

            //Happy Ending
            string[] HappyEnding = new string[10];
            Random RandHappyEnding = new Random();
            //All those dank happy endings
            HappyEnding[0] = "oh Oh OH MY GOD! GET NOSCOPED! GET NOSCOOOOOOOPED!";
            HappyEnding[1] = "HAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAX";
            HappyEnding[2] = "STOP USING AIMBOT";
            HappyEnding[3] = "DAMN SON, YOU JUST HIT WITH THE WOW EFFECT";
            HappyEnding[4] = "Relevant text.";
            HappyEnding[5] = "In the words of the Great Benjamin Franklin, 'Stop using aimbot.'";
            HappyEnding[6] = "'Vagita, what does the scouter say about his power level?'.... 'IT'S OVER 9-'";
            HappyEnding[7] = "Congradulations, you win. Congradulations, you win. Congradulations, you win. Congradulations, you win. Congradulations, you win. Congradulations, you win. Congradulations, you win. Congradulations, you win. Congradulations, you win. Congradulations, you win. Congradulations, you win. Congradulations, you win. Congradulations, you win. Congradulations, you win. Congradulations, you win. ";
            HappyEnding[8] = "Wow. Many guess. Very word. Wow. Such gud.";
            HappyEnding[9] = "*dabs*";
            string RandomHappyEnding = HappyEnding[RandHappyEnding.Next(0, 10)];



            //Sad Ending
            string[] SadEnding = new string[10];
            Random RandSadEnding = new Random();
            //All those dank sad endings
            SadEnding[0] = "-nd they ask you how you are, and you just have to say that you're fine, when you're not really fine, but you just can't get into it because they would never understand...";
            SadEnding[1] = "All around me are familiar faces, worn out places...";
            SadEnding[2] = "Mission failed! We'll get 'em next time.";
            SadEnding[3] = "F*ck this sh*t, I'm out";
            SadEnding[4] = "What the f*ck, Richard?!";
            SadEnding[5] = "Aw f*ck, I can't believe you've done this.";
            SadEnding[6] = "You have successfully FAILED. You cannot join FaZe team.";
            SadEnding[7] = "get gud.";
            SadEnding[8] = "It's not ogre, it's never ogre.";
            SadEnding[9] = "Go commit not alive.";
            string RandomSadEnding = SadEnding[RandSadEnding.Next(0, 10)];

            Console.WriteLine("This dank meme is " + Randomword.Length + " letters long.");
            Console.WriteLine("You have " + Letters.Length / 2 + " attempts to join FaZe team.");
            Console.WriteLine("Enter a letter you scrub.");
            for (int j = Letters.Length / 2; j != 0;)
            {


                YesIWon = true;
                Console.WriteLine();
                for (int i = 0; i < Letters.Length; i++)
                {
                    Letters[i] = '_';
                    
                }
                //Picking a random word
                char letter = char.Parse(Console.ReadLine());
                GuessedLetters.Add(letter);
                for (int i = 0; i < Letters.Length; i++)
                {
                    if (GuessedLetters.Contains(Randomword[i]))
                    {
                        Letters[i] = Randomword[i];
                    }
                    else
                    {
                        YesIWon = false;
                    }
                }

                for (int i = 0; i < Letters.Length; i++)
                {
                    Console.Write(Letters[i]);
                }

                //When a guess is right, it doesn't take away a turn
                if (Randomword.Contains(letter))
                {
                    Console.WriteLine();
                    Console.WriteLine("That is correct! 10 points to Griffindor!");
                }
                else
                {
                    j--;
                    Console.WriteLine();
                    Console.WriteLine("Wow. Are you even trying?");
                }
                Console.WriteLine("You have " + j + " guesses left you fedora wearing scrublord.");
                if (YesIWon == true)
                {
                    break;
                }
            }

            //Endings
            //Happy endings
            if (YesIWon == true)
            {
                Console.WriteLine();
                Console.WriteLine(RandomHappyEnding);
                Console.ReadKey();
            }

            //Sad endings
            else 
            {
                Console.WriteLine();
                Console.WriteLine(RandomSadEnding);
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"E:\Coding Assignments\RMoore Hangman\piano_man_1.wav");
                player.Play();
                Console.ReadKey();
            }
        }
    }
}