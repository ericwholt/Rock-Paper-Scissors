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
            SetUserName();
        }
        public override Roshambo GenerateRoshambo()
        {
           return GetChoiceFromUser("Choose (R)ock (P)aper (S)cissor: ", 0, 2);
        }

        private void SetUserName()
        {
            this.Name = Validator.GetUserName();
        }

        //TODO: move to validator class
        public Roshambo GetChoiceFromUser(string message, int min, int max)
        {
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
                return GetChoiceFromUser(message, min, max);
            }
        }
    }
}
