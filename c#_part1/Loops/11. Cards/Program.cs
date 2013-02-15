using System;

namespace _11.Cards
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] suits = new string[4]
            {
                "clubs", "diamonds", "hearts", "spades"
            };

           
            for (int currentCard = 2; currentCard <= 14; currentCard++)
            {
                string card = "";
                switch (currentCard)
                {
                    case 2: card = "Two"; break;
                    case 3: card = "Three"; break;
                    case 4: card = "Four"; break;
                    case 5: card = "Five"; break;
                    case 6: card = "Six"; break;
                    case 7: card = "Seven"; break;
                    case 8: card = "Eight"; break;
                    case 9: card = "Nine"; break;
                    case 10: card = "Ten"; break;
                    case 11: card = "Jack"; break;
                    case 12: card = "Queen"; break;
                    case 13: card = "King"; break;
                    case 14: card = "Ace"; break;
                    default: break;

                }

                card = card + " of ";

                foreach (string suit in suits)
                {
                    Console.Write("{0,20}", card + suit);
                                  
                }

                Console.WriteLine();
            }
        }
    }
}
