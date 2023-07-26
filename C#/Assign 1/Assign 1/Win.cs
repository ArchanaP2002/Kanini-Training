using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign_1
{
    internal class Win
    {
        private int wins;
          private int draws;
        private int losses;

        public int Wins { get => wins; set => wins = value; }
         public int Draws { get => draws; set => draws = value; }
        public int Losses { get => losses; set => losses = value; }
        public static int CalculatePoints(int wins, int draws, int losses)
        {
            int totalPoints = 0;

            // Calculate points for wins
            if (wins > 0)
            {
                totalPoints += wins * 3;
            }

            // Calculate points for draws
            if (draws > 0)
            {
                totalPoints += draws * 1;
            }

            // Calculate points for losses (always 0 points)
            if (losses > 0)
            {
                // do nothing
            }

            return totalPoints;
        }
 
    }
}
 
