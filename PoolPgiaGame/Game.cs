namespace PoolPgiaGame
{
    public class Game
    {
       private static GameBoard m_board;
       private static int m_RoundsNumber;
       private MainForm m_MainForm;

        public Game()
        {
            m_MainForm = new MainForm();
            m_MainForm.ShowDialog();
        }

        public static GameBoard Board
        {
            get { return m_board; }
        }

        public static void GameRun(int i_NumberOfChansess)
        {
            m_RoundsNumber = i_NumberOfChansess;
            m_board = new GameBoard(i_NumberOfChansess);
            GameManger.SetButtonsToEnable(m_board.GetInteractiveGameBoradButtonsInRound(0));
            m_board.ShowDialog();
        }
 
        public static int RoundsNumber
        {
            get { return m_RoundsNumber; }
        }
    }
}
