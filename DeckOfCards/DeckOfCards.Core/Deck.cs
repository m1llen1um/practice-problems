using System;
using System.Text;

namespace DeckOfCards.Core
{
    public class Deck : IDeck
    {
        private const int CardsCount = 52;
        private const int rankCount = 13;
        private const int suitsCount = 4;

        private readonly Card[] DeckOfCards = new Card[CardsCount];

        public void Init()
        {
            int deckIndex = 0;

            for (int rankIndex = 1; rankIndex <= rankCount; rankIndex++)
                for (int suitIndex = 1; suitIndex <= suitsCount; suitIndex++)
                {
                    DeckOfCards[deckIndex] = new Card(rankIndex, suitIndex, deckIndex);
                    deckIndex++;
                }
        }

        public string ListDeck()
        {
            var list = new StringBuilder(CardsCount);
            for (int i = 0; i < CardsCount; i++)
            {
                list.Append($"{DeckOfCards[i].ToString()}{Environment.NewLine}");
            }

            return list.ToString();
        }

        public int Find(int rank, int suit)
        {
            if (rank > rankCount || suit > suitsCount)
            {
                return -1;
            }

            Card searchCard = new Card(rank, suit);
            var foundCard = BinarySearchRecursive(DeckOfCards, searchCard, 0, CardsCount);
            return foundCard?.DeckIndex ?? -1;
        }

        public Card BinarySearchRecursive(Card[] DeckOfCards, Card searchCard, int min, int max)
        {
            if (min > max)
            {
                return null;
            }

            int mid = (min + max) / 2;
            if (searchCard.Equals(DeckOfCards[mid]))
            {
                return DeckOfCards[mid];
            }

            if (searchCard.Rank < DeckOfCards[mid].Rank)
            {
                return BinarySearchRecursive(DeckOfCards, searchCard, min, mid - 1);
            }
            else if (searchCard.Rank > DeckOfCards[mid].Rank)
            {
                return BinarySearchRecursive(DeckOfCards, searchCard, mid + 1, max);
            }
            else if (searchCard.Rank == DeckOfCards[mid].Rank && searchCard.Suit < DeckOfCards[mid].Suit)
            {
                return BinarySearchRecursive(DeckOfCards, searchCard, min, mid - 1);
            }
            else if (searchCard.Rank == DeckOfCards[mid].Rank && searchCard.Suit > DeckOfCards[mid].Suit)
            {
                return BinarySearchRecursive(DeckOfCards, searchCard, mid + 1, max);
            }
            else
            {
                return null;
            }
        }
    }
}