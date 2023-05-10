namespace Card_Game
{
    internal class HandValuator
    {
        public HandValuator(List<Card> _Cards)
        {
            Cards = _Cards;
            foreach (Card card in Cards)
            {
                var rank = card.Rank.GetHashCode();
                if (listRanks.ContainsKey(rank))
                {
                    listRanks[rank]++;
                }
                else
                {
                    listRanks[rank] = 1;
                }
            }
        }
        private Dictionary<int, int> listRanks = new Dictionary<int, int>();
        private List<Card> Cards { get; set; } = new List<Card>();
        public HandValue GetHand()
        {
            var handValue = new HandValue();
            var listValue = listRanks.Where(d => d.Value == listRanks.Max(r => r.Value));
            var maxKeyValue = listValue.FirstOrDefault(d => d.Key == listValue.Max(r => r.Key));
            
            var maxHand = (HAND)maxKeyValue.Value;
            var maxRank = (RANKS)maxKeyValue.Key;
            var groupCards = Cards.Where(c => c.Rank == maxRank);
            var maxSymbol = groupCards.Max(c => c.Symbol);

            return new HandValue() 
            { 
                Hand = maxHand,
                MaxRank = maxRank,
                MaxSymbol = maxSymbol,
                GroupCards = groupCards.ToList()
            };
        }

    }
}
