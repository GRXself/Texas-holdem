using System;
using TexasHoldEm.Level.Condition;
using TexasHoldEm.Models;

namespace TexasHoldEm
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            //TexasGameHost.TexasGameRun();
            var hcs = new HandCards("2H 3D 5S 9C KD");
            Console.WriteLine(new SameColorConditionChecker().IsThisCondition(hcs.Cards));
        }
    }
}
