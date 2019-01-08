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
            ParrotAnswer(parrot);

            Console.WriteLine("Can I swim?");
            string canISwim = Console.ReadLine();

            Console.WriteLine("What is my favorite candy?");
            string candy = Console.ReadLine();

            Console.WriteLine("How many sisters do I have?");
            string sister = Console.ReadLine();
            int sisterGuess = Convert.ToInt32(sister);
            SisterAnswer(sisterGuess);

            Console.WriteLine("What's my favorite movie genre?");
            string movieGenre = Console.ReadLine();
        }

        static string ParrotAnswer(string parrot)
        {
            if ParrotAnswer = yes
                Console.Write("Sorry, you got that incorrect.");

        }

        static void SisterAnswer(int sisterGuess);

    }
}
