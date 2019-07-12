using System;
using TexasHoldEm.Models;

namespace TexasHoldEm.Outputter
{
    public static class TexasGameResultOutputter
    {
        public static void GetConsoleOutput(TexasGameResult texasGameResult)
        {
            const string commonWinString = " wins - ";
            
            if (texasGameResult.IsTie)
            {
                Console.WriteLine("Tie");
                return;
            }

            if (string.IsNullOrEmpty(texasGameResult.WinCard))
            {
                Console.WriteLine(texasGameResult.WinnerName + commonWinString + texasGameResult.WinLevel);
            }
            else
            {
                Console.WriteLine(texasGameResult.WinnerName + commonWinString + texasGameResult.WinLevel + ": " + texasGameResult.WinCard);
            }
        }
    }
}