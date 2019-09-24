using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;

namespace PoolPgiaGame
{
    public class GameManger
    {
        private static Random rnd = new Random();
        private static List<Color> m_ComputerSelectionToRandomColors  = new List<Color>();
        private static Color[] s_ChosenColorsInOneRound = new Color[GameElements.NumberOfButtonsInRow];

        public static Color GetRandomColor()
        {
            int index = 0;
           Color color;
           do
           {
             index = rnd.Next(0, GameElements.GameColors.Length);
             color = GameElements.GameColors[index];
            }
            while (m_ComputerSelectionToRandomColors.Contains(color));
            m_ComputerSelectionToRandomColors.Add(color);
            return color;
        }

        public static void PreparingToStartGame(int i_PlayerSelectionOfChancesNumber)
        {
            m_ComputerSelectionToRandomColors = new List<Color>();
            Game.GameRun(i_PlayerSelectionOfChancesNumber);
        }

        public static void SetButtonsToEnable(List<InteractiveGameBoardButton> i_Buttons)
        {
            for(int i = 0; i < GameElements.NumberOfButtonsInRow; i++)
            {
                i_Buttons[i].Enabled = true;
            }
        }

        public static void SetButtonsToDisable(List<InteractiveGameBoardButton> i_Buttons)
        {
            for (int i = 0; i < GameElements.NumberOfButtonsInRow; i++)
            {
                i_Buttons[i].Enabled = false;
            }
        }

        public static void ReportRoundResult(List<InteractiveGameBoardButton> i_PlayerSelection, List<ComputerSelectionButton> i_ComputerPassWord, int i_RoundNumber)
        {
            List<Button> resultButtons = Game.Board.GetResultButtonsInRound(i_RoundNumber);
            checkColorsInPlace(i_PlayerSelection, i_ComputerPassWord, resultButtons);
            bool winner = checkWinnerState(resultButtons);
            if (winner || i_RoundNumber + 1 == Game.RoundsNumber)
            {
                showRandomComputerSelection(i_ComputerPassWord);
                if (winner)
                {
                    MessageBox.Show("Congratulations You Win!");
                }
                else
                {
                    MessageBox.Show("You Lost Try Again!");
                }

                PlayAgain playAgain = new PlayAgain();
                playAgain.ShowDialog();
            }
            else
            {
                GameManger.SetButtonsToEnable(Game.Board.GetInteractiveGameBoradButtonsInRound(i_RoundNumber + 1));
            }
        }

        public static Color[] ChosenColorsInOneRound
        {
            get { return s_ChosenColorsInOneRound; }
            set { s_ChosenColorsInOneRound = value; }
        }

        public static int HowManyColorsChosenInRound()
        {
            int numberOfColorsInRound = 0;
            foreach(Color color in s_ChosenColorsInOneRound)
            {
                if(color.IsEmpty == false)
                {
                    numberOfColorsInRound++;
                }
            }

            return numberOfColorsInRound;
        }

        private static void checkColorsInPlace(
            List<InteractiveGameBoardButton> i_PlayerSelection, 
            List<ComputerSelectionButton> i_ComputerPassWord, 
            List<Button> i_ResultButtons)
        {
            int index = 0;
            for(int i = 0; i < GameElements.NumberOfButtonsInRow; i++)
            {
                if(i_PlayerSelection[i].BackColor == i_ComputerPassWord[i].ComputerRandomColorSelection)
                {
                    i_ResultButtons[index++].BackColor = Color.Black;
                }
            }

            for(int i = 0; i < GameElements.NumberOfButtonsInRow; i++)
            {
                for(int j = 0; j < GameElements.NumberOfButtonsInRow; j++)
                {
                    if(i_PlayerSelection[i].BackColor == i_ComputerPassWord[j].ComputerRandomColorSelection && i != j)
                    {
                        i_ResultButtons[index++].BackColor = Color.Yellow;
                    }
                }
            }
        }

        private static bool checkWinnerState(List<Button> i_ResultButtons)
        {
            int counter = 0;
            bool result = false;
            for(int i = 0; i < i_ResultButtons.Count; i++)
            {
                if(i_ResultButtons[i].BackColor == Color.Black)
                {
                    counter++;
                }
            }

            if(counter == i_ResultButtons.Count)
            {
                result = true;
            }

            return result;
        }

        private static void showRandomComputerSelection(List<ComputerSelectionButton> i_ComputerRandomSelection)
        {
            foreach (ComputerSelectionButton randomCompuerChoice in i_ComputerRandomSelection)
            {
                randomCompuerChoice.BackColor = randomCompuerChoice.ComputerRandomColorSelection;
            }
        }

        public static bool CheckIfColorChosedBefor(Color i_PlayerSelection)
        {
            bool result = false;
            for(int i = 0; i < s_ChosenColorsInOneRound.Length; i++)
            {
                if (i_PlayerSelection == s_ChosenColorsInOneRound[i])
                {
                    result = true;
                    break;
                }
            }

            return result;
        }
    }
}
