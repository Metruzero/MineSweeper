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
        private TimeController _timeController;
        private GridController _gridController;
        private MineCountController _mineCountController;
        public GameState gameState;
        private int _width, _height, _mineCount;
        private MainForm _mainForm;
        private Difficulty _diff;

        //Constructor
        public GameStateController(MainForm mainForm)
        {
            //Declare attributes
            _timeController = new TimeController(mainForm);
            _gridController = new GridController(this);
            _mineCountController = new MineCountController(mainForm);
            gameState = GameState.NewGame;
            this._mainForm = mainForm;

        }

        /// <summary>
        /// Retrieves difficulty from mainform inputs and stores it
        /// </summary>
        /// <param name="width">Width of the game board</param>
        /// <param name="height">Height of the game board</param>
        /// <param name="mineCount">Number of mines in the game</param>
        public void SetDifficulty(int width, int height, int mineCount, Difficulty diff)
        {
            this._width = width;
            this._height = height;
            this._mineCount = mineCount;
            this._diff = diff;
        }

        /// <summary>
        /// Sends a call to gridcontroller to reset it's parameters and creates a new array of buttons
        /// </summary>
        /// <param name="mainForm">A reference to the main form which contains the game</param>
        public void ResetBoard(MainForm mainForm)
        {

            //Reset gameState
            gameState = GameState.NewGame;
            _gridController.ResetBoard();

            //Create new button grid
            Button[,] buttonsArr = ((MainForm)mainForm).CreateButtonArray(this._width, this._height);
            _gridController.ReceiveButtonArr(buttonsArr, this._width, this._height);

            //Reset time for timer
            _timeController.ResetTime();

            //Reset mine counter
            _mineCountController.ResetCount(_mineCount);
            

        }

        /// <summary>
        /// This will be called when first square is clicked in the game
        /// </summary>
        /// <param name="xClick">The x position of the first click of the game</param>
        /// <param name="yClick">The y position of the first click of the game</param>
        public void StartGame(int xClick, int yClick)
        {
            //Generate board
            _gridController.GenerateBoard(this._mineCount, xClick, yClick);
            gameState = GameState.Running;
            

            //Start timer
            _timeController.StartTime();

            //Reveal square in grid
            _gridController.RevealSquare(xClick, yClick);
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
                _gridController.ToggleFlag(x, y);
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
                _gridController.RevealSquare(x, y);
            }
        }

        /// <summary>
        /// Handles Game Loss operations
        /// </summary>
        public void GameLoss()
        {
            gameState = GameState.GameLost;
            _timeController.StopTime();
        }

        /// <summary>
        /// Handles game win operations
        /// </summary>
        public void GameWon()
        {
            //Change state
            gameState = GameState.GameWon;

            //Stop timer
            _timeController.StopTime();
            int score = _timeController.GetTime();

            //Check score
            ScoreController sc = new ScoreController();

            _mainForm.GameWon(_diff, score, sc.isHighScore(_diff, score));
        }

        public void IncreaseMineCount()
        {
            _mineCountController.IncreaseCount();
        }

        public void DecreaseMineCount()
        {
            _mineCountController.DecreaseCount();
        }

    }
}
