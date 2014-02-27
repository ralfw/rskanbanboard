using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using rskb.contracts;

namespace rskb.boardcontroller
{
    using System.Diagnostics;

    /// <summary>
    /// The board controller.
    /// </summary>
    public class BoardController2 : IBoardController
    {
        private readonly TraceSource _ts = new TraceSource("rskb.boardcontroller", SourceLevels.All);
        private readonly IBoard2 _board;
        private readonly IBoardProvider2 _provider;

        public event Action<IEnumerable<Card>> On_cards_changed;

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
        public BoardController2(IBoard2 board, IBoardProvider2 provider)
        {
            this._board = board;
            this._provider = provider;
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
        public void Move_card(string cardId, int destinationColumnIndex)
        {
            _board.Move_card_to_column(cardId, destinationColumnIndex);
            this.FireEventOnCardsChanged();
        }

        public void Refresh()
        {
            this.FireEventOnCardsChanged();
        }

        public void Create_card(string cardId, int columnIndex)
        {
            this._board.Create_card(cardId, columnIndex);
            this.FireEventOnCardsChanged();
        }

        private void FireEventOnCardsChanged()
        {
            if (On_cards_changed == null)
            {
                throw new ArgumentException("Event is not set.");
            }

            On_cards_changed(_provider.Load_all_cards());
        }
    }
}
