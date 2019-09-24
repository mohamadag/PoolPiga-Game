using System.Windows.Forms;
using System.Drawing;

namespace PoolPgiaGame
{
    public class ComputerSelectionButton : Button
    {
       private readonly Color r_ComputerRandomColorSelection;

        public ComputerSelectionButton(int i_SerialNumberInRow)
        {
            this.Enabled = false;
            this.BackColor = Color.Black;
            this.SetBounds(
                GameElements.InitialButtonLeftLocation + (i_SerialNumberInRow * (GameElements.ButtonWidht + GameElements.Delta)),
                GameElements.InitialComputerSelectionButtonTop, 
                GameElements.ButtonWidht, 
                GameElements.ButtonHeight);
            r_ComputerRandomColorSelection = GameManger.GetRandomColor();
        }

        public Color ComputerRandomColorSelection
        {
            get { return this.r_ComputerRandomColorSelection; }
        }
    }
}
