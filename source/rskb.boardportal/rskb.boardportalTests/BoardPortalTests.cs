using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using rskb.boardportal;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using rskb.contracts;
using System.Windows.Forms;

namespace rskb.boardportal.Tests
{
    [TestClass()]
    public class BoardPortalTests
    {
        ////[TestMethod()]
        public void Display_cardsTest()
        {
            BoardPortal form = new BoardPortal();
            List<Card> cards = new List<Card>();

            for(int i = 0; i< 15; i++)
            {
                Card cardToAdd = new Card() { ColumnIndex = i / 4, Id = i.ToString(), Text = "Card \n wwwwwwwWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWwwwwwwww " + i.ToString()};
                cards.Add(cardToAdd); 
            }

            form.Display_cards(cards);
            form.ShowDialog();
        }
    }
}
