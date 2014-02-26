namespace rskb.contracts
{
    public interface IBoard
    {
        Card Move_card_to_column(Card card, int destinationColumnIndex);
    }
}