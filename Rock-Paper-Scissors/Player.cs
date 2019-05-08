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
        public string Name;

        public Roshambo Roshambo;

        public abstract Roshambo GenerateRoshambo();

        public int Wins = 0;
        public int Losses = 0;
        public int Draws = 0;
    }
}
