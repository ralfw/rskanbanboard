using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using rskb.boardcontroller;
using rskb.contracts;

namespace rsbk.boardcontroller
{
    [TestClass]
    public class BoardControllerTest
    {
        [TestMethod]
        public void Move_Card_Test()
        {
            IBoardProvider boardProvider = new BoardProviderMoc();
            IBoardPortal bandPortal = new BoardPortalMoc();
            IBoard board = new BoardMoc();
            var boardController = new BoardController(board, boardProvider, bandPortal);
            
            String cardId = "A";
            //// boardcontroller.Move_card(cardId, 2);
            var card = boardProvider.LoadCard("A");

            Assert.AreEqual(card.ColumnIndex, 2, "columIndex is incorrect");
        }
    }
}
