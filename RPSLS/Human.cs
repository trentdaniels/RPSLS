using System;
namespace RPSLS
{
    public class Human : Player
    {
        // Members

        // Constructors
        public Human()
        {
        }

        // Methods
        public override string ChooseGesture () {
            string userGesture;

            Console.WriteLine("Which gesture would you like to use? Please choose from 'rock', 'paper' 'scissors' 'lizard', or 'spock'");
            userGesture = Console.ReadLine().ToLower();

            if (userGesture != "rock" && userGesture != "paper" && userGesture != "scissors" && userGesture != "lizard" && userGesture != "spock")
            {
                Console.WriteLine("Invalid gesture. Please try again!");
                ChooseGesture();
            }
            return userGesture;
        }
    }

}
