namespace rskb.contracts
{
    public interface IBoard2
    {
        void Create_card(string text, int columnIndex);
        void Move_card_to_column(string cardId, int destinationColumnIndex);
    }
}