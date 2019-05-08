using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock_Paper_Scissors
{
    static class Validator
    {
        public static string GetUserName()
        {
            Console.Write("Enter your name: ");
            string userName = Console.ReadLine().Trim();
            if (userName.Length < 1)
            {
                Console.WriteLine("You must enter a name!");
                return GetUserName();
            }

            return userName;
        }

        public static bool GetYesOrNoFromUser(string prompt)
        {
            Console.WriteLine(prompt.Trim() + " (Yes or No)");
            string answer = Console.ReadLine().ToLower().Trim();
            if (answer == "y" || answer == "yes")
            {
                return true;
            }
            else if (answer == "n" || answer == "no")
            {
                return false;
            }
            else
            {
                Console.WriteLine("Invalid Input!");
                return GetYesOrNoFromUser(prompt);

            }
        }

        public static Player GetOpponentFromUser(string message, Player rocky, Player randy)
        {
            Console.Write(message);
            try
            {
                string userInput = Console.ReadLine().ToLower().Trim();
                if (userInput == "rocky")
                {
                    return rocky;
                }
                else if (userInput == "randy")
                {
                    return randy;
                }
                else
                {
                    throw new Exception($"Invalid opponent name. You must choose Rocky or Randy");
                }


            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
                return GetOpponentFromUser(message, rocky, randy);
            }
        }
    }
}
