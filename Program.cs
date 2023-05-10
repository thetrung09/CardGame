using Card_Game;

Game.InitGame();
Console.Write("\n\nTry again? Y/N: ");
var choice = Console.ReadLine();

while (choice?.ToUpper() != CHOICE.NO.GetDescription())
{
    if (choice?.ToUpper() == CHOICE.YES.GetDescription())
    {
        Console.Clear();
        Game.InitGame();
        Console.Write("\n\nTry again? Y/N: ");
        choice = Console.ReadLine();
    }
    else
    {
        Console.Write("Please choose Y/N:");
        choice = Console.ReadLine();
    }
}