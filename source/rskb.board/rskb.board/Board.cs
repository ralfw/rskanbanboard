using rskb.contracts;

namespace rskb.board
{
    using System.Diagnostics;

    public class Board : IBoard
    {
        private readonly TraceSource ts = new TraceSource("rskb.board", SourceLevels.All);

        public Card Move_card_to_column(Card card, int destinationColumnIndex)
        {
            this.ts.TraceInformation("Move card {0} from {1} to {2}", card.Id, card.ColumnIndex, destinationColumnIndex);
            card.ColumnIndex = destinationColumnIndex;
            return card;
        }
    }
}
