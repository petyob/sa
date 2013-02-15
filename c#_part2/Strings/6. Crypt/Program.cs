using System;
using System.Text;

//Write a program that encodes and decodes a string using given encryption key (cipher).
//The key consists of a sequence of characters. The encoding/decoding is done by 
//performing XOR (exclusive or) operation over the first letter of the string with the first of the key, 
//the second – with the second, etc. When the last key character is reached, the next is the first.
class Program
{
    static void Main()
    {
        while (true)
        {
            string cipher = "Dqwv43&%ktyr";
            string text = Console.ReadLine();
            string encrypted = Crypto.Encode(text, cipher);
            string decrypted = Crypto.Decode(encrypted, cipher); // Only encrypted text suppouse to be decrypted
            Console.WriteLine(encrypted);
            Console.WriteLine(decrypted);  
        }
    }
    class Crypto
    {
        public static string Encode(string text, string cipher)
        {
            StringBuilder encryptedText = new StringBuilder(text.Length);
            for (int i = 0; i < text.Length; i++)
            {
                encryptedText.Append((char)(text[i] ^ cipher[i % cipher.Length]));
            }

            return encryptedText.ToString();
        }

        public static string Decode(string text, string cipher)
        {
            return Encode(text, cipher);  // Decode == Encode
        }

    }

}

