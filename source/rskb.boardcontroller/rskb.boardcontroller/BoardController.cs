using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using rskb.contracts;

namespace rskb.boardcontroller
{
    /// <summary>
    /// The board controller.
    /// </summary>
    public class BoardController : IBoardController
    {
        private readonly IBoard _board;
        private readonly IBoardProvider _provider;
        private readonly IBoardPortal _portal;

        /// <summary>
        /// Initializes a new instance of the <see cref="BoardController"/> class.
        /// </summary>
        /// <param name="board">
        /// The board.
        /// </param>
        /// <param name="provider">
        /// The provider.
        /// </param>
        /// <param name="portal">
        /// The portal.
        /// </param>
        public BoardController(IBoard board, IBoardProvider provider, IBoardPortal portal)
        {
            this._board = board;
            this._provider = provider;
            this._portal = portal;
        }

        /// <summary>
        /// Moves the card.
        /// </summary>
        /// <param name="cardId">
        /// The card id.
        /// </param>
        /// <param name="destinationColumnIndex">
        /// The destination column index.
        /// </param>
        /// <returns>
        /// The <see cref="IEnumerable"/>.
        /// </returns>
        public IEnumerable<Card> Move_card(string cardId, int destinationColumnIndex)
        {
            var card = _provider.LoadCard(cardId);
            card = _board.Move_card_to_column(card, destinationColumnIndex);
            _provider.StoreCard(card);
            return _provider.Load_all_cards();
        }
    }
}
