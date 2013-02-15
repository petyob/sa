using System;

//prints the first 10 members of the sequence: 2, -3, 4, -5, 6, -7, ...
class Sequence
{
    static void Main()
    {
        int sign = 1;
        for (int i = 2; i <= 11; i++)
        {
            Console.WriteLine(sign * i);
            sign = sign * (-1); //alternate sign for the next member.
        }
    }
}

