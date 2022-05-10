using System;

namespace CatsAndDogs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Are you more like a cat or dog?");
            string UserChoice = Console.ReadLine().ToUpper();

            if (UserChoice == "CAT")
            {
                Console.WriteLine("You are a home-lover");
            }
            else if (UserChoice == "DOG")
            {
                Console.WriteLine("You are a partygoer");
            }
            else
            {
                Console.WriteLine($"You are a friend");
            }    
        }
    }
}
