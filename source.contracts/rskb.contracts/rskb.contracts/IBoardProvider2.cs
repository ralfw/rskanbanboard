using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rskb.contracts
{
    public interface IBoardProvider2
    {
        IEnumerable<Card> Load_all_cards();
    }
}
