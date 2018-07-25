using System;
using System.Collections.Generic;

namespace RPSLS
{
    public class Computer : Player
    {
        // Members
        private Random random;
        public string type;

        // Constructors
        public Computer()
        {
            random = new Random();
            type = "computer";
        }

        // Methods
        public override string ChooseGesture(List<string>gestures, Player player)
        {
            string computerGesture;

            computerGesture = gestures[random.Next(0, 5)];
            Console.WriteLine(player.name + " chose {0} ", computerGesture);
            Console.ReadLine();
            return computerGesture;
            
        }
    }
}
