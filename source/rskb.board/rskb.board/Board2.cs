using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nblackbox.contract;
using rskb.contracts;

namespace rskb.board
{
    public class Board2 : IBoard2
    {
        private IBlackBox blackBox;

        public Board2(IBlackBox blackBox)
        {
            this.blackBox = blackBox;
        }

        public void Move_card_to_column(String cardId, int destinationColumnIndex)
        {
            this.blackBox.Record(new CardMoved(cardId, destinationColumnIndex));
        }
    }
}
