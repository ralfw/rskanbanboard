using System;
using System.Collections.Generic;

namespace rskb.contracts
{
    public interface IBoardController
    {
        void Move_card(string cardId, int destinationColumnIndex);
        void Create_card(string text, int columnIndex);
        void Refresh();

        event Action<IEnumerable<Card>> On_cards_changed;
    }
}