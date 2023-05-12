using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Card_Game
{
    internal static class Game
    {
        public static void InitGame()
        {
            Console.WriteLine("-------------------- 1.Init deck --------------------");
            Deck deck = new Deck();
            deck.PrintCard();

            Console.WriteLine("\n\n-------------------- 2. Shuffled Deck --------------------");
            deck.ShuffleCards();
            deck.PrintCard();

            Console.WriteLine("\n\n-------------------- 3. Distribute the shuffled cards --------------------");
            var numOfCards = 0;
            Console.Write("Input number of cards 2, 3, 5 or 13 cards game: ");
            var validInput = new List<int>() { 2, 3, 5, 13 };
            var input = Console.ReadLine();
            while (!int.TryParse(input, out numOfCards) || !validInput.Contains(numOfCards))
            {
                Console.Write("Try input again numOfCard in 2, 3, 5 or 13:");
                input = Console.ReadLine();
            }
            var listOfPlayers = new List<Player>()
            {
                new Player("Player 1"),
                new Player("Player 2"),
                new Player("Player 3"),
                new Player("Player 4"),
            };
            for(int j = 0; j < numOfCards; j++)
            {
                foreach (var player in listOfPlayers)
                {
                    var card = deck.PopCard();
                    player.AddCard(card);
                }
            }
            foreach (var player in listOfPlayers)
            {
                Console.WriteLine($"\n------------------ {player.Name} ------------------");
                player.PrintCard();
                HandValuator handValuator = new HandValuator(player.Cards);
                player.HandValue = handValuator.GetHand();
                player.HandValue.PrintHandValue();
            }

            Console.WriteLine("\n\n-------------------- 4. Evaluate the winner --------------------");
            var maxHandValue = listOfPlayers?.Max(m => m.HandValue);
            var Winner = listOfPlayers?.FirstOrDefault(m => m.HandValue == maxHandValue);
            Console.WriteLine($"\nWinner is: {Winner?.Name}");
            Winner?.HandValue?.PrintHandValue();
        }
    }
}
