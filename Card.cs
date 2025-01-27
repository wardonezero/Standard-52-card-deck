namespace Standard_52_card_deck;
public struct Card : IComparable<Card>
{
    public CardRanks Rank { get; init; }

    public CardSuits Suit { get; init; }

    public int CompareTo(Card other)
    {
        throw new NotImplementedException();
    }

    public override string ToString() => $"{Rank} of {Suit}";    
}
