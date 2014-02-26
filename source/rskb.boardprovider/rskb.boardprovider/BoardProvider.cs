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
        private IEnumerable<Card> board = new[] { new Card() { ColumnIndex = 1, Id = "I1", Text = "A" } };

        public IEnumerable<Card> Load_all_cards()
        {
            return this.board;
        }

        public Card LoadCard(string id)
        {
            return board.First();
        }

        public void StoreCard(Card card)
        {
            // nix.
        }
    }
}
