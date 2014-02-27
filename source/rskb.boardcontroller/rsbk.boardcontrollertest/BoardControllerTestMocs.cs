using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rsbk.boardcontroller
{
    using rskb.contracts;

    /// <summary>
    /// The board moc.
    /// </summary>
    class BoardMoc : IBoard2
    {
        public void Create_card(string text, int columnIndex)
        {
            throw new NotImplementedException();
        }

        public void Move_card_to_column(string cardId, int destinationColumnIndex)
        {
            throw new NotImplementedException();
        }
    }

    /// <summary>
    /// The board provider moc.
    /// </summary>
    public class BoardProviderMoc : IBoardProvider2
    {
        List<Card> cards = new List<Card>();

        public BoardProviderMoc()
        {
            this.cards.Add(new Card { ColumnIndex = 0, Id = "A", Text = "Die A Karte"});
            this.cards.Add(new Card { ColumnIndex = 1, Id = "C", Text = "Die C Karte" });
        }
        
        public IEnumerable<Card> Load_all_cards()
        {
            return cards;
        }

        public Card LoadCard(string id)
        {
            return cards.First(c => c.Id == id);
        }

        public void StoreCard(Card card)
        {
        }
    }
}
