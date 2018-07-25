using System;
using System.Collections.Generic;

namespace RPSLS
{
    public class Computer : Player
    {
        // Members
        private Random random;
        private string type;

        // Constructors
        public Computer(string type)
        {
            random = new Random();
            this.type = type;
        }

        // Methods
        public override string ChooseGesture()
        {
            string computerGesture;
            List<string> gestures;


            gestures = new List<string>() { "rock", "paper", "scissors", "lizard", "spock" };
            computerGesture = gestures[random.Next(0, 5)];
            Console.WriteLine("The computer chose {0} ", computerGesture);
            Console.ReadLine();
            return computerGesture;
            
        }
    }
}
