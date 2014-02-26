using System.Collections.Generic;

namespace rskb.contracts
{
    public interface IBoardController
    {
        IEnumerable<Card> Move_card(string cardId, int destinationColumnIndex);
    }
}