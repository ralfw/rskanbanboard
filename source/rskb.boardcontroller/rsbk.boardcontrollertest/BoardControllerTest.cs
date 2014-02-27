using System.Linq;
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
            IBoardProvider2 boardProvider = new BoardProviderMoc();
            IBoard2 board = new BoardMoc();
            var boardController = new BoardController2(board, boardProvider, null);
            
            var cardId = "A";
            var cards = boardController.Move_card(cardId, 2);
            var card = cards.First(c => c.Id == cardId);

            Assert.AreEqual(card.ColumnIndex, 2, "columIndex is incorrect");
        }

        [TestMethod]
        public void Create_Card_Test()
        {
            IBoardProvider2 boardProvider = new BoardProviderMoc();
            IBoard2 board = new BoardMoc();
            var boardController = new BoardController2(board, boardProvider, null);

            var cardText = "Neue Karte X";
            var cards = boardController.Create_card(cardText, 3);

            var card = cards.FirstOrDefault(c => c.Text == cardText);

            Assert.IsNotNull(card,"card does not exist");
            Assert.AreEqual(card.ColumnIndex, 3, "columIndex is incorrect");
        }
    }
}
