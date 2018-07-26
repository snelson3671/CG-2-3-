using System;

namespace CG_2_3_ThreeStringsIntoOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let's combine Three strings into one");
            Console.Write("Please type your full name ");
            String myName = Console.ReadLine();

            Console.Write("What's your favorite color? ");
            String color = Console.ReadLine();

            Console.Write("Who is your best friend? ");
            String bestFriend = Console.ReadLine();

            Console.WriteLine("Hi! My name is " + myName + ".  " + "My favorite color is " + color + ".  " + "My best friend is " + bestFriend);
            Console.ReadLine();
        }
    }
}
