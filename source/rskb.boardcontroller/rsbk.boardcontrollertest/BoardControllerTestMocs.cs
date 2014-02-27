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
            throw new NotImplementedException();
        }
    }

    public class BoardProviderMoc : IBoardProvider
    {
        public IEnumerable<Card> Load_all_cards()
        {
            throw new NotImplementedException();
        }

        public Card LoadCard(string id)
        {
            throw new NotImplementedException();
        }

        public void StoreCard(Card card)
        {
            throw new NotImplementedException();
        }
    }

    public class BoardPortalMoc : IBoardPortal
    {
        public void Display_cards(IEnumerable<Card> cards)
        {
            throw new NotImplementedException();
        }

        public event Action<string, int> On_card_moved;
    }
}
