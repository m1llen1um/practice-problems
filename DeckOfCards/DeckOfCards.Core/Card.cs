using System;

namespace DeckOfCards.Core
{
    public class Card
    {
        public Card(int rank, int suit)
        {
            Rank = rank;
            Suit = suit;
        }

        public Card(int rank, int suit, int index) : this(rank, suit)
        {
            DeckIndex = index;
        }


        public int DeckIndex { get; set; }

        // todo: Consider Enum
        public int Suit { get; set; }

        // todo: consider byte
        public int Rank { get; set; }

        public override bool Equals(object obj)
        {
            var card = obj as Card;
            if (card == null)
            {
                return false;
            }

            return Rank == card.Rank && Suit == card.Suit;
        }

        public string RankName
        {
            get
            {
                var rankName = string.Empty;
                switch (Rank)
                {
                    case 1:
                        {
                            rankName = "Ace";
                            break;
                        }

                    case 11:
                        {

                            rankName = "J";
                            break;
                        }

                    case 12:
                        {

                            rankName = "Q";
                            break;
                        }


                    case 13:
                        {

                            rankName = "K";
                            break;
                        }

                    default:
                        {
                            rankName = Rank.ToString();
                            break;
                        }
                }

                return rankName;
            }
        }

        // unsafe code
        public string SuitName
        {
            get
            {
                return Enum.GetName(typeof(SuitNameType), (SuitNameType)Suit);
            }
        }


        public override string ToString()
        {
            return $"{RankName} {SuitName}";
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}