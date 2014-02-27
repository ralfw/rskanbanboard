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
            var boardController = new BoardController2(board, boardProvider);
            
            var cardId = "A";
            boardController.Move_card(cardId, 2);

            // Assert.AreEqual(card.ColumnIndex, 2, "columIndex is incorrect");
        }

        [TestMethod]
        public void Create_Card_Test()
        {
            IBoardProvider2 boardProvider = new BoardProviderMoc();
            IBoard2 board = new BoardMoc();
            var boardController = new BoardController2(board, boardProvider);

            var cardText = "A new card X";
            boardController.Create_card(cardText, 2);
            //var card = cards.FirstOrDefault(c => c.Text == cardText);

            //Assert.IsNotNull(card, "card is not contained");
            //Assert.AreEqual(card.ColumnIndex, 2, "columIndex is incorrect");
        }
    }
}
