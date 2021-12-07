using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace CS350MineSweeper
{
  

    class GridController
    {
        private Square[,] _squares;
        private Button[,] _buttons;
        private GameStateController _gameStateController;
        private int _width;
        private int _height;
        private int _unrevealedNonMines;



        public GridController(GameStateController gsc)
        {
            _gameStateController = gsc;
        }

        /// <summary>
        /// Will toggle a square to be flagged or not flagged if it's not revealed
        /// </summary>
        /// <param name="x">Horizonal location of the click</param>
        /// <param name="y">Vertical location of the click</param>
        public void ToggleFlag(int x, int y)
        {
            //Check if square is revealed. If it's not revealed, toggle it
            if(!_squares[x,y].IsRevealed)
            {
                //Toggle isFlagged bool on square
                _squares[x, y].IsFlagged = !_squares[x, y].IsFlagged;

                if(_squares[x, y].IsFlagged)
                {
                    //buttons[x, y].BackColor = Color.Red;
                    //buttons[x, y].Image = Properties.Resources.flag_icon;
                    Size newSize = new Size(_buttons[0, 0].Width, _buttons[0, 0].Height);
                    _buttons[x, y].Image = ImageWorker.RescaleImage(Properties.Resources.flag_icon, newSize);
                    _gameStateController.DecreaseMineCount();
                }
                else
                {
                    //buttons[x, y].BackColor = SystemColors.Control;
                    _buttons[x, y].Image = null;
                    _gameStateController.IncreaseMineCount();
                }

            }
        }

        /// <summary>
        /// Creates the array of square and inits all of them
        /// </summary>
        private void CreateSquaresArr()
        {
            //Init squares
            _squares = new Square[_width, _height];

            //Set all square to new square with next loop
            for (int y = 0; y < _height; y++)
            {
                for (int x = 0; x < _width; x++)
                {
                    //Declare square
                    _squares[x, y] = new Square();
                }
            }
        }

        /// <summary>
        /// Places all of the mines and sets adjacencies
        /// </summary>
        /// <param name="mineCount">Number of mines</param>
        /// <param name="xClick">Horizonal location of the click</param>
        /// <param name="yClick">Vertical location of the click</param>
        public void GenerateBoard(int mineCount, int xClick, int yClick)
        {
            PlaceMines(mineCount, xClick, yClick);
            GenerateAdjacenciesLoop();
            _unrevealedNonMines = _width * _height - mineCount;
        }

        /// <summary>
        /// Loops through squares to find adjacency values
        /// </summary>
        private void GenerateAdjacenciesLoop()
        {
            //Set all square to new square with next loop
            for (int y = 0; y < _height; y++)
            {
                for (int x = 0; x < _width; x++)
                {
                    FindAdjacency(x, y);
                }
            }
        }

        /// <summary>
        /// Find the adjacency value of a sqaure with given coordinates
        /// </summary>
        /// <param name="xPos">X position of tested square</param>
        /// <param name="yPos">y position of tested square</param>
        private void FindAdjacency(int xPos, int yPos)
        {
            //Neighbor mines
            int neighborMines = 0;

            //Loop through nearby squares
            for(int x = xPos - 1; x <= xPos + 1; x++)
            {
                //Check if x is in a valie position
                if(x >= 0 && x < _width)
                {
                    for (int y = yPos - 1; y <= yPos + 1; y++)
                    {
                        //Check if y is on the board
                        if(y >= 0 && y < _height)
                        {
                            //Check if spot on that sqaure is a mine
                            if(_squares[x, y].IsMine)
                            {
                                neighborMines++;
                            }
                            
                        }
                    }
                }

            }

            //Set adjacency
            _squares[xPos, yPos].Adjacency = neighborMines;
        }

        /// <summary>
        /// Populates mines on the board
        /// </summary>
        /// <param name="mineCount"></param>
        /// <param name="xClick"></param>
        /// <param name="yClick"></param>
        private void PlaceMines(int mineCount, int xClick, int yClick)
        {
            //Create Random
            Random ran = new Random();

            //Place mines with for loops
            int i = 0;
            while (i < mineCount)
            {
                //Declare random variables
                int ranX, ranY;

                //Generate random positions
                ranX = ran.Next(_width);
                ranY = ran.Next(_height);

                //Check if position already has a mine
                if (_squares[ranX, ranY].IsMine)
                {
                    continue;
                }
                else
                {
                    //Now check if position is near the starting click location
                    if (ranX >= xClick - 1 && ranX <= xClick + 1 && ranY >= yClick - 1 && ranY <= yClick + 1)
                    {
                        continue;
                    }
                    else
                    {
                        //Place mine in square and increment i
                        _squares[ranX, ranY].IsMine = true;
                        i++; //Indicates we placed another mine
                    }

                }
            }
        }

        /// <summary>
        /// Get button arr from gameStateController and set width and height
        /// </summary>
        /// <param name="buttonsArr">Button arr reference</param>
        /// <param name="width">Width of grid</param>
        /// <param name="height">Height of grid</param>
        public void ReceiveButtonArr(Button[,] buttonsArr, int width, int height)
        {
            //Set buttons array
            _buttons = buttonsArr;

            //Set width and height
            this._width = width;
            this._height = height;

            //Create new squares array
            CreateSquaresArr();
            




        }

        /// <summary>
        /// Resets the buttons and squares properties in object
        /// </summary>
        public void ResetBoard()
        {
            _buttons = null;
            _squares = null;
        }

        /// <summary>
        /// Reveals all locations of mines and adjacencies on grid for a loss
        /// </summary>
        public void RevealAllLoss()
        {
            //Loop through all squares and buttons to reveal
            for(int x = 0; x < _width; x++)
            {
                for(int y= 0; y < _height; y++)
                {
                    if(_squares[x,y].IsMine)
                    {
                        Size newSize = new Size(_buttons[0, 0].Width, _buttons[0, 0].Height);
                        _buttons[x, y].Image = ImageWorker.RescaleImage(Properties.Resources.mine, newSize);
                        //buttons[x, y].BackColor = Color.Green;
                        //buttons[x, y].Enabled = false;
                    }
                    else
                    {
                        RevealAdjacency(x, y);
                    }
                }
            }
        }

        public void RevealAllWin()
        {
            //Loop through all squares and buttons to reveal
            for (int x = 0; x < _width; x++)
            {
                for (int y = 0; y < _height; y++)
                {
                    if (_squares[x, y].IsMine)
                    {
                        Size newSize = new Size(_buttons[0, 0].Width, _buttons[0, 0].Height);
                        _buttons[x, y].Image = ImageWorker.RescaleImage(Properties.Resources.flower, newSize);
                        //buttons[x, y].Enabled = false;
                    }
                    else
                    {
                        RevealAdjacency(x, y);
                    }
                }
            }
        }

        /// <summary>
        /// Reveal a mine, adjacencies or 
        /// </summary>
        /// <param name="xClick"></param>
        /// <param name="yClick"></param>
        public void RevealSquare(int xClick, int yClick)
        {
            //If the square is flagged, do not reveal
            if(_squares[xClick, yClick].IsFlagged)
            {
                return;
            }

            //Check if the square is a mine
            if(_squares[xClick, yClick].IsMine)
            {
                _gameStateController.GameLoss();
                RevealAllLoss();

            }
            //Then square has adjacency value
            else
            {
                //Reveal adjacency value
                RevealAdjacency(xClick, yClick);
            }
        }

        /// <summary>
        /// Reveal the number under the square
        /// </summary>
        /// <param name="x">X position of square to reveal</param>
        /// <param name="y">Y position of square to reveal</param>
        private void RevealAdjacency(int x, int y)
        {
            //Check if square is revealed or flagged
            if (_squares[x, y].IsRevealed || (_squares[x, y].IsFlagged &&
                _gameStateController.gameState == GameState.Running))
            {
                return;
            }

            //Declare vars
            Button button = _buttons[x, y];
            Square square = _squares[x, y];

            //Change button settings
            button.BackColor = Color.Gray;
            button.Font = new Font(button.Font, FontStyle.Bold);
            button.ForeColor = ReceiveAdjacencyColor(square.Adjacency);
            _unrevealedNonMines--;
            square.IsRevealed = true;

            //If the square has an adjacency, no need for recursive call
            if (square.Adjacency > 0)
            {
                button.Text = square.Adjacency.ToString();
            }

            //Now adjacency is zero, in which we reveal all nearby squares
            else if (square.Adjacency == 0)
            {

                button.Text = "";
                RevealSquaresNearEmpty(x, y);
            }

            //Check for win condition
            if (_unrevealedNonMines <= 0 && _gameStateController.gameState == GameState.Running)
            {
                _gameStateController.GameWon();
                RevealAllWin();
            }
        }

        /// <summary>
        /// Function to search squares nearby given coordinates and reveals them
        /// </summary>
        /// <param name="xPos">X position of square in center</param>
        /// <param name="yPos">Y position of square in center</param>
        private void RevealSquaresNearEmpty(int xPos, int yPos)
        {
            //Loop through nearby squares
            for (int x = xPos - 1; x <= xPos + 1; x++)
            {
                //Check if x is in a valid position
                if (x >= 0 && x < _width)
                {
                    for (int y = yPos - 1; y <= yPos + 1; y++)
                    {
                        //Check if y is on the board
                        if (y >= 0 && y < _height)
                        {
                            RevealAdjacency(x, y);

                        }
                    }
                }

            }
        }

        private Color ReceiveAdjacencyColor(int adj)
        {
            //Declare color
            Color adjColor;

            //Switch case for adjacency number
            switch(adj)
            {
                case 1:
                    adjColor = Color.Blue;
                    break;
                case 2:
                    adjColor = Color.DarkGreen;
                    break;
                case 3:
                    adjColor = Color.Red;
                    break;
                case 4:
                    adjColor = Color.Purple;
                    break;
                case 5:
                    adjColor = Color.Maroon;
                    break;
                case 6:
                    adjColor = Color.Turquoise;
                    break;
                case 7:
                    adjColor = Color.Black;
                    break;
                case 8:
                    adjColor = Color.DarkGray;
                    break;
                default:
                    adjColor = Color.Yellow;
                    break;

            }

            //Return
            return adjColor;

        }
    }
}
