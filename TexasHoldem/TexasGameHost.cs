using System;
using TexasHoldEm.Comparer;
using TexasHoldEm.Models;
using TexasHoldEm.Outputter;

namespace TexasHoldEm
{
    public static class TexasGameHost
    {
        public static void TexasGameRun()
        {
            // Initial Player and their hand cards
            var blackPlayer = new TexasHoldEmPlayer("Black");
            Console.WriteLine($"Please enter {blackPlayer.Name} player's cards: ");
            blackPlayer.HandCards = new HandCards(Console.ReadLine());
            
            var whitePlayer = new TexasHoldEmPlayer("White");
            Console.WriteLine($"Please enter {whitePlayer.Name} player's cards: ");
            whitePlayer.HandCards = new HandCards(Console.ReadLine());

            // Compare cards
            var texasGameResult = new TexasGameComparer().CompareHandCards(blackPlayer, whitePlayer);
            TexasGameResultOutputter.GetConsoleOutput(texasGameResult);
        }
    }
}