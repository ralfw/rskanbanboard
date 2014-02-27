using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rsbk.boardcontroller
{
    using rskb.contracts;

    class BoardMoc : IBoard
    {
        public Card Move_card_to_column(Card card, int destinationColumnIndex)
        {
            card.ColumnIndex = destinationColumnIndex;
            return card;
        }
    }

    public class BoardProviderMoc : IBoardProvider
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

    public class BoardPortalMoc : IBoardPortal
    {
        public void Display_cards(IEnumerable<Card> cards)
        {
        }

        public event Action<string, int> On_card_moved;
    }
}
