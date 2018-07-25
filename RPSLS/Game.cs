using System;
using System.Collections.Generic;

namespace RPSLS
{
    public class Game
    {
        // Members
        Player player1;
        Player player2;
        List<string> gestures;
        public int round;


        // Constructors
        public Game()
        {
            DisplayWelcome();
            player1 = GetNewPlayer(player1, true);
            player2 = GetNewPlayer(player2 , false);
            gestures = new List<string>() { "rock", "paper", "scissors", "spock", "lizard" };
            round = 1;
            RunGame(player1.total, player2.total);

        }

        // Methods
        public void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the classic game of Rock Paper Scissors Lizard Spock");
            Console.ReadLine();
            Console.WriteLine("Rock crushes Scissors\nScissors cuts Paper\nPaper covers Rock\nRock crushes Lizard\nLizard poisons Spock\nSpock smashes Scissors" +
                              "\nScissors decapitates Lizard\nLizard eats Paper\nPaper disproves Spock\nSpock vaporizes Rock");
            Console.ReadLine();
            Console.WriteLine("Press enter to begin playing!");
            Console.ReadLine();
        }

        public void RunGame (int player1Total, int player2Total) 
        {
            while (player1Total < 3 && player2Total < 3) 
            {
                GetResult(player1, player2);
                DetermineWinner(player1, player2);
                CheckForWin(player1.total, player2.total);

                if (player1.total == 3 || player2.total == 3) {
                    break;
                }
            }

            Console.WriteLine("Match Over!");
            Console.ReadLine();
        }


        public Player GetNewPlayer(Player player, bool isPlayer1) 
        {
            string playerType;
            string welcome;


            welcome = isPlayer1 ? "What type of player is Player 1? Please Choose 'human' or 'computer'." : "What type of player is Player 2? Please Choose 'human' or 'computer'.";
            Console.WriteLine(welcome);


            playerType = Console.ReadLine().ToLower();

            switch (playerType) 
            {
                case "human":
                    player = new Human();
                    player.name = isPlayer1 ? "Player 1" : "Player 2";
                    Console.WriteLine("Created new human player for " + player.name + ".");
                    Console.ReadLine();
                    break;
                case "computer":
                    player = new Computer();
                    player.name = isPlayer1 ? "Player 1" : "Player 2";
                    Console.WriteLine("Created new computer for " + player.name + ".");
                    Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("Whoops! Please choose 'human' or 'computer'. Press enter to try again.");
                    Console.ReadLine();
                    GetNewPlayer(player, isPlayer1);
                    break;
            }

            return player;


        }

        public void GetResult (Player player1, Player player2) 
        {
            Console.WriteLine("Round {0}:", round);
            player1.choice = player1.ChooseGesture(gestures, player1);
            player2.choice = player2.ChooseGesture(gestures, player2);
            round++;
        }

        public void DetermineWinner (Player player1, Player player2) 
        {
            int totalChoiceIndex;
            int player1ChoiceIndex;
            int player2ChoiceIndex;

            player1ChoiceIndex = gestures.IndexOf(player1.choice);
            player2ChoiceIndex = gestures.IndexOf(player2.choice);
    

            totalChoiceIndex = (5 + player1ChoiceIndex - player2ChoiceIndex) % 5;

            if (totalChoiceIndex == 0)
            {
                Console.WriteLine("It's a tie! Let's start the next round.");
            }
            else if (totalChoiceIndex % 2 == 0) 
            {
                Console.WriteLine("Player 2 has won the round!");
                player2.IncreaseTotal();
            }
            else 
            {
                Console.WriteLine("Player 1 has won the round!");
                player1.IncreaseTotal();
            }

        }

        public void CheckForWin (int player1Total, int player2Total) 
        {
            string finalScore;
            if (player1Total == 3) 
            {
                finalScore = "Player 1 wins the match with 3 points!!";
                Console.ReadLine();
            }
            else if (player2Total == 3) 
            {
                finalScore =  "Player 2 wins the match with 3 points!!";
                Console.ReadLine();
            }
            else 
            {
                finalScore = "No winner yet! Keep playing!";
                Console.ReadLine();
            }
            Console.WriteLine(finalScore);
        }


    }
}
