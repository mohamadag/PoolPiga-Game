using System;
using System.Drawing;
using System.Windows.Forms;

namespace PoolPgiaGame
{
    public class FeedBackButton : Button
    {
        private readonly int r_RoundNumber;

        public FeedBackButton(int i_RoundNumber)
        {
            this.SetBounds(
                GameElements.FeedBackButtonInitialleftLocation, 
                GameElements.FeedBackButtonInitialtopLocation + (i_RoundNumber * (GameElements.ButtonHeight + GameElements.Delta)),
                GameElements.FeedBackButtonWidth,
                GameElements.FeedBackButtonHeight);
            this.Text = "-->>";
            this.Enabled = false;
            r_RoundNumber = i_RoundNumber;
        }

        protected override void OnClick(EventArgs e)
        {  
            GameManger.ChosenColorsInOneRound = new Color[GameElements.NumberOfButtonsInRow];
            GameManger.SetButtonsToDisable(Game.Board.GetInteractiveGameBoradButtonsInRound(r_RoundNumber));
            this.Enabled = false;
            if (Game.RoundsNumber >= r_RoundNumber + 1)
            {
                GameManger.ReportRoundResult(
                    Game.Board.GetInteractiveGameBoradButtonsInRound(r_RoundNumber), 
                    Game.Board.GetComputerSelectionButtons(), 
                    r_RoundNumber);
            }             
        }
    }
}
