using System;

namespace Decisions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nashi's Surprise Boxes");
            Console.Write("Choose a box: 1, 2 or 3: ");
            string userValue = Console.ReadLine();

            string message = "";

            if (userValue == "2")
                message = "You won the first prize!";
            else if (userValue == "1")
                message = "You won the second prize!";
            else if (userValue == "3")
                message = "You won the third prize!";
            else if (userValue == "4")
                message = "Nice try. You win nothing.";
            else if (userValue == "a box")
                message = "Thinking outside the box, my compliments";
            else if (userValue == "a")
                message = "Thinking outside the box. Clever!";
            else if (userValue == "333")
                message = "God is busy with the Corona Epidemic";
            else if (userValue == "666")
                message = "Selling your soul might work, but is it really worth it?";
            else
            {
                message = "I'll give you points for trying. ";
                //message = message + "However, you still lose.";
                message += "However, you still lose.";
            }

            Console.WriteLine(message);
            Console.ReadLine();

            /* Console.WriteLine("Nashi's Big Givaway);
             * Console.Write("Choose a box: 1, 2 of 3: ");
             * string userValue = Console.ReadLine();
             * 
             * string message = (userValue == "2") ? "a prize, subscribe to find out what" : "absolutely nothing";
             * 
             * //Console.Write("You won ");
             * //Console.Write(message);
             * //Console.Write(".");
             * 
             * //Console.WriteLine("You won {0}.", message);
             * Console.WriteLine("You answered: {0}, therefore you won {1}.", userValue, message);
             * 
             * Console.ReadLine();
            */
        }
    }
}
