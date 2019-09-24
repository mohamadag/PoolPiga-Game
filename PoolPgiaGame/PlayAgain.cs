using System;
using System.Windows.Forms;

namespace PoolPgiaGame
{
    public partial class PlayAgain : Form
    {
        public PlayAgain()
        {
            InitializeComponent();   
        }

        private void buttonYes_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
            Game.Board.Hide();
            Game.Board.Close();
            Game game = new Game();
        }

        private void ButtonNo_Click(object sender, EventArgs e)
        {
            Game.Board.Hide();
            Game.Board.Close();
            this.Hide();
            this.Close();
            MessageBox.Show("Good Bye");
        }
    }
}
