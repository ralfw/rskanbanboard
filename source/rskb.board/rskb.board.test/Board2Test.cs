using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using rskb.contracts;

namespace rskb.board
{
    using System.IO;
    using System.Linq;

    using nblackbox;
    using nblackbox.contract;

    [TestClass]
    public class Board2Test
    {
        private const string BlackBoxDir = "BlackBox";

        [TestMethod]
        public void TestCreateBoard2()
        {
            this.DeleteBlackBox();
            FileBlackBox blackBox = new FileBlackBox(BlackBoxDir);
            Board2 target = new Board2(blackBox);

            target.Create_card("Test card", 1);
            var events = blackBox.Player.Play();

            Assert.AreEqual(2, events.Count());
        }

        [TestMethod]
        public void TestMoveBoard2()
        {
            this.DeleteBlackBox();
            FileBlackBox blackBox = new FileBlackBox(BlackBoxDir);
            Board2 target = new Board2(blackBox);

            target.Create_card("Test card", 1);
            var events = blackBox.Player.Play();
            IRecordedEvent ev = events.First();
            string id = ev.Context;

            target.Move_card_to_column(id, 2);
            events = blackBox.Player.Play();
            Assert.AreEqual(3, events.Count());
        }

        private void DeleteBlackBox()
        {
            if (Directory.Exists(BlackBoxDir))
            {
                Directory.Delete(BlackBoxDir, true);
            }
        }
    }
}
