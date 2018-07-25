using System;
using System.Collections.Generic;

namespace RPSLS
{
    public abstract class Player
    {
        // Members
        public int total;
        public string choice;


        //Constructor
        public Player()
        {
            
            total = 0;
        }

        //Methods
        public abstract string ChooseGesture(List<string> gestures, Player player);

    }
}
