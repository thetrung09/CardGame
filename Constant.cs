using System.ComponentModel;

namespace Card_Game
{
    public enum RANKS
    {
        [Description("2")]
        TWO = 2,
        [Description("3")]
        THREE,
        [Description("4")]
        FOUR,
        [Description("5")]
        FIVE,
        [Description("6")]
        SIX,
        [Description("7")]
        SEVEN,
        [Description("8")]
        EIGHT,
        [Description("9")]
        NINE,
        [Description("10")]
        TEN,
        [Description("J")]
        JACK,
        [Description("Q")]
        QUEEN,
        [Description("K")]
        KING,
        [Description("A")]
        ACE
    }
    public enum SYMBOLS
    {
        [Description("♣")]
        CLUBS,
        [Description("♦")]
        DIAMONDS,
        [Description("♥")]
        HEARTS,
        [Description("♠")]
        SPADES
    }
    public enum HAND
    {
        [Description("High Card")]
        HIGHCARD = 1,
        [Description("Pair")]
        PAIR,
        [Description("Three of kind")]
        THREEOFKIND,
        [Description("Quads")]
        QUADS
    }
    public enum CHOICE
    {
        [Description("Y")]
        YES = 1,
        [Description("N")]
        NO = 0
    }
}