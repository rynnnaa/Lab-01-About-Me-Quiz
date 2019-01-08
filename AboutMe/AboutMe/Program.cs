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

            //Console.WriteLine("Can I swim?");
            //string canISwim = Console.ReadLine();

            //Console.WriteLine("What is my favorite candy?");
            //string candy = Console.ReadLine();

            //Console.WriteLine("How many sisters do I have?");
            //string sister = Console.ReadLine();
            //int sisterGuess = Convert.ToInt32(sister);
            //SisterAnswer(sisterGuess);

            //Console.WriteLine("What's my favorite movie genre?");
            //string movieGenre = Console.ReadLine();
        }

        static void ParrotAnswer(string parrot)
        {
            if (parrot == "yes")
            {
                string incorrectMessage = "Sorry, you got that incorrect.";
                Console.Write(incorrectMessage);
            }
            else if (parrot == "no")
            {
                string correctMessage = "Ding Ding! You got that correct!";
                Console.Write(correctMessage);
            }
            else
            {
                string dontComprehend = "Sorry, you did not enter the correct value.";
                Console.Write(dontComprehend);
             }


        //static void SisterAnswer(int sisterGuess)
        //    {
        //        if 
        //    }
               
        } 
    }
}
