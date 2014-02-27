using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rsbk.boardcontroller
{
    using System.Diagnostics.CodeAnalysis;

    using rskb.contracts;

    /// <summary>
    /// The board moc.
    /// </summary>
    public class BoardMoc : IBoard2
    {
        public void Create_card(string text, int columnIndex)
        {
            CardStore.Add(new Card { ColumnIndex = columnIndex, Id = text.GetHashCode().ToString(), Text = text });
        }

        public void Move_card_to_column(string cardId, int destinationColumnIndex)
        {
            CardStore.Change(cardId, destinationColumnIndex);
        }
    }

    /// <summary>
    /// The board provider moc.
    /// </summary>
    public class BoardProviderMoc : IBoardProvider2
    {
        public BoardProviderMoc()
        {
            CardStore.Add(new Card { ColumnIndex = 0, Id = "A", Text = "Die A Karte" });
            CardStore.Add(new Card { ColumnIndex = 1, Id = "C", Text = "Die C Karte" });
        }

        public IEnumerable<Card> Load_all_cards()
        {
            return CardStore.AllCards();
        }
    }

    public class BoardPortalMoc : IBoardPortal
    {
        public void Display_cards(IEnumerable<Card> cards)
        {
        }

        public event Action<string, int> On_card_moved;

        public event Action<string, int> On_new_card;

        public event Action On_refresh;
    }

    public class CardStore
    {
        static Dictionary<string, Card> cards = new Dictionary<string, Card>();

        public static void Add(Card card)
        {
            cards.Add(card.Id, card);
        }

        public static IEnumerable<Card> AllCards()
        {
            return cards.Values;
        }

        public static void Change(string id, int columnIndex)
        {
            cards[id].ColumnIndex = columnIndex;
        }

        public static void OnCardChanged(IEnumerable<Card> cards)
        {
        }
    }
}
