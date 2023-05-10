namespace Card_Game
{
    internal class Deck
    {
        public Deck()
        {
            InitDesk();
        }
        private List<Card> cards { get; set; } = new List<Card>();
        public void InitDesk()
        {
            foreach(RANKS r in Enum.GetValues(typeof(RANKS)))
            {
                foreach (SYMBOLS s in Enum.GetValues(typeof(SYMBOLS)))
                {
                    cards.Add(new Card() { Rank = r, Symbol = s });
                }
            }
        }

        public Card PopCard()
        {
            var card = cards.First();
            cards.Remove(card);
            return card;
        }
        public void ShuffleCards()
        {
            Random rnd = new Random();
            for (int i = 0; i < cards.Count; i++)
            {
                int r = i + rnd.Next(cards.Count - i);
                Card temp = cards[r];
                cards[r] = cards[i];
                cards[i] = temp;
            }
        }
        public void PrintCard()
        {
            foreach (var c in cards)
            {
                c.PrintCard();
            }
        }
    }
}
