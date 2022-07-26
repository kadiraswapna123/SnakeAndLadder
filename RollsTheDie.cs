using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    internal class RollsTheDie
    {
        Random random = new Random();
        public int RollStandardDie()
        {
            int dice1 = random.Next(1, 6);
            int dice2 = random.Next(1, 6);
            return dice1 + dice2;
        } 
        int[] dice1 = new int[3];
        int[] dice2 = new int[3];           
        Dictionary<int, int> dice3 = new Dictionary<int, int>();    
    }
    Console.WriteLine(RollStandardDie);
}
