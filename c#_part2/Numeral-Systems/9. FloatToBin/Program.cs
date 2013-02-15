using System;
using System.Text;


class Program
//Write a program that shows the internal binary representation of given 32-bit signed floating-point number
//in IEEE 754 format (the C# type float).
//Example: -27,25  sign = 1, exponent = 10000011, mantissa = 10110100000000000000000.
{
    static void Main()
    {
        while (true)
        {
            //float number = -27.25f;
            float number = float.Parse(Console.ReadLine());

            string binaryNumber = FloatToBinary(number);

            Console.WriteLine("Binary: " + binaryNumber);
            Console.WriteLine("Sign: " + binaryNumber[0]);
            Console.WriteLine("Exponent: " + binaryNumber.Substring(1, 8));
            Console.WriteLine("Mantissa: " + binaryNumber.Substring(9));
        }
    }

    static string FloatToBinary(float number)
    {
        string binNumber = string.Empty;

        byte[] Bytes = BitConverter.GetBytes(number);
        
        foreach (var item in Bytes)
        {
            binNumber = ByteToBin(item) + binNumber;
        }

        return binNumber;

    }

    static string ByteToBin(byte number)
    {
        StringBuilder binNumber = new StringBuilder();

        for (byte i = 0; i < 8; i++) // Get 8 bits
        {
            byte bit = (byte)((number >> i) & 1);
            binNumber.Insert(0, bit);
        }

        return binNumber.ToString();
    }
}

