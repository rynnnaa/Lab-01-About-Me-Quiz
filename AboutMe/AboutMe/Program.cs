using System;

namespace AboutMe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How well do you know me?");

            Console.Write("Do I have a pet parrot?");
            string parrot = Console.ReadLine();
            string caseParrot = parrot.ToUpper();
            ParrotAnswer(caseParrot);

            Console.WriteLine("Can I swim?");
            string canISwim = Console.ReadLine();
            SwimAnswer(canISwim);

            Console.WriteLine("What is my favorite candy?");
            string candy = Console.ReadLine();
            CandyAnswer(candy);

            Console.WriteLine("How many sisters do I have?");
            string sister = Console.ReadLine();
            int sisterGuess = Convert.ToInt32(sister);
            SisterAnswer(sisterGuess);

            Console.WriteLine("My favorite movie genre is Fantasy. True or False? ");
            string movieGenre = Console.ReadLine();
            MovieGenreAnswer(movieGenre);

        }

        static void ParrotAnswer(string caseParrot)
        {
            if (caseParrot == "yes")
            {
                string incorrectMessage = "Sorry, you got that incorrect.";
                Console.Write(incorrectMessage);
            }
            else if (caseParrot == "no")
            {
                string correctMessage = "Ding Ding! You got that correct!";
                Console.Write(correctMessage);
            }
            else
            {
                string dontComprehend = "Sorry, you did not enter the correct value.";
                Console.Write(dontComprehend);
            }
        }

        static void SwimAnswer(string canISwim)
        {
            if (canISwim == "yes")
            {
                string incorrectMessage = "Sorry, you got that incorrect.";
                Console.Write(incorrectMessage);
            }
            else if (canISwim == "no")
            {
                string correctMessage = "Ding Ding! You got that correct!";
                Console.Write(correctMessage);
            }
            else
            {
                string dontComprehend = "Sorry, you did not enter the correct value.";
                Console.Write(dontComprehend);
            }
        }

        static void CandyAnswer(string candy)
        {
            if (candy == "chocolate")
            {
                string incorrectMessage = "Sorry, you got that incorrect.";
                Console.Write(incorrectMessage);
            }
            else if (candy == "no")
            {
                string correctMessage = "Ding Ding! You got that correct!";
                Console.Write(correctMessage);
            }
            else
            {
                string dontComprehend = "Sorry, you did not enter the correct value.";
                Console.Write(dontComprehend);
            }
        }

        static int SisterAnswer(int sisterGuess)
        {
            int correctGuess = 1;
            if (sisterGuess == 1)
            {
                string correctMessage = "That's correct!";
                Console.Write(correctMessage);
                return correctGuess;
            }
            else
            {
                string incorrectMessage = "That is incorrect!";
                Console.Write(incorrectMessage);
                return correctGuess;
            }
        }

        static bool MovieGenreAnswer(string movieGenre)
        {
        if (movieGenre == "true")
            {
                Console.WriteLine("Nope.");
                return false;
            }
        else
            {
                Console.WriteLine("Yes");
                return true;
   
            }
        } 
    }
}
