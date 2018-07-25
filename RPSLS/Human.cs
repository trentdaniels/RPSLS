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
        public override string ChooseGesture (List<string> gestures, Player player) 
        {
            string userGesture;
            bool isValidGesture;

            Console.WriteLine("Please choose from the following:\nRock\nPaper\nScissors\nLizard\nSpock");
            userGesture = Console.ReadLine().ToLower();
            isValidGesture = gestures.Contains(userGesture);

            if (isValidGesture) 
            {
                Console.WriteLine("You chose {0}.", userGesture);
                Console.ReadLine();

            }
            else 
            {
                Console.WriteLine("Invalid input. Please try again");
                Console.ReadLine();
                ChooseGesture(gestures, player);

            }
            return userGesture;


        }
    }

}
