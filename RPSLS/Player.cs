using System;
using System.Collections.Generic;

namespace RPSLS
{
    public abstract class Player
    {
        // Members
        public int total;
        public string choice;
        public string name;


        //Constructor
        public Player()
        {
            
            total = 0;
        }

        //Methods
        public abstract string ChooseGesture(List<string> gestures, Player player);
        public void IncreaseTotal()
        {
            total++;
        }

    }
}
