using System;
using System.Collections.Generic;

namespace RPSLS
{
    public class Game
    {
        // Members
        Player player1;
        Player player2;
        bool isPlayer1;

        // Constructors
        public Game()
        {
            player1 = GetNewPlayer(player1);
            player2 = GetNewPlayer(player2);
            isPlayer1 = true;
        }

        // Methods
        public Player GetNewPlayer(Player player) {
            string playerType;
            string welcome;

            welcome = isPlayer1 ? "What type of player is Player 2? Please Choose 'human' or 'computer'.": 
                                         "What type of player is Player 1? Please Choose 'human' or 'computer'.";
            Console.WriteLine(welcome);
            playerType = Console.ReadLine();

            switch (playerType) {
                case "human":
                    player = new Human();
                    Console.WriteLine("Created new human player for player 1.");
                    Console.ReadLine();
                    break;
                case "computer":
                    player = new Computer();
                    Console.WriteLine("Created new computer player for player 2");
                    Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("Whoops! Please choose 'human' or 'computer'.");
                    Console.ReadLine();
                    break;
            }
            isPlayer1 = !isPlayer1;
            return player;


        }
    }
}
