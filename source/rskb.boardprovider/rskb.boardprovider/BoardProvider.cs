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
}
