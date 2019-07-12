using System;
using System.Collections.Generic;
using TexasHoldEm.Models;

namespace TexasHoldEm.Level
{
    public abstract class TexasHoldEmHandCardLevel : IComparable<TexasHoldEmHandCardLevel>
    {
        public string Name { get; protected set; }
        public int Value { get; protected set; }

        protected TexasHoldEmHandCardLevel()
        {
            Initializer();
        }

        protected abstract void Initializer();
        public abstract bool IsThisLevel(List<PokerCard> cards);

        public int CompareTo(TexasHoldEmHandCardLevel other)
        {
            return Value.CompareTo(other.Value);
        }

        public abstract void SameLevelCompare(
            TexasHoldEmPlayer blackPlayer, 
            TexasHoldEmPlayer whitePlayer,
            TexasGameResult texasGameResult);

        public override bool Equals(object obj)
        {
            return obj is TexasHoldEmHandCardLevel level && Value.Equals(level.Value);
        }
    }
}