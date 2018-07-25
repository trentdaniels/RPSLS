﻿using System;
using System.Collections.Generic;

namespace RPSLS
{
    public class Game
    {
        // Members
        Player player1;
        Player player2;
        List<string> gestures;


        // Constructors
        public Game()
        {
            DisplayWelcome();
            player1 = GetNewPlayer(player1, true);
            player2 = GetNewPlayer(player2 , false);
            gestures = new List<string>() { "rock", "paper", "scissors", "lizard", "spock" };

            Console.WriteLine(GetResult(player1, player2));
            Console.WriteLine(CheckForWin(player1.total, player2.total));
        }

        // Methods
        public void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the classic game of Rock Paper Scissors Lizard Spock");
            Console.WriteLine("The rules are simple. You choose a result against your opponent and a result occurs.");
            Console.ReadLine();
            Console.WriteLine("Rock crushes Scissors\nScissors cuts Paper\nPaper covers Rock\nRock crushes Lizard\nLizard poisons Spock\nSpock smashes Scissors" +
                              "\nScissors decapitates Lizard\nLizard eats Paper\nPaper disproves Spock\nSpock vaporizes Rock");
            Console.ReadLine();
            Console.WriteLine("Press enter to begin playing!");
            Console.ReadLine();
        }


        public Player GetNewPlayer(Player player, bool isPlayer1) {
            string playerType;
            string welcome;


            welcome = isPlayer1 ? "What type of player is Player 1? Please Choose 'human' or 'computer'." : "What type of player is Player 2? Please Choose 'human' or 'computer'.";
            Console.WriteLine(welcome);


            playerType = Console.ReadLine().ToLower();

            switch (playerType) {
                case "human":
                    player = new Human();
                    Console.WriteLine("Created new human player for this player");
                    Console.ReadLine();
                    break;
                case "computer":
                    player = new Computer();
                    Console.WriteLine("Created new computer for this player");
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
        public string GetResult (Player player1, Player player2) {
            string result;


            player1.choice = player1.ChooseGesture(gestures, player1);
            player2.choice = player2.ChooseGesture(gestures, player2);

            result = "string";
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
