using nblackbox.contract;

namespace rskb.contracts
{
    public class CardMoved : IEvent
    {
        public CardMoved(string cardId, int destinationColumnIndex)
        {
            Name = "CardMoved";
            Context = cardId;
            Data = destinationColumnIndex.ToString();
        }

        public string Name { get; private set; }
        public string Context { get; private set; }
        public string Data { get; private set; }
    }
}