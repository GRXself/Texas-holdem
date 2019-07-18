using System;
using TexasHoldEm.Models;

namespace TexasHoldEm.Outputter
{
    public static class TexasGameResultOutputter
    {
        public static void GetConsoleOutput(TexasGameResult texasGameResult)
        {
            const string commonPartialWinString = " wins - ";

            const string commonTieString = "Tie";
            
            if (string.IsNullOrEmpty(texasGameResult.WinnerName))
            {
                Console.WriteLine(commonTieString);
                return;
            }

            var commonWinString = texasGameResult.WinnerName + commonPartialWinString + texasGameResult.WinLevel;
            if (string.IsNullOrEmpty(texasGameResult.WinCard))
            {
                Console.WriteLine(commonWinString);
            }
            else
            {
                Console.WriteLine(commonWinString + ": " + texasGameResult.WinCard);
            }
        }
    }
}