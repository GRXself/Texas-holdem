using System;
using TexasHoldem.Models;

namespace TexasHoldem.Formatter
{
    public class CardsOrderFormatter
    {
        public void DescendCardsOrder(HandCard[] handCard)
        {
            for (int i = 0; i < handCard.Length; i++)
            {
                DescendCardsOrder(handCard[i]);
            }
        }

        public void DescendCardsOrder(HandCard handCard)
        {
            MapStringToInt(handCard);
            Array.Sort(handCard.CardValues);
        }

        private void MapStringToInt(HandCard handCard)
        {
            int[] cardValues = new int[handCard.Cards.Length];
            for (int i = 0; i < cardValues.Length; i++)
            {
                string currentValue = handCard.Cards[i].Substring(0, 1);
                if (!Int32.TryParse(currentValue, out cardValues[i]))
                {
                    switch (currentValue)
                    {
                        case "T":
                            cardValues[i] = 10;
                            break;
                        case "J":
                            cardValues[i] = 11;
                            break;
                        case "Q":
                            cardValues[i] = 12;
                            break;
                        case "K":
                            cardValues[i] = 13;
                            break;
                        case "A":
                            cardValues[i] = 14;
                            break;
                    }
                }
            }
            handCard.CardValues = cardValues;
        }
    }
}