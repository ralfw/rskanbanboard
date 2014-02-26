using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using rskb.contracts;

namespace rskb.boardportal
{
    public class BoardPortal : IBoardPortal
    {
        public void Display_cards(IEnumerable<Card> cards)
        {
            throw new NotImplementedException();
        }

        public event Action<string, int> On_card_moved;
    }
}
