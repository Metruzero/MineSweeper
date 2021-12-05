using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace CS350MineSweeper
{
    public partial class MainForm : Form
    {

        public Button[,] buttons;
        private const int ButtonWidth = 30;
        private const int ButtonHeight = 30;
        private const int TopPanelPadding = 30;
        private const int SidePaddingForGrid = 50;
        private const int TopPaddingForGrid = 100;
        private const int BottomPaddingForGrid = 100;
        private const int MinFormHeight = 300;
        private const int MinFormWidth = 300;
        private GameStateController gameStateController;
        private PrivateFontCollection pfc;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

            gameStateController = new GameStateController(this);
            gameStateController.SetDifficulty(10, 10, 10, Difficulty.Easy);
            gameStateController.ResetBoard(this);
            InitCustomFont();
            InitTimeControls();
            InitResetButton();
            InitMineCountControls();
        }

        private void InitTimeControls()
        {
            Size picBoxSize = new Size(timerPictureBox.Width, timerPictureBox.Height);
            timerPictureBox.Image = ImageWorker.RescaleImage(Properties.Resources.timer, picBoxSize);
            timeLabel.Font = new Font(pfc.Families[0], timeLabel.Font.Size);
            timeLabel.ForeColor = Color.Red;
            timeLabel.Text = "0";
        }

        private void InitResetButton()
        {
            Size bSize = new Size(resetButton.Width, resetButton.Height);
            resetButton.Image = ImageWorker.RescaleImage(Properties.Resources.smiley, bSize);
        }

        private void InitMineCountControls()
        {
            Size picBoxSize = new Size(flagPictureBox.Width, flagPictureBox.Height);
            flagPictureBox.Image = ImageWorker.RescaleImage(Properties.Resources.flag_icon, picBoxSize);
            mineCountLabel.Parent = mineCountPanel;
            mineCountLabel.Font = new Font(pfc.Families[0], mineCountLabel.Font.Size);
            mineCountLabel.ForeColor = Color.Red;
            
        }

        public Button[,] CreateButtonArray(int width, int height)
        {
            //If buttons exist, destroy the buttons
            if(buttons != null)
            {
                //SetTest("Buttons exist");
                //Go through array and destroy all buttons
                foreach(var b in buttons)
                {
                    //Remove button from controls and dispose
                    Controls.Remove(b);
                    b.Dispose();
                }
            }

            //Init Button Array
            Button [,] buttonsArr = new Button[width, height];

            //Nested Loops for creating buttons
            //Outer loop for row. Each row is a value of y, the top left hand corner of the grid is 0,0
            for(int y = 0; y < height; y++)
            {
                //Inner loop for x
                for(int x = 0; x < width; x++)
                {
                    //Declare new button
                    Button newButton = new Button();

                    //Set location of button
                    newButton.Left = SidePaddingForGrid + x * ButtonWidth;
                    newButton.Top = TopPaddingForGrid + y * ButtonHeight;

                    //Set height and width of button
                    newButton.Width = ButtonWidth;
                    newButton.Height = ButtonHeight;

                    //TO DO: Remove this
                    //newButton.Text = x + "," + y;

                    //Add button to controls
                    Controls.Add(newButton);

                    //Add event handler for mouse click to button
                    newButton.MouseDown += GridButton_Click;

                    String buttonName = "GridButtonX" + x + "Y" + y;
                    newButton.Name = buttonName;

                    //Add button to arr
                    buttonsArr[x, y] = newButton;

                }
            }

            ResizeAndMoveControls(width, height);

            //Set local buttons to mainform buttons arr
            buttons = buttonsArr;

            return buttonsArr;
        }

        private void ResizeAndMoveControls(int width, int height)
        {
            //Change size of MainForm to fit grid properly
            int newFormWidth = SidePaddingForGrid * 2 + width * ButtonWidth;
            int newFormHeight = TopPaddingForGrid + height * ButtonHeight + BottomPaddingForGrid;

            //Don't let the window get too small.
            newFormHeight = (newFormHeight < MinFormHeight) ? MinFormHeight : newFormHeight;
            newFormWidth = (newFormWidth < MinFormWidth) ? MinFormWidth : newFormWidth;

            //Set size
            Size = new Size(newFormWidth, newFormHeight);
            CenterToScreen();

            //Move panels and buttons to their appropriate location

            //Move timer panel
            timePanel.Top = TopPanelPadding;
            timePanel.Left = SidePaddingForGrid;

            //Move mine count panel
            mineCountPanel.Top = TopPanelPadding;
            mineCountPanel.Left = Size.Width - SidePaddingForGrid - mineCountPanel.Width;

            //Move Reset Button
            int widthBetweenPanels = mineCountPanel.Left - timePanel.Right;
            resetButton.Top = TopPanelPadding;
            resetButton.Left = (widthBetweenPanels - resetButton.Width) / 2 + timePanel.Right;
                

        }

        private void GridButton_Click(object sender, MouseEventArgs e)
        {
            //Cast sender to button
            Button b = (Button)sender;

            //Parse button name for x and y from grid
            String buttonName = b.Name;
            int x, y;

            //Parsing x from name
            int xLength = buttonName.IndexOf('Y') - buttonName.IndexOf('X') - 1;
            Int32.TryParse(buttonName.Substring(buttonName.IndexOf('X') + 1, xLength), out x);

            //Parsing y from name
            Int32.TryParse(buttonName.Substring(buttonName.IndexOf('Y') + 1), out y);

            if (e.Button == MouseButtons.Right)
            {
                //TO DO: Toggle Flag
                gameStateController.RightClickSquare(x, y);
                
            }
            else if(e.Button == MouseButtons.Left)
            {
                gameStateController.LeftClickSquare(x, y);
            }
        }

        public void GameLoss()
        {
            //TestLabel.Text = "You lose!";
        }

        public void GameWon(Difficulty diff, int time, bool isHighScore)
        {
            //Check for high score
            if(isHighScore)
                GetHighScore(diff, time);
        }

        private void GetHighScore(Difficulty diff, int time)
        {
            //Create form
            Form form = new HighScoreInput(diff, time);

            //Display form
            form.Show();
        }

        private void easyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gameStateController.SetDifficulty(10, 10, 10, Difficulty.Easy);
            gameStateController.ResetBoard(this);
        }

        private void mediumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gameStateController.SetDifficulty(16, 16, 40, Difficulty.Medium);
            gameStateController.ResetBoard(this);
        }

        private void hardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gameStateController.SetDifficulty(30, 16, 99, Difficulty.Hard);
            gameStateController.ResetBoard(this);
        }

        private void customToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new CustomDifficultyForm(this);
            //form.FormClosing += delegate { this.Show(); };
            form.Show();

        }

        public void SetDifficultyAndReset(int width, int height, int mineCount)
        {
            gameStateController.SetDifficulty(width, height, mineCount, Difficulty.Custom);
            gameStateController.ResetBoard(this);
        }

        private void InitCustomFont()
        {
            //Create private font collection
            pfc = new PrivateFontCollection();

            //pfc.AddFontFile(Properties.Resources.digital_7);

            //Select font
            int fontLength = Properties.Resources.DIGITALDREAMFAT.Length;

            //Create font buffer
            byte[] fontData = Properties.Resources.DIGITALDREAMFAT;

            //Create a super unsafe block using C# pointer black magic
            System.IntPtr data = Marshal.AllocCoTaskMem(fontLength);

            //Copy bytes to block
            Marshal.Copy(fontData, 0, data, fontLength);

            //Add font to pfc
            pfc.AddMemoryFont(data, fontLength);

            //Get rid of that block!
            Marshal.FreeCoTaskMem(data);
        }

        public void UpdateTimer(int seconds)
        {
            if(seconds > 999)
            {
                timeLabel.Text = "999";
            }
            else
            {
                timeLabel.Text = seconds.ToString();
            }
           
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            gameStateController.ResetBoard(this);
        }

        public void UpdateMineCount(int mineCount)
        {
            mineCountLabel.Text = mineCount.ToString();
        }

        private void highScoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new HighScoreForm();
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ScoreController sc = new ScoreController();
            sc.AddScore("Alan", Difficulty.Hard, 20);

            List<Score> test = sc.GetScoreList(Difficulty.Hard);
        }
    }
}
