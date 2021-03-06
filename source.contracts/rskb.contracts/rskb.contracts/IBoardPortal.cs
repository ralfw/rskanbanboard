﻿using System;
using System.Collections.Generic;

namespace rskb.contracts
{
    public interface IBoardPortal
    {
        void Display_cards(IEnumerable<Card> cards);

        event Action<string, int> On_card_moved;
        event Action<string, int> On_new_card;
        event Action On_refresh;
    }
}