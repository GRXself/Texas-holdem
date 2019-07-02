using System;
using TexasHoldem.Comparer;
using TexasHoldem.Core;
using TexasHoldem.Formatter;
using TexasHoldem.Inputs;
using TexasHoldem.Level;
using TexasHoldem.Models;

namespace TexasHoldem
{
    class Program
    {
        static void Main(string[] args)
        {
            // Get HandCards
            SourceInfoTransfer sourceInfoTransfer = new SourceInfoTransfer();
            HandCard[] handCards = new HandCard[2];
            for (int i = 0; i < 2; i++)
            {
                int currentPlayer;
                string currentPlayerName;
                if (i == 0)
                {
                    currentPlayer = Players.Black;
                    currentPlayerName = nameof(Players.Black);
                }
                else
                {
                    currentPlayer = Players.White;
                    currentPlayerName = nameof(Players.White);
                }
                Console.WriteLine("Please enter " + currentPlayerName + " player's cards: ");
                string sourceString = Console.ReadLine();
                handCards[currentPlayer] = sourceInfoTransfer.GetHandCards(sourceString);
            }

            // DescendCardOrder
            CardsOrderFormatter cardsOrderFormatter = new CardsOrderFormatter();
            cardsOrderFormatter.DescendCardsOrder(handCards);

            // Judge Cards Level
            LevelJudger levelJudger = new LevelJudger();
            levelJudger.JudgeLevel(handCards);

            // Compare cards
            CardsComparer cardsComparer = new CardsComparer();
            Console.WriteLine(cardsComparer.CompareCards(handCards));
        }
    }
}
