using System;
using System.Collections.Generic;
using System.Text;

namespace PickACardUI
{
    internal class CardPicker
    {
        static Random random = new Random();

        public static string[] PickSomeCards(int numCards)
        {
            string[] pickedCards = new string[numCards];

            for (int i = 0; i < numCards; i++)
            {
                pickedCards[i] = RandomValue() + " of " + RandomSuit();
            }

            return pickedCards;
        }

        private static string RandomSuit()
        {
            // returns a value between the specified range, 1 - 4 only not 5
            int value = random.Next(1,5);
            if (value == 1) return "Spades";
            if (value == 2) return "Hearts";
            if (value == 3) return "Clubs";
            return "Diamonds";
        }

        private static string RandomValue()
        {
            int value = random.Next(1,14);
            if (value == 1) return "Ace";
            if (value == 11) return "Jack";
            if (value == 12) return "Queen";
            if (value == 13) return "King";

            return value.ToString(); // Set the int value to string value
        }
    }
}
