using System;
namespace RPSLS
{
    public abstract class Player
    {
        // Members
        public int total;

        //Constructor
        public Player()
        {
            total = 0;
        }

        //Methods
        public abstract string ChooseGesture();

    }
}
