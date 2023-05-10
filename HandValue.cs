namespace Card_Game
{
    internal class HandValue : IComparable<HandValue>
    {
        public RANKS MaxRank { get; set; }
        public SYMBOLS MaxSymbol { get; set; }
        public HAND Hand { get; set; }
        public List<Card> GroupCards { get; set; } = new List<Card>();

        public int CompareTo(HandValue? other)
        {
            int compareValue = Hand.CompareTo(other?.Hand);
            if (compareValue == 0) compareValue = MaxRank.CompareTo(other?.MaxRank);
            if (compareValue == 0) compareValue = MaxSymbol.CompareTo(other?.MaxSymbol);
            return compareValue;
        }

        public void PrintHandValue()
        {
            Console.WriteLine($"\nHand: {Hand.GetDescription()} | MaxRank: {MaxRank.GetDescription()} | MaxSymbol: {MaxSymbol.GetDescription()}");
            foreach(Card card in GroupCards)
            {
                card.PrintCard();
            }
        }
    }
}
