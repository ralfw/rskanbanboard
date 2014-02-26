using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using rskb.contracts;

namespace rskb.boardprovider
{
    public class BoardProvider : IBoardProvider
    {
        private IEnumerable<Card> board = new List<Card>()
                                          {
                                              new Card() { ColumnIndex = 0, Id = "0", Text = "A" },
                                              new Card() { ColumnIndex = 0, Id = "1", Text = "B" },
                                              new Card() { ColumnIndex = 0, Id = "2", Text = "C" },
                                              new Card() { ColumnIndex = 1, Id = "3", Text = "D" },
                                              new Card() { ColumnIndex = 1, Id = "4", Text = "E" },
                                              new Card() { ColumnIndex = 2, Id = "5", Text = "F" },
                                              new Card() { ColumnIndex = 3, Id = "6", Text = "G" },
                                              new Card() { ColumnIndex = 3, Id = "7", Text = "H" },
                                              new Card() { ColumnIndex = 3, Id = "8", Text = "I" },
                                          };

        public IEnumerable<Card> Load_all_cards()
        {
            return this.board;
        }

        public Card LoadCard(string id)
        {
            return board.First(c => c.Id == id);
        }

        public void StoreCard(Card card)
        {
            // nix.
        }
    }
}
