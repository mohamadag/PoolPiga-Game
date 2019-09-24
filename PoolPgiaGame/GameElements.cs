using System.Drawing;

namespace PoolPgiaGame
{
    public class GameElements
    {
        private static readonly Color[] sr_GameColors =
            {
            Color.Fuchsia,
            Color.Red,
            Color.Lime,
            Color.Aqua,
            Color.Blue,
            Color.Yellow,
            Color.Maroon,
            Color.White
        };

        private static readonly int sr_InitialComputerSelectionButtonTop = 10;
        private static readonly int sr_InitialButtonLeftLocation = 10;
        private static readonly int sr_Delta = 5;
        private static readonly short sr_ButtonWidht = 40;
        private static readonly short sr_ButtonHeight = 40;
        private static readonly int sr_InitilaTop = sr_ButtonHeight * 2;
        private static readonly short sr_NumberOfButtonsInRow = 4;
        private static readonly int sr_RnadomPasswordLength = 4;
        private static readonly int sr_FeedBackButtonWidth = 40;
        private static readonly int sr_FeedBackButtonHeight = 20;
        private static readonly int sr_ResultButtonWidth = 15;
        private static readonly int sr_ResultButtonHeight = 15;
        private static readonly int sr_ResultButtonRowsNumber = 2;
        private static readonly int sr_ResultButtonColumnNumber = 2;
        private static readonly int sr_MaxChansesNumber = 10;
        private static readonly int sr_MinChansesNumber = 4;
        private static readonly int sr_ResultButtonInitialLeftPosition = InitialButtonLeftLocation +
                        (sr_NumberOfButtonsInRow * ButtonWidht) +
                        (sr_NumberOfButtonsInRow * Delta) + sr_FeedBackButtonWidth + (Delta * 2);

       private static readonly int sr_FeedBackButtonInitialleftLocation = InitialButtonLeftLocation +
            (sr_NumberOfButtonsInRow * (ButtonWidht + Delta));

        private static readonly int sr_FeedBackButtonInitialtopLocation = sr_InitilaTop +
            ButtonHeight - sr_FeedBackButtonHeight - (Delta * 2);

        public static int InitialComputerSelectionButtonTop
        {
            get { return sr_InitialComputerSelectionButtonTop; }
        }

        public static Color[] GameColors
        {
            get { return sr_GameColors; }
        }

        public static int InitialButtonLeftLocation
        {
            get { return sr_InitialButtonLeftLocation; }
        }

        public static int Delta
        {
            get { return sr_Delta; }
        }

        public static short ButtonWidht
        {
            get { return sr_ButtonWidht; }
        }

        public static short ButtonHeight
        {
            get { return sr_ButtonHeight; }
        }

        public static int InitilaTop
        {
            get { return sr_InitilaTop; }
        }

        public static short NumberOfButtonsInRow
        {
            get { return sr_NumberOfButtonsInRow; }
        }

        public static int RnadomPasswordLength
        {
            get { return sr_RnadomPasswordLength; }
        }

        public static int FeedBackButtonWidth
        {
            get { return sr_FeedBackButtonWidth; }
        }

        public static int FeedBackButtonHeight
        {
            get { return sr_FeedBackButtonHeight; }
        }

        public static int ResultButtonWidth
        {
            get { return sr_ResultButtonWidth; }
        }

        public static int ResultButtonHeight
        {
            get { return sr_ResultButtonHeight; }
        }

        public static int ResultButtonRowsNumber
        {
            get { return sr_ResultButtonRowsNumber; }
        }

        public static int ResultButtonColumnNumber
        {
            get { return sr_ResultButtonColumnNumber; }
        }

        public static int MaxChansesNumber
        {
            get { return sr_MaxChansesNumber; }
        }

        public static int MinChansesNumber
        {
            get { return sr_MinChansesNumber; }
        }

        public static int ResultButtonInitialLeftPosition
        {
            get { return sr_ResultButtonInitialLeftPosition; }
        }

        public static int FeedBackButtonInitialleftLocation
        {
            get { return sr_FeedBackButtonInitialleftLocation; }
        }

        public static int FeedBackButtonInitialtopLocation
        {
            get { return sr_FeedBackButtonInitialtopLocation; }
        }
    }  
}
