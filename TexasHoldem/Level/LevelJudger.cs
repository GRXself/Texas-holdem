using TexasHoldem.Core;
using TexasHoldem.Models;

namespace TexasHoldem.Level
{
    public class LevelJudger
    {
        public void JudgeLevel(HandCard[] handcards)
        {
            for (int i = 0; i < handcards.Length; i++)
            {
                JudgeLevel(handcards[i]);
            }
        }

        public void JudgeLevel(HandCard handcard)
        {
            // Check is same in color
            if (IsSameColor(handcard.Cards))
            {
                handcard.Level = Levels.Flush;
            }

            // Check card value
            int[] cardValues = handcard.CardValues;
            if (IsStraight(cardValues))
            {
                if (handcard.Level == Levels.Flush)
                {
                    handcard.Level = Levels.StraightFlush;
                    return;
                }
                else
                {
                    handcard.Level = Levels.Straight;
                    return;
                }
            }
            else
            {
                if (handcard.Level == Levels.Flush)
                {
                    return;
                }
                else
                {
                    int maxCombo = MaxCombo(cardValues);
                    if (maxCombo == 4)
                    {
                        handcard.Level = Levels.FourOfAKind;
                        return;
                    }
                    else if (maxCombo == 3)
                    {
                        if (IsFullHouse(cardValues))
                        {
                            handcard.Level = Levels.FullHouse;
                            return;
                        }
                        else
                        {
                            handcard.Level = Levels.ThreeOfAKind;
                            return;
                        }
                    }
                    else if (maxCombo == 2)
                    {
                        int pairCount = PairCount(cardValues);
                        if (pairCount == 2)
                        {
                            handcard.Level = Levels.TwoPairs;
                            return;
                        }
                        else
                        {
                            handcard.Level = Levels.Pair;
                            return;
                        }
                    }
                    else
                    {
                        handcard.Level = Levels.HighCard;
                        return;
                    }
                }
            }
        }

        private bool IsSameColor(string[] cards)
        {
            string s = cards[0].Substring(1);
            for (int i = 1; i < cards.Length; i++)
            {
                if (!s.Contains(cards[i].Substring(1)))
                {
                    return false;
                }
            }
            return true;
        }

        private bool IsStraight(int[] cardValues)
        {
            for (int i = 0; i < cardValues.Length - 1; i++)
            {
                if (!(cardValues[i] == cardValues[i + 1] - 1))
                {
                    return false;
                }
            }
            return true;
        }

        private int MaxCombo(int[] cardValues)
        {
            int maxCombo = 1;
            int currentCombo = 1;
            int currentComboNumber = cardValues[0];
            for (int i = 1; i < cardValues.Length; i++)
            {
                if (currentComboNumber == cardValues[i])
                {
                    currentCombo++;
                }
                else
                {
                    currentComboNumber = cardValues[i];
                    maxCombo = maxCombo > currentCombo ? maxCombo : currentCombo;
                    currentCombo = 1;
                }
            }
            return maxCombo > currentCombo ? maxCombo : currentCombo;
        }

        private bool IsFullHouse(int[] cardValues)
        {
            if (cardValues[0] == cardValues[1] && cardValues[3] == cardValues[4])
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private int PairCount(int[] cardValues)
        {
            int pairCount = 0;
            int currentComboNumber = cardValues[0];
            for (int i = 1; i < cardValues.Length; i++)
            {
                if (currentComboNumber == cardValues[i])
                {
                    pairCount++;
                }
                else
                {
                    currentComboNumber = cardValues[i];
                }
            }
            return pairCount;
        }
    }
}