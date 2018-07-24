using System;
using System.Collections.Generic;

namespace RPSLS
{
    public class Game
    {
        // Members
        Player player1;
        Player player2;

        // Constructors
        public Game()
        {
            player1 = GetNewPlayer(player1);
            player2 = GetNewPlayer(player2);
        }

        // Methods
        public Player GetNewPlayer(Player player) {
            string playerType;


            Console.WriteLine("What type of player is this? Please Choose 'human' or 'computer'.");
            playerType = Console.ReadLine();

            switch (playerType) {
                case "human":
                    player = new Human();
                    Console.WriteLine("Created new human player.");
                    Console.ReadLine();
                    break;
                case "computer":
                    player = new Computer();
                    Console.WriteLine("Created new computer player");
                    Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("Whoops! Please choose 'human' or 'computer'.");
                    Console.ReadLine();
                    break;
            }
            return player;


        }
    }
}
