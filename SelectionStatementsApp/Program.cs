using System;

namespace SelectionStatementsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //var r = new Random();
            //var favNumber = r.Next(1, 100);

            Console.WriteLine("What number and I thinking about?");
            var GuessNumber = int.Parse(Console.ReadLine());


            if (GuessNumber == 77)
            {
                Console.WriteLine($"You are correct! - Amazing Job!");
            }

            else if (GuessNumber >= 78)
            {
                Console.WriteLine($"You are too high - try again.");
            }

            else
            {
                Console.WriteLine($"You are too low - try again.");
            }
            /////////////////////////////////////////////////////
            Console.WriteLine("Pick a number from 1 - 7 to see which color of the rainbow and virtue fits you best?");
            var RainColor = int.Parse(Console.ReadLine());

            switch (RainColor)
            {
                case 1:
                    Console.WriteLine("Red - You are filled with love.");
                    break;
                case 2:
                    Console.WriteLine("Yellow - You are filled with hope.");
                    break;
                case 3:
                    Console.WriteLine("Orange - You are filled with prudence.");
                    break;
                case 4:
                    Console.WriteLine("Green - You are filled with charity.");
                    break;
                case 5:
                    Console.WriteLine("Blue - You are filled with temperance.");
                    break;
                case 6:
                    Console.WriteLine("Violet - You are filled with fortitude.");
                    break;
                case 7:
                    Console.WriteLine("Indigo - You are filled with patience.");
                    break;
                default:
                    Console.WriteLine("Really Dude? Picking a number between 1 and 7 is NOT that hard.");
                    break;
            }


        }
    }
}
