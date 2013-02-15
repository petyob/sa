using System;


namespace _9.CheckPoint
{
    // Expression that checks for given point (x, y) if it is within the circle K( (1,1), 3) and out of the rectangle R(top=1, left=-1, width=6, height=2).
    class Program
    {
        static void Main(string[] args)
        {
            double x, y;

            Console.WriteLine("X coordinate: ");

            bool isNumber = double.TryParse(Console.ReadLine(), out x);

            if (!isNumber)
            {
                Console.WriteLine("Number requared!");

            }
            Console.WriteLine("Y coordinate: ");

            isNumber = double.TryParse(Console.ReadLine(), out y);

            if (!isNumber)
            {
                Console.WriteLine("Number requared!");

            }

            double d = Math.Sqrt((x -1)* (x -1)+ (y-1) * (y-1)); // Distance between (x,y) and (1,1)

            if (d > 3)
            {
                Console.WriteLine("Out of the circl");
            }
            else
            {
                Console.WriteLine("In the circle");
            }

            bool isOutOfTheRectangle;
            if ((x > -1) && (x < 5) && (y < 1) && (y > -1))
            {
                isOutOfTheRectangle = false;
            }
            else
            {
                isOutOfTheRectangle = true;
            }
            if (isOutOfTheRectangle)
            {
                Console.WriteLine("Out Of The Rectangle");
            }
            else
            {
                Console.WriteLine("In The Rectangle");
            }
        }
    }
}
