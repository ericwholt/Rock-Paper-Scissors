using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock_Paper_Scissors
{
    class Rocky : Player
    {
        public Rocky()
        {
            Name = "Rocky";
        }
        public override Roshambo GenerateRoshambo()
        {
            return Roshambo.Rock;
        }
    }
}
