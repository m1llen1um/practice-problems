namespace DeckOfCards.Core
{
    public interface IDeck
    {
        /// <summary>
        /// Fill deck of cards in sorted order
        /// </summary>
        void Init();

        /// <summary>
        /// List all cards, each in a new line
        /// </summary>
        string ListDeck();

        /// <summary>
        /// Search and find card's index
        /// </summary>
        int Find( int rank, int suit);
    }
}