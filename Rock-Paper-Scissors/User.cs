using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock_Paper_Scissors
{
    class User : Player
    {
        public User()
        {
            Name = Validator.GetUserName();
        }

        public override Roshambo GenerateRoshambo()
        {
           return GetRPSFromUser();
        }

        public Roshambo GetRPSFromUser()
        {
            string message = "Choose (R)ock (P)aper (S)cissor: ";
            int min = 0;
            int max = 2;
            Console.Write(message);
            try
            {
                string userInput = Console.ReadLine().ToLower();
                if (userInput == "r" || userInput == "rock")
                {
                    return Roshambo.Rock;
                }
                else if(userInput == "p" || userInput == "paper")
                {
                    return Roshambo.Paper;
                }
                else if(userInput == "s" || userInput == "scissor")
                {
                    return Roshambo.Scissor;
                }
                else
                {
                    throw new Exception($"Invalid input. You must choose (R)ock, (P)aper, or (S)cissor");
                }


            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
                return GetRPSFromUser();
            }
        }
    }
}
