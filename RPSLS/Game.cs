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
            DisplayWelcome();
            player1 = GetNewPlayer(player1);
            player2 = GetNewPlayer(player2);
            isPlayer1 = true;
            Console.WriteLine(GetResult(player1, player2));
            Console.WriteLine(CheckForWin(player1.total, player2.total));
        }

        // Methods
        public void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the classic game of Rock Paper Scissors Lizard Spock");
            Console.WriteLine("The rules are simple. You choose a result against your opponent and a result occurs.");
            Console.ReadLine();
            Console.WriteLine("Rock crushes Scissors");
            Console.WriteLine("Scissors cuts Paper");
            Console.WriteLine("Paper covers Rock");
            Console.WriteLine("Rock crushes Lizard");
            Console.WriteLine("Lizard poisons Spock");
            Console.WriteLine("Spock smashes Scissors");
            Console.WriteLine("Scissors decapitates Lizard");
            Console.WriteLine("Lizard eats Paper");
            Console.WriteLine("Paper disproves Spock");
            Console.WriteLine("Spock vaporizes Rock");
            Console.WriteLine("Press enter to begin playing!");
            Console.ReadLine();
        }


        public Player GetNewPlayer(Player player) {
            string playerType;
            string welcome;

            welcome = isPlayer1 ? "What type of player is Player 2? Please Choose 'human' or 'computer'.": 
                                         "What type of player is Player 1? Please Choose 'human' or 'computer'.";
            Console.WriteLine(welcome);
            playerType = Console.ReadLine().ToLower();

            switch (playerType) {
                case "human":
                    player = new Human("human");
                    Console.WriteLine("Created new human player for this player");
                    Console.ReadLine();
                    break;
                case "computer":
                    player = new Computer("computer");
                    Console.WriteLine("Created new computer for this player");
                    Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("Whoops! Please choose 'human' or 'computer'. Press enter to try again.");
                    Console.ReadLine();
                    GetNewPlayer(player);
                    break;
            }
            isPlayer1 = !isPlayer1;
            return player;


        }
        public string GetResult (Player player1, Player player2) {
            string result;


            player1.choice = player1.ChooseGesture();
            player2.choice = player2.ChooseGesture();

            result = "result";
            return result;

        }

        public string CheckForWin (int player1Total, int player2Total) {
            string finalScore;
            if (player1Total == 3) {
                finalScore = "Player 1 wins the match!!";
                Console.ReadLine();
            }
            else if (player2Total == 3) {
                finalScore =  "Player 2 wins the match!!";
                Console.ReadLine();
            }
            else {
                finalScore = "No winner yet! Keep playing!";
                Console.ReadLine();
                GetResult(player1,player2);
            }
            return finalScore;
        }
    }
}
