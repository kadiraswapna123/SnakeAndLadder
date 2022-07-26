using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    public class PositionOfTheDie
    {
        static int maxGameByWinner(int N)
        {
            int[] dp = new int[N];

            // for 0 games, 1 player is needed
            // for 1 game, 2 players are required
            dp[0] = 1;
            dp[1] = 2;

            int i = 2;

            do
            {
                dp[i] = dp[i - 1] + dp[i - 2];
            } while (dp[i++] <= N);

            return (i - 2);
        }

        // Driver code
        public static void Main()
        {
            int N = 10;
            Console.Write(maxGameByWinner(N));
        }
    }
}

