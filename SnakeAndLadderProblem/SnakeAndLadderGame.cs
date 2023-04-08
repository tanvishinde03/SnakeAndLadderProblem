using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadderProblem
{
    public class SnakeAndLadderGame
    {
        public void PoisitionCheck()
        {
            int player_no = 1;
            int start_position = 0;
            Console.WriteLine("Start Position of Player no {0} is : {1} ", player_no, start_position); //UC1
            Console.ReadLine();
            Random random = new Random();
            int DiceRoll = random.Next(1, 7);
            Console.WriteLine("Dice Number : " + DiceRoll); //UC2
            Console.ReadLine();

        }
    }
}
