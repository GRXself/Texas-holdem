using TexasHoldem.Core;
using TexasHoldem.Models;

namespace TexasHoldem.Inputs
{
    public class SourceInfoTransfer
    {
        public HandCard GetHandCards(string inputString)
        {
            HandCard handCard = new HandCard();
            handCard.Cards = inputString.Trim().Split(" ");
            return handCard;
        }
    }
}