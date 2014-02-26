using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rskb.contracts
{
    public interface IBoardProvider
    {
        IEnumerable<Card> Load_all_cards();
        Card LoadCard(string id);
        void StoreCard(Card card);
    }
}
