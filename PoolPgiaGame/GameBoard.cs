using System.Collections.Generic;
using System.Windows.Forms;

namespace PoolPgiaGame
{
    public partial class GameBoard : Form
    {
        public static List<FeedBackButton> m_FeedBackButtons;
        private List<List<InteractiveGameBoardButton>> m_InteractiveGameBoardButtons = new List<List<InteractiveGameBoardButton>>();
        private List<ComputerSelectionButton> m_ComputerSelectionButtons = new List<ComputerSelectionButton>();
        private List<List<Button>> m_ResultButtons = new List<List<Button>>();

        public GameBoard(int i_NumberOfChancess)
        {
            m_FeedBackButtons = new List<FeedBackButton>();
            InitializeComponent();
            generalBoardSizeSetups(i_NumberOfChancess);
            generateComputerRandomButtons();
            generateInteractiveGameBoardButtons(i_NumberOfChancess);
            generateFeedBackButtons(i_NumberOfChancess);
            generateResultButtons(i_NumberOfChancess);
        }

        private void generalBoardSizeSetups(int i_NumberOfChancess)
        {
            this.Width = 
                (GameElements.NumberOfButtonsInRow * GameElements.ButtonWidht) +
                GameElements.InitialButtonLeftLocation + 
                (GameElements.Delta * (GameElements.NumberOfButtonsInRow + GameElements.ResultButtonColumnNumber + 1)) + 
                GameElements.FeedBackButtonWidth + 
                (GameElements.ResultButtonWidth * (GameElements.ResultButtonColumnNumber + 1));
            this.Height = ((i_NumberOfChancess + 1) * (GameElements.ButtonHeight + GameElements.Delta))
                + GameElements.InitilaTop;
        }

        private void generateComputerRandomButtons()
        { 
            for(int i = 0; i < GameElements.RnadomPasswordLength; i++)
            {
                m_ComputerSelectionButtons.Add(new ComputerSelectionButton(i));
                this.Controls.Add(m_ComputerSelectionButtons[i]);
            }
        }

        private void generateInteractiveGameBoardButtons(int i_NumberOfChancess)
        {
            for (short row = 0; row < i_NumberOfChancess; row++)
            {
                m_InteractiveGameBoardButtons.Add(new List<InteractiveGameBoardButton>());
                for (int column = 0; column < GameElements.NumberOfButtonsInRow; column++)
                {
                    m_InteractiveGameBoardButtons[row].Add(new InteractiveGameBoardButton(row, column));
                    this.Controls.Add(m_InteractiveGameBoardButtons[row][column]);
                }
            }
        }

        private void generateFeedBackButtons(int i_NumberOfChancess)
        { 
            for (int i = 0; i < i_NumberOfChancess; i++)
            {
                m_FeedBackButtons.Add(new FeedBackButton(i));
                this.Controls.Add(m_FeedBackButtons[i]);
            }
        }

        private void generateResultButtons(int i_NumberOfChancess)
        {
            int top = 0;
            for(int i = 0; i < i_NumberOfChancess; i++)
            {
                top = GameElements.InitilaTop +
                      (i * GameElements.ButtonHeight) +
                      (i * GameElements.Delta);
                m_ResultButtons.Add(new List<Button>());
                for (int row  = 0; row < GameElements.ResultButtonRowsNumber; row++)
                {
                    for(int column = 0; column < GameElements.ResultButtonColumnNumber; column++)
                    {
                        Button btn = new Button();
                        btn.Enabled = false;
                        btn.SetBounds(
                            GameElements.ResultButtonInitialLeftPosition + (column * (GameElements.Delta + GameElements.ResultButtonWidth)), 
                            top, 
                            GameElements.ResultButtonWidth, 
                            GameElements.ResultButtonHeight);
                        m_ResultButtons[i].Add(btn);
                        this.Controls.Add(btn);
                    }

                    top += GameElements.ResultButtonHeight + GameElements.Delta;
                }
            }
        }

        public List<InteractiveGameBoardButton> GetInteractiveGameBoradButtonsInRound(int i_RoundNumber)
        {
            return this.m_InteractiveGameBoardButtons[i_RoundNumber];
        }

        public List<Button> GetResultButtonsInRound(int i_RoundNumber)
        {
            return this.m_ResultButtons[i_RoundNumber];
        }

        public List<ComputerSelectionButton> GetComputerSelectionButtons()
        {
            return this.m_ComputerSelectionButtons;
        }
    }
}
