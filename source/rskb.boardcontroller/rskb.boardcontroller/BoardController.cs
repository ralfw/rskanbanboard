using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using rskb.contracts;

namespace rskb.boardcontroller
{
    public class BoardController : IBoardController
    {
        private readonly IBoard _board;
        private readonly IBoardProvider _provider;
        private readonly IBoardPortal _portal;

        public BoardController(IBoard board, IBoardProvider provider, IBoardPortal portal)
        {
            _board = board;
            _provider = provider;
            _portal = portal;
        }


        public IEnumerable<Card> Move_card(string cardId, int destinationColumnIndex)
        {
            var card = _provider.LoadCard(cardId);
            card = _board.Move_card_to_column(card, destinationColumnIndex);
            _provider.StoreCard(card);
            return _provider.Load_all_cards();
        }
    }
}
