using System;
using System.Windows.Forms;

namespace PoolPgiaGame
{
    public partial class MainForm : Form
    {
        private int m_NumberOfPlayerChances = GameElements.MinChansesNumber;
   
        public MainForm()
        {
            InitializeComponent();
            this.buttonGetNumberOfChancess.Text = string.Format("Number Of Chances: {0}", m_NumberOfPlayerChances);
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
            GameManger.PreparingToStartGame(m_NumberOfPlayerChances);      
        }

        private void buttonIncrease_Click(object sender, EventArgs e)
        {
            m_NumberOfPlayerChances++;
            if(m_NumberOfPlayerChances == GameElements.MaxChansesNumber + 1)
            {
                m_NumberOfPlayerChances = GameElements.MinChansesNumber;
            }

            this.buttonGetNumberOfChancess.Text = string.Format("Number Of Chances: {0}", m_NumberOfPlayerChances);   
        }
    }
}
