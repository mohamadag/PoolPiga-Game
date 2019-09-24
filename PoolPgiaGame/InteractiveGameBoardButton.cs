using System;
using System.Drawing;
using System.Windows.Forms;

namespace PoolPgiaGame
{
    public class InteractiveGameBoardButton : Button
    {
        private readonly int m_row;
        private readonly int m_column;

        public InteractiveGameBoardButton(int i_ButtonRow, int i_ButtonColumn)
        {   
            this.SetBounds(
                    GameElements.InitialButtonLeftLocation + (i_ButtonColumn * (GameElements.ButtonHeight + GameElements.Delta)),
                    GameElements.InitilaTop + (i_ButtonRow * (GameElements.ButtonHeight + GameElements.Delta)),
                    GameElements.ButtonWidht, 
                    GameElements.ButtonHeight);
           this.Enabled = false;
            m_row = i_ButtonRow;
            m_column = i_ButtonColumn;
        }

        protected override void OnClick(EventArgs e)
        {
            ColorsMenu colorsMenu = new ColorsMenu();
            colorsMenu.ShowDialog();
            Color playerSelectionColor = colorsMenu.PlayerSelectedColor;
            if (playerSelectionColor != Color.Empty)
            {
                if (GameManger.CheckIfColorChosedBefor(playerSelectionColor) 
                    && playerSelectionColor != this.BackColor)
                {  
                    MessageBox.Show("This Color Chosen Befor!");
                }
                else
                {
                    GameManger.ChosenColorsInOneRound[m_column] = playerSelectionColor;
                    this.BackColor = playerSelectionColor;
                    if (GameManger.HowManyColorsChosenInRound() == GameElements.NumberOfButtonsInRow)
                    {
                        GameBoard.m_FeedBackButtons[m_row].Enabled = true;
                    }
                }
            } 
        }
    }
}