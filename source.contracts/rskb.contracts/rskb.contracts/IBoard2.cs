namespace rskb.contracts
{
    public interface IBoard2
    {
        void Move_card_to_column(string cardId, int destinationColumnIndex);
    }
}