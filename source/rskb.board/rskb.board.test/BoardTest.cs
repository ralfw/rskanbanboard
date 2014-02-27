using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using rskb.contracts;

namespace rskb.board
{
    [TestClass]
    public class BoardTest
    {
        [TestMethod]
        public void TestBoard()
        {
            Board target = new Board();
            
            Card c0 = new Card();
            c0.Id = "0";
            c0.Text = "Card 0";
            c0.ColumnIndex = 0;

            Card c1 = target.Move_card_to_column(c0, 1);
            Assert.AreEqual("0", c1.Id);
            Assert.AreEqual("Card 0", c1.Text);
            Assert.AreEqual(1, c1.ColumnIndex);
        }
    }
}
