using System;
using System.Collections.Generic;

namespace RPSLS
{
    public class Human : Player
    {
        // Members
        public string type;

        // Constructors
        public Human()
        {
            type = "human";
        }

        // Methods
        public override string ChooseGesture (List<string> gestures, Player player) {
            string userGesture;

            Console.WriteLine("Please choose from the following:\n[1] Rock\n[2] Paper\n[3] Scissors\n[4] Lizard\n[5] Spock");
            userGesture = Console.ReadLine().ToLower();

            foreach (string gesture in gestures) {
                if (userGesture != gesture) {
                    Console.WriteLine("Invalid option");
                    ChooseGesture(gestures, player);
                }
                player.choice = userGesture;
            }

            Console.WriteLine("You chose {0}.", userGesture);
            Console.ReadLine();
            return userGesture;
        }
    }

}
