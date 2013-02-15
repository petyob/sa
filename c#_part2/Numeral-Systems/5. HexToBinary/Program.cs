using System;

class Program
//Write a program to convert hexadecimal numbers to binary numbers (directly).
{
    static void Main()
    {
        while (true)
        {
            string hexNumber = Console.ReadLine();
            Console.WriteLine(Convert.ToString(Convert.ToInt64(hexNumber, 16), 2));

            //Second Method
            string toBinary = HexToBin(hexNumber);
            Console.WriteLine(toBinary);           
        }    
    }

    private static string HexToBin(string hex)
    {
        string binary = string.Empty;
        hex = hex.ToLower();

        for (int i = 0; i < hex.Length; i++)
        {
            switch (hex[i])
            {
                case '0': binary += "0000"; break;
                case '1': binary += "0001"; break;
                case '2': binary += "0010"; break;
                case '3': binary += "0011"; break;
                case '4': binary += "0100"; break;
                case '5': binary += "0101"; break;
                case '6': binary += "0110"; break;
                case '7': binary += "0111"; break;
                case '8': binary += "1000"; break;
                case '9': binary += "1001"; break;
                case 'a': binary += "1010"; break;
                case 'b': binary += "1011"; break;
                case 'c': binary += "1100"; break;
                case 'd': binary += "1101"; break;
                case 'e': binary += "1110"; break;
                case 'f': binary += "1111"; break;
                default: throw new ArgumentException("Invalid hex simbol!"); 
            }
        }

        return binary.TrimStart('0');
    }
}

