using System;
using TexasHoldem.Comparer;
using TexasHoldem.Inputs;
using TexasHoldem.Level;
using TexasHoldem.Models;

namespace TexasHoldem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter you cards: ");

            // Get HandCards
            string sourceString = Console.ReadLine();
            SourceInfoTransfer sourceInfoTransfer = new SourceInfoTransfer();
            HandCard[] handCards = sourceInfoTransfer.GetHandCards(sourceString);
            
            // Judge Cards Level
            LevelJudger levelJudger = new LevelJudger();
            levelJudger.JudgeLevel(handCards);

            // Compare cards
            CardsComparer cardsComparer = new CardsComparer();
            Console.WriteLine(cardsComparer.CompareCards(handCards));
        }
    }
}
