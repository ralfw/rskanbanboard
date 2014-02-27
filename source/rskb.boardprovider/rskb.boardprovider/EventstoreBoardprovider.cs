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
        private IBlackBox blackBox;

        public EventstoreBoardprovider(IBlackBox blackBox)
        {
            this.blackBox = blackBox;
        }

        public IEnumerable<Card> Load_all_cards()
        {
            var allEvents = this.blackBox.Player.Play();
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
    }
}
