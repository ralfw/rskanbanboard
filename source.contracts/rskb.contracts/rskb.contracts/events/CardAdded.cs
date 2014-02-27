using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nblackbox.contract;

namespace rskb.contracts
{
    public class CardAdded : IEvent
    {
        public CardAdded(string cardId, string text)
        {
            Name = "CardAdded";
            Context = cardId;
            Data = text;
        }

        public string Name { get; private set; }
        public string Context { get; private set; }
        public string Data { get; private set; }
    }
}
