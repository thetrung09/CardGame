namespace Card_Game
{
    internal class Player
    {
        public Player(string? _name)
        {
            Name = _name;
        }
        public string? Name { get; set; }
        public HandValue? HandValue { get; set; }
        public List<Card> Cards { get; set; } = new List<Card>();
        public void AddCard(Card _card)
        {
            Cards.Add(_card);
        }
        public void PrintCard()
        {
            foreach(Card card in Cards)
            {
                card.PrintCard();
            }
        }
    }
}
