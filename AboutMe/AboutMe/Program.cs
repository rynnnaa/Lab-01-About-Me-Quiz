using System;

namespace AboutMe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How well do you know me? ");

            Console.WriteLine("Do I have a pet parrot? ");
            string parrot = Console.ReadLine();
            string caseParrot = parrot.ToUpper();
            ParrotAnswer(caseParrot);

            Console.WriteLine("Can I swim? ");
            string canISwim = Console.ReadLine();
            string caseSwim = canISwim.ToUpper();
            SwimAnswer(canISwim);

            Console.WriteLine("What is my favorite candy? ");
            string candy = Console.ReadLine();
            string caseCandy = candy.ToUpper();
            CandyAnswer(caseCandy);

            Console.WriteLine("How many sisters do I have? ");
            string sister = Console.ReadLine();
            int sisterGuess = Convert.ToInt32(sister);
            SisterAnswer(sisterGuess);

            Console.WriteLine("My favorite movie genre is Fantasy. True or False? ");
            string movieGenre = Console.ReadLine();
            string caseMovie = movieGenre.ToUpper();
            MovieGenreAnswer(caseMovie);
        }

        static void ParrotAnswer(string caseParrot)
        {
            if (caseParrot == "yes")
            {
                string incorrectMessage = "Sorry, you got that incorrect.";
                Console.WriteLine(incorrectMessage);
            }
            else 
            {
                string correctMessage = "Ding Ding! You got that correct!";
                Console.WriteLine(correctMessage);
            }
        }

        static void SwimAnswer(string caseSwim)
        {
            if (caseSwim == "yes")
            {
                string incorrectMessage = "Sorry, you got that incorrect.";
                Console.WriteLine(incorrectMessage);
            }
            else if (caseSwim == "no")
            {
                string correctMessage = "Ding Ding! You got that correct!";
                Console.WriteLine(correctMessage);
            }
            else
            {
                string dontComprehend = "Sorry, you did not enter the correct value.";
                Console.WriteLine(dontComprehend);
            }
        }

        static void CandyAnswer(string caseCandy)
        {
            if (caseCandy == "chocolate")
            {
                string correctMessage = "Correct.";
                Console.WriteLine(correctMessage);
            }
            else
            {
                string inCorrectMessage = "That is incorrect";
                Console.WriteLine(inCorrectMessage);
            }
        }

        static int SisterAnswer(int sisterGuess)
        {
            try
            {
                int correctGuess = 1;
                if (sisterGuess == 1)
                {
                    string correctMessage = "That's correct!";
                    Console.WriteLine(correctMessage);
                    return correctGuess;
                }
                else
                {
                    string incorrectMessage = "That is incorrect!";
                    Console.WriteLine(incorrectMessage);
                    return correctGuess;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Incorrect Format");
            }
            return 0;
        }

        static bool MovieGenreAnswer(string caseMovie)
        {
            if (caseMovie == "true")
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