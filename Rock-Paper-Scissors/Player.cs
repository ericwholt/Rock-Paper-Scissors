using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock_Paper_Scissors
{
    enum Roshambo
    {
        Rock,
        Paper,
        Scissor
    }
    abstract class Player
    {

        public string Name { get; set; }
        public Roshambo Roshambo { get; set; }
        public int Wins { get; set; }
        public int Losses { get; set; }
        public int Draws { get; set; }

        public Player()
        {
            Wins = 0;
            Losses = 0;
            Draws = 0;
        }

        public abstract Roshambo GenerateRoshambo();
    }
}
