using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS350MineSweeper
{
    public enum GameState
    {
        NewGame,
        Running,
        GameWon,
        GameLost
    }

    public enum Difficulty
    {
        Easy,
        Medium,
        Hard,
        Custom
    }

    class GameStateController
    {
        //Attributes
        public TimeController timeController;
        public GridController gridController;
        public MineCountController mineCountController;
        public GameState gameState;
        private int width, height, mineCount;
        private MainForm mainForm;
        private Difficulty diff;

        //Constructor
        public GameStateController(MainForm mainForm)
        {
            //Declare attributes
            timeController = new TimeController(mainForm);
            gridController = new GridController(this);
            mineCountController = new MineCountController(mainForm);
            gameState = GameState.NewGame;
            this.mainForm = mainForm;

        }

        /// <summary>
        /// Retrieves difficulty from mainform inputs and stores it
        /// </summary>
        /// <param name="width">Width of the game board</param>
        /// <param name="height">Height of the game board</param>
        /// <param name="mineCount">Number of mines in the game</param>
        public void SetDifficulty(int width, int height, int mineCount, Difficulty diff)
        {
            this.width = width;
            this.height = height;
            this.mineCount = mineCount;
            this.diff = diff;
        }

        /// <summary>
        /// Sends a call to gridcontroller to reset it's parameters and creates a new array of buttons
        /// </summary>
        /// <param name="mainForm">A reference to the main form which contains the game</param>
        public void ResetBoard(MainForm mainForm)
        {

            //Reset gameState
            gameState = GameState.NewGame;
            gridController.ResetBoard();

            //Create new button grid
            Button[,] buttonsArr = ((MainForm)mainForm).CreateButtonArray(this.width, this.height);
            gridController.RecieveButtonArr(buttonsArr, this.width, this.height);

            //TODO: Add Time reset code from controller
            timeController.resetTime();

            //Reset mine counter
            mineCountController.resetCount(mineCount);
            

        }

        /// <summary>
        /// This will be called when first square is clicked in the game
        /// </summary>
        /// <param name="xClick">The x position of the first click of the game</param>
        /// <param name="yClick">The y position of the first click of the game</param>
        public void StartGame(int xClick, int yClick)
        {
            //Generate board
            gridController.GenerateBoard(this.mineCount, xClick, yClick);
            gameState = GameState.Running;
            

            //TODO: Time code and mine count code
            timeController.startTime();


            gridController.RevealSquare(xClick, yClick);
        }

        /// <summary>
        /// This function handles all operations for left clicking a square on the game board
        /// </summary>
        /// <param name="x">And horizontal position of the square clicked</param>
        /// <param name="y">And verticle position of the square clicked</param>
        public void RightClickSquare(int x, int y)
        {
            if(gameState == GameState.Running)
            {
                //Toggle flag on square
                gridController.ToggleFlag(x, y);
            }
        }

        /// <summary>
        /// This function handles all operations for left clicking a square on the game board
        /// </summary>
        /// <param name="mainForm">A reference to the main form</param>
        /// <param name="x">And horizontal position of the square clicked</param>
        /// <param name="y">And verticle position of the square clicked</param>
        public void LeftClickSquare(int x, int y)
        {
            // Check if we are still in newgame state or running
            // gameState being new game means a new game has yet to begin. Call game start function
            if(gameState == GameState.NewGame)
            {
                StartGame(x, y);
            }
            else if(gameState == GameState.Running)
            {
                //gridController.RevealAll();
                gridController.RevealSquare(x, y);
            }
        }

        /// <summary>
        /// Handles Game Loss operations
        /// </summary>
        public void GameLoss()
        {
            gameState = GameState.GameLost;
            timeController.stopTime();
            mainForm.GameLoss();
        }

        /// <summary>
        /// Handles game win operations
        /// </summary>
        public void GameWon()
        {
            gameState = GameState.GameWon;
            timeController.stopTime();
            mainForm.GameWon();
        }

        public void increaseMineCount()
        {
            mineCountController.increaseCount();
        }

        public void decreaseMineCount()
        {
            mineCountController.decreaseCount();
        }

    }
}
