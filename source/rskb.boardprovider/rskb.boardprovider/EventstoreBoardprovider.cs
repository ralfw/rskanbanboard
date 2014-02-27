using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nblackbox.contract;
using rskb.contracts;

namespace rskb.boardprovider
{

    public class EventstoreBoardprovider : IBoardProvider2
    {
        private readonly TraceSource _ts = new TraceSource("rskb.boardprovider", SourceLevels.All);
        private readonly IBlackBox blackBox;

        public EventstoreBoardprovider(IBlackBox blackBox)
        {
            this.blackBox = blackBox;
        }

        public IEnumerable<Card> Load_all_cards()
        {
            var allEvents = this.blackBox.Player.Play();

            if (!allEvents.Any())
            {
                this.CreateDefaultEvents();
                allEvents = this.blackBox.Player.Play();
            }

            var board = new Dictionary<String, Card>();
            foreach (var e in allEvents)
            {
                if (e.Name == "CardAdded")
                {
                    var id = e.Context;
                    board.Add(id, new Card() { Id = id, Text = e.Data });
                }
                else if (e.Name == "CardMoved")
                {
                    board[e.Context].ColumnIndex = int.Parse(e.Data);
                }
            }

            return board.Values;
        }

        private void CreateDefaultEvents()
        {
            var board = new List<Card>()
                        {
                            new Card() { ColumnIndex = 0, Id = "0", Text = "A" }, new Card() { ColumnIndex = 0, Id = "1", Text = "B" },
                            new Card() { ColumnIndex = 0, Id = "2", Text = "C" }, new Card() { ColumnIndex = 1, Id = "3", Text = "D" },
                            new Card() { ColumnIndex = 1, Id = "4", Text = "E" }, new Card() { ColumnIndex = 2, Id = "5", Text = "F" },
                            new Card() { ColumnIndex = 3, Id = "6", Text = "G" }, new Card() { ColumnIndex = 3, Id = "7", Text = "H" },
                            new Card() { ColumnIndex = 3, Id = "8", Text = "I" },
                        };
            foreach (var card in board)
            {
                this.blackBox.Record(new CardAdded(card.Id, card.Text));
                this.blackBox.Record(new CardMoved(card.Id, card.ColumnIndex));
            }
        }
    }
}
