using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS350MineSweeper
{
    public partial class HighScoreInput : Form
    {
        private Difficulty _diff;
        private int _time;

        public HighScoreInput(Difficulty diff, int time)
        {
            InitializeComponent();
            this._diff = diff;
            this._time = time;
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            //Save name
            string s = nameTextBox.Text;
            
            //Trim white space from name
            s = s.Trim();

            //Create Score controller and add score
            ScoreController sc = new ScoreController();
            sc.AddScore(s, _diff, _time);

            //Close form
            this.Close();


        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {
            //Check text value
            string s = nameTextBox.Text;

            //Check if name has only white space
            if(s.Trim() != "")
            {
                submitButton.Enabled = true;
            }
            else
            {
                submitButton.Enabled = false;
            }
        }
    }
}
