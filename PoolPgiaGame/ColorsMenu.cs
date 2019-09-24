using System;
using System.Drawing;
using System.Windows.Forms;

namespace PoolPgiaGame
{
    public partial class ColorsMenu : Form
    {  
        private Color m_PlayerColorSelection;

        public ColorsMenu()
        {
            InitializeComponent();
        }

        private void buttonFuchsia_Click(object sender, EventArgs e)
        {
            m_PlayerColorSelection = (sender as Button).BackColor;
            this.Close();
        }

        private void buttonRed_Click(object sender, EventArgs e)
        {
            m_PlayerColorSelection = (sender as Button).BackColor;   
            this.Close();
        }

        private void buttonLime_Click(object sender, EventArgs e)
        {
            m_PlayerColorSelection = (sender as Button).BackColor;
            this.Close();
        }

        private void buttonAqua_Click(object sender, EventArgs e)
        {
            m_PlayerColorSelection = (sender as Button).BackColor;
            this.Close();
        }

        private void buttonBlue_Click(object sender, EventArgs e)
        {
            m_PlayerColorSelection = (sender as Button).BackColor;
            this.Close();
        }

        private void buttonYellow_Click(object sender, EventArgs e)
        {
            m_PlayerColorSelection = (sender as Button).BackColor;
            this.Close();
        }

        private void buttonMaroon_Click(object sender, EventArgs e)
        {
            m_PlayerColorSelection = (sender as Button).BackColor;
            this.Close();
        }

        private void buttonWhite_Click(object sender, EventArgs e)
        {
            m_PlayerColorSelection = (sender as Button).BackColor;
            this.Close();
        }

        public Color PlayerSelectedColor
        {
            get { return this.m_PlayerColorSelection; }
        }
    }
}
