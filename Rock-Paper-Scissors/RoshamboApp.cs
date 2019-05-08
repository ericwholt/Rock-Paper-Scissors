using System;

namespace Rock_Paper_Scissors
{
    class RoshamboApp
    {
        public Player Opponent { get; private set; }
        public Rocky rocky = new Rocky();
        public Randy randy = new Randy();
        public User user = new User();

        public void Run()
        {

            bool run = true;
            //User user = new User();
            while (run)
            {
                Opponent = SelectOpponent(rocky, randy);//Challenge opponent
                user.Roshambo = user.GenerateRoshambo();//Get users rock, paper scissors choice
                Opponent.Roshambo = Opponent.GenerateRoshambo();//Get current opponents rock, paper, scissors choice
                PrintResults();//Print results of Roshambo Battle
                run = Validator.GetYesOrNoFromUser("Play again");
            }
            PrintSessionResults();
            Console.Write("Press any key to continue...");
            Console.ReadKey();

        }

        private void PrintSessionResults()
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine($"{AddSpacesToString("Name", 15)}{AddSpacesToString("Wins", 7)}{AddSpacesToString("Losses", 7)}{AddSpacesToString("Draws", 7)}");
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine($"{AddSpacesToString(user.Name, 15)}{AddSpacesToString(user.Wins.ToString(), 7)}{AddSpacesToString(user.Losses.ToString(), 7)}{AddSpacesToString(user.Draws.ToString(), 7)}");
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine($"{AddSpacesToString(rocky.Name, 15)}{AddSpacesToString(rocky.Wins.ToString(), 7)}{AddSpacesToString(rocky.Losses.ToString(), 7)}{AddSpacesToString(rocky.Draws.ToString(), 7)}");
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine($"{AddSpacesToString(randy.Name, 15)}{AddSpacesToString(randy.Wins.ToString(), 7)}{AddSpacesToString(randy.Losses.ToString(), 7)}{AddSpacesToString(randy.Draws.ToString(), 7)}");
            Console.ResetColor();
        }

        /// <summary>
        /// Display Results.
        /// </summary>
        private void PrintResults()
        {
            int consoleWidth = (int)Math.Ceiling((double)(Console.WindowWidth-1));
            for (int i = 0; i < 3; i++)
            {
                switch (i)
                {
                    case 0:
                        System.Threading.Thread.Sleep(300);
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine(AddSpacesToFrontBackString("RO", consoleWidth));
                        Console.ResetColor();
                        break;
                    case 1:
                        System.Threading.Thread.Sleep(300);
                        Console.BackgroundColor = ConsoleColor.DarkYellow;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine(AddSpacesToFrontBackString("SHAM", consoleWidth  ));
                        Console.ResetColor();
                        break;
                    case 2:
                        System.Threading.Thread.Sleep(300);
                        Console.BackgroundColor = ConsoleColor.DarkGreen;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine(AddSpacesToFrontBackString("BO", consoleWidth    ));
                        Console.ResetColor();
                        break;
                }
            }
            Player winner = FindWinner(Opponent, user);
            //int consoleWidth = Console.WindowWidth - 1;

            int consoleWidthHalf = (consoleWidth / 2)+1;
            int consoleWidthSecondHalf = consoleWidthHalf-1;         

            if (winner == null)
            {
                Console.ResetColor();
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write($"{AddSpacesToFrontBackString(Opponent.Name, consoleWidthHalf)}");
                Console.ResetColor();
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"{AddSpacesToFrontBackString(user.Name, consoleWidthSecondHalf)}");
                Console.ResetColor();
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write($"{AddSpacesToFrontBackString(Opponent.Roshambo.ToString(), consoleWidthHalf)}");
                Console.ResetColor();
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"{AddSpacesToFrontBackString(user.Roshambo.ToString(), consoleWidthSecondHalf)}");
                Console.ResetColor();
                Console.WriteLine();
                Console.BackgroundColor = ConsoleColor.DarkYellow;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(AddSpacesToFrontBackString("DRAW DRAW DRAW DRAW DRAW DRAW DRAW DRAW DRAW DRAW DRAW DRAW DRAW DRAW", consoleWidth));
                Console.ResetColor();
            }
            else if (winner == Opponent)
            {
                Console.ResetColor();
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write($"{AddSpacesToFrontBackString(Opponent.Name, consoleWidthHalf)}");
                Console.ResetColor();
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"{AddSpacesToFrontBackString(user.Name, consoleWidthSecondHalf)}");
                Console.ResetColor();
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write($"{AddSpacesToFrontBackString(Opponent.Roshambo.ToString(), consoleWidthHalf)}");
                Console.ResetColor();
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"{AddSpacesToFrontBackString(user.Roshambo.ToString(), consoleWidthSecondHalf)}");
                Console.ResetColor();
                Console.WriteLine();
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(AddSpacesToFrontBackString("LOSE LOSE LOSE LOSE LOSE LOSE LOSE LOSE LOSE LOSE LOSE LOSE LOSE LOSE LOSE LOSE LOSE LOSE LOSE", consoleWidth));
                Console.ResetColor();
            }
            else
            {
                Console.ResetColor();
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write($"{AddSpacesToFrontBackString(Opponent.Name, consoleWidthHalf)}");
                Console.ResetColor();
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"{AddSpacesToFrontBackString(user.Name, consoleWidthSecondHalf)}");
                Console.ResetColor();
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write($"{AddSpacesToFrontBackString(Opponent.Roshambo.ToString(), consoleWidthHalf)}");
                Console.ResetColor();
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"{AddSpacesToFrontBackString(user.Roshambo.ToString(), consoleWidthSecondHalf)}");
                Console.ResetColor();
                Console.WriteLine();
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(AddSpacesToFrontBackString("WIN WIN WIN WIN WIN WIN WIN WIN WIN WIN WIN WIN WIN WIN WIN WIN WIN WIN WIN", consoleWidth));
                Console.ResetColor();
            }
        }

        private Player SelectOpponent(Player rocky, Player randy)
        {

            return Validator.GetOpponentFromUser("Please choose an opponent Rocky or Randy: ", rocky, randy);
        }

        /// <summary>
        /// Handles logic for determining which Player's Roshambo wins.
        /// </summary>
        /// <param name="first">Player</param>
        /// <param name="second">Player</param>
        /// <returns>Player</returns>
        private Player FindWinner(Player first, Player second)
        {
            if (first.Roshambo == second.Roshambo)
            {
                first.Draws++;
                second.Draws++;
                return null;
            }
            else if (first.Roshambo == Roshambo.Rock)
            {
                if (second.Roshambo == Roshambo.Scissor)
                {
                    first.Wins++;
                    second.Losses++;
                    return first;
                }
                else
                {
                    second.Wins++;
                    first.Losses++;
                    return second;
                }
            }
            else if (first.Roshambo == Roshambo.Paper)
            {
                if (second.Roshambo == Roshambo.Rock)
                {
                    first.Wins++;
                    second.Losses++;
                    return first;
                }
                else
                {
                    second.Wins++;
                    first.Losses++;
                    return second;
                }
            }
            else if (first.Roshambo == Roshambo.Scissor)
            {
                if (second.Roshambo == Roshambo.Paper)
                {
                    first.Wins++;
                    second.Losses++;
                    return first;
                }
                else
                {
                    second.Wins++;
                    first.Losses++;
                    return second;
                }
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Returns string with spaces on right side equal to string length minus int number of spaces.
        /// </summary>
        /// <param name="str">string</param>
        /// <param name="numberOfSpaces">int</param>
        /// <returns>string</returns>
        private string AddSpacesToString(string str, int numberOfSpaces)
        {
            {
                int leng = numberOfSpaces - str.Length;
                for (int i = 0; i < leng; i++)
                {
                    str += " ";
                }
                return str;
            }
        }

        private string AddSpacesToFrontBackString(string str, int numberOfSpaces)
        {
            {
                //while (str.Length < 4)
                //{
                //    str += " ";
                //}

                string tempStr = "";
                int halfString;
                int strLength = 0;
                if (str.Length % 2 == 1)
                {

                    strLength = str.Length + 1                        ;
                }
                else
                {
                    strLength = str.Length;
                }
                halfString = strLength / 2;
                int numberOfSpacesEven;
                if (numberOfSpaces % 2 == 1)
                {
                    numberOfSpacesEven = numberOfSpaces -1;
                }
                else
                {
                    numberOfSpacesEven = numberOfSpaces;
                }
                int halfSpaces = numberOfSpacesEven / 2;
                //int leng = halfSpaces - str.Length;
                for (int i = 0; i < halfSpaces - halfString; i++)
                {
                    tempStr += " ";
                }
                //for (int k = 0; k < remainspaces; k++)
                //{
                //    tempStr += " ";
                //}
                tempStr += str.Trim();
                for (int j = 0; j < halfSpaces - halfString; j++)
                {
                    tempStr += " ";
                }
                if(tempStr.Length - numberOfSpaces < 0 )
                {
                    tempStr += " ";
                }

                return tempStr;
            }
        }
    }
}
