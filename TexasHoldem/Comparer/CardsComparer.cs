using TexasHoldem.Core;
using TexasHoldem.Models;

namespace TexasHoldem.Comparer
{
    public class CardsComparer
    {
        private const string _commonWinString = " wins - ";

        private const string _commonSameLevelWinString = _commonWinString + "HighCard: ";

        private const string _tieResult = "Tie";

        public string CompareCards(HandCard[] handcards)
        {
            string result = "";
            var blackLevel = handcards[Players.Black].Level;
            var whiteLevel = handcards[Players.White].Level;
            if (blackLevel > whiteLevel)    // black win in level
            {
                result = nameof(Players.Black) + _commonWinString + blackLevel;
            }
            else if (blackLevel < whiteLevel)   //white win in level
            {
                result = nameof(Players.White) + _commonWinString + whiteLevel;
            }
            else    // same level
            {
                if (blackLevel == Levels.ThreeOfAKind || blackLevel == Levels.FullHouse || blackLevel == Levels.FourOfAKind)    // won't be Tie
                {
                    const int middleValueIndex = 2;
                    int blackMiddleValue = handcards[Players.Black].CardValues[middleValueIndex];
                    int whiteMiddleValue = handcards[Players.White].CardValues[middleValueIndex];
                    if (blackMiddleValue > whiteMiddleValue)
                    {
                        result = nameof(Players.Black) + _commonSameLevelWinString + FormmatIntValueToString(blackMiddleValue);
                    }
                    else
                    {
                        result = nameof(Players.White) + _commonSameLevelWinString + FormmatIntValueToString(whiteMiddleValue);
                    }
                }
                else if (blackLevel == Levels.Pair || blackLevel == Levels.TwoPairs)    // deal with pair
                {
                    result = GetPairLevelResult(handcards);
                }
                else    // deal with hightest card value
                {
                    result = GetHighCardResult(handcards);
                }
            }

            return result;
        }

        private string GetHighCardResult(HandCard[] handcards)
        {
            string result = "";
            bool isTie = true;
            for (int i = handcards[Players.Black].CardValues.Length - 1; i > -1; i--)
            {
                int blackValue = handcards[Players.Black].CardValues[i];
                int whiteValue = handcards[Players.White].CardValues[i];
                if (blackValue > whiteValue)
                {
                    result = nameof(Players.Black) + _commonSameLevelWinString + FormmatIntValueToString(blackValue);
                    isTie = false;
                    break;
                }
                else if (blackValue < whiteValue)
                {
                    result = nameof(Players.White) + _commonSameLevelWinString + FormmatIntValueToString(whiteValue);
                    isTie = false;
                    break;
                }
            }
            if (isTie)
            {
                result = _tieResult;
            }

            return result;
        }

        private string GetPairLevelResult(HandCard[] handCards)
        {
            string result = "";
            const int maxPairs = 2;
            int[] blackPairs = new int[maxPairs];
            int[] whitePairs = new int[maxPairs];
            int[] blackHandCardValues = handCards[Players.Black].CardValues;
            int[] whiteHandCardValues = handCards[Players.White].CardValues;

            GetPlayerPairs(blackPairs, blackHandCardValues);
            GetPlayerPairs(whitePairs, whiteHandCardValues);

            bool isTieInPairs = true;
            for (int i = maxPairs - 1; i > -1; i--)
            {
                if (blackPairs[i] > whitePairs[i])
                {
                    result = nameof(Players.Black) + _commonSameLevelWinString + FormmatIntValueToString(blackPairs[i]);
                    isTieInPairs = false;
                    break;
                }
                else if (blackPairs[i] < whitePairs[i])
                {
                    result = nameof(Players.White) + _commonSameLevelWinString + FormmatIntValueToString(whitePairs[i]);
                    isTieInPairs = false;
                    break;
                }
            }

            if (isTieInPairs)
            {
                result = GetHighCardResult(handCards);
            }

            return result;
        }

        private void GetPlayerPairs(int[] playerPairs, int[] playerHandCardValues)
        {
            int pairCount = 0;
            int currentComboNumber = playerHandCardValues[0];
            for (int i = 1; i < playerHandCardValues.Length; i++)
            {
                if (currentComboNumber == playerHandCardValues[i])
                {
                    playerPairs[pairCount] = currentComboNumber;
                    pairCount++;
                }
                else
                {
                    currentComboNumber = playerHandCardValues[i];
                }
            }
        }

        private string FormmatIntValueToString(int cardValue)
        {
            string result = "";
            if (cardValue < 10)
            {
                result = cardValue.ToString();
            }
            else
            {
                switch (cardValue)
                {
                    case 10:
                        result =  "T";
                        break;
                    case 11:
                        result =  "J";
                        break;
                    case 12:
                        result =  "Q";
                        break;
                    case 13:
                        result =  "K";
                        break;
                    case 14:
                        result =  "Ace";
                        break;
                }
            }
            return result;
        }
    }
}