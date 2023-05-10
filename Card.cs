namespace Card_Game
{
    internal class Card
    {
        public RANKS Rank { get; set; }
        public SYMBOLS Symbol { get; set; }
        public void PrintCard()
        {
            Console.Write($"{Rank.GetDescription()}{Symbol.GetDescription()} ");
        }
    }
}
