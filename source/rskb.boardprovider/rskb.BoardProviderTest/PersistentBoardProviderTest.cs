using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace rskb.BoardProviderTest
{
    using System.IO;
    using System.Linq;
    using rskb.boardprovider;
    using rskb.contracts;

    [TestClass]
    public class PersistentBoardProviderTest
    {
        private const String testFilename = "Testdata.xml";

        private IBoardProvider provider;

        [TestInitialize]
        public void CreateTestData()
        {
            this.provider = new PersistentBoardProvider(testFilename);
            provider.StoreCard(new Card(){Id = "0", ColumnIndex = 0, Text = "AAA"});
            provider.StoreCard(new Card(){Id = "1", ColumnIndex = 1, Text = "BBB"});
            provider.StoreCard(new Card(){Id = "2", ColumnIndex = 1, Text = "CCC"});
            provider.StoreCard(new Card(){Id = "3", ColumnIndex = 2, Text = "DDD"});
        }

        [TestCleanup]
        public void DeleteTestData()
        {
            File.Delete(testFilename);
        }

        [TestMethod]
        public void LoadAllCards()
        {
            var board = this.provider.Load_all_cards();
            Assert.IsTrue(board.Any());
        }

        [TestMethod]
        public void LoadCardById()
        {
            var board = provider.Load_all_cards();
            var expected = board.First();
            var actual = provider.LoadCard(expected.Id);
            Assert.AreEqual(expected.Id, actual.Id);
        }

        [TestMethod]
        public void UpdateExistingCard()
        {
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
            var board = provider.Load_all_cards();
            var expected = board.First();
            expected.ColumnIndex = 42;
            var actual = provider.LoadCard(expected.Id);
            Assert.AreNotEqual(42, actual.ColumnIndex);
        }
    }
}
