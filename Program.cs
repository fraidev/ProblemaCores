using System;

namespace ProblemaCores
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var blueWhiteRed = 100;


            while (true)
            {
                var blue = blueWhiteRed.ToString()[0];
                var white = blueWhiteRed.ToString()[1];
                var red = blueWhiteRed.ToString()[2];

                var result = blueWhiteRed * 3;

                if (result.ToString()[0] == red && result.ToString()[1] == red && result.ToString()[2] == red)
                {
                    break;
                }

                blueWhiteRed++;
            }


            Console.WriteLine("blueWhiteRed is " + blueWhiteRed);
            Console.WriteLine("Red is " + blueWhiteRed.ToString()[2]);
            Console.WriteLine("Result is " + blueWhiteRed * 3);
        }
    }
}
