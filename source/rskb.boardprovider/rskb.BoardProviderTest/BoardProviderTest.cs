using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace rskb.BoardProviderTest
{
    using System.Linq;

    using rskb.boardprovider;
    using rskb.contracts;

    [TestClass]
    public class BoardProviderTest
    {
        [TestMethod]
        public void LoadAllCards()
        {
            var provider = new BoardProvider();
            var board = provider.Load_all_cards();
            Assert.IsTrue(board.Any());
        }

        [TestMethod]
        public void LoadCardById()
        {
            var provider = new BoardProvider();
            var board = provider.Load_all_cards();
            var expected = board.First();
            var actual = provider.LoadCard(expected.Id);
            Assert.AreEqual(expected.Id, actual.Id);
        }

        [TestMethod]
        public void UpdateExistingCard()
        {
            var provider = new BoardProvider();
            var board = provider.Load_all_cards();
            var expected = board.First();
            expected.ColumnIndex = 42;
            provider.StoreCard(expected);
            var actual = provider.LoadCard(expected.Id);
            Assert.AreEqual(42, actual.ColumnIndex);
        }

        [TestMethod]
        public void StoreNewCard()
        {
            var provider = new BoardProvider();
            var expected = new Card() { ColumnIndex = 12345, Id = "qwertz", Text = "asdfghjkl" };
            provider.StoreCard(expected);
            var new_board = provider.Load_all_cards();
            var card_from_board = new_board.Single(c => c.Id == expected.Id);
            Assert.AreEqual(expected.Id, card_from_board.Id);

            var loaded_card = provider.LoadCard(expected.Id);
            Assert.AreEqual(expected.Id, loaded_card.Id);
        }

        [TestMethod]
        public void UpdateCardWithoutStore_ShallNotUpdate()
        {
            var provider = new BoardProvider();
            var board = provider.Load_all_cards();
            var expected = board.First();
            expected.ColumnIndex = 42;
            var actual = provider.LoadCard(expected.Id);
            Assert.AreNotEqual(42, actual.ColumnIndex);
        }
    }
}
