using Xunit;
using DeckOfCards.Core;

namespace DeckOfCards.Tests
{
    public class Tests
    {
        [Fact]
        public void ListDeckTest()
        {
            var deck = new Deck();
            deck.Init();
            var listedDeck = deck.ListDeck();
            Assert.NotNull(listedDeck);
        }

        [Fact]
        public void SearchDeckTest()
        {
            var deck = new Deck();
            deck.Init();
            Assert.Equal(7, deck.Find(2, 4));
            Assert.Equal(29, deck.Find(8, 2));
            Assert.Equal(-1, deck.Find(14, 1));
        }
    }
}
