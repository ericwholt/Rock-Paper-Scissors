using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock_Paper_Scissors
{
    class Randy : Player
    {
        Random rnd = new Random();

        public Randy()
        {
            Name = "Randy";
        }

        public override Roshambo GenerateRoshambo()
        {
            
            return (Roshambo)rnd.Next(0, 3);
        }
    }
}
