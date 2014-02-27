using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace rskb.BoardProviderTest
{
    using System.IO;
    using System.Linq;
    using nblackbox;
    using rskb.boardprovider;
    using rskb.contracts;

    [TestClass]
    public class EventStoreBoardProviderTest
    {
        private IBoardProvider2 provider;

        [TestInitialize]
        public void CreateTestData()
        {
            this.DeleteTestData();
            var blackBox = new FileBlackBox("CardStore");
            this.provider = new EventstoreBoardprovider(blackBox);
        }

        [TestCleanup]
        public void DeleteTestData()
        {
            if (Directory.Exists("CardStore"))
            {
                Directory.Delete("CardStore", true);
            }
        }

        [TestMethod]
        public void LoadAllCards()
        {
            var board = this.provider.Load_all_cards();
            Assert.AreEqual(9, board.Count());
        }
    }
}
