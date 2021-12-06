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
    public partial class HighScoreForm : Form
    {
        //Score lists
        private List<Score> _easy, _medium, _hard;
        private ScoreController _sc;


        public HighScoreForm()
        {
            InitializeComponent();
            PopulateData();

        }

        private void PopulateData()
        {
            //Acquire Score lists
            GetScoreLists();

            //label1.Text = hard.Count.ToString();

            //Iterate through lists to get data

            //
            //
            //               Easy Score Loop
            //
            // Iterate through easy list and add data to grid view
            for(int i = 0; i < _easy.Count; i++)
            {
                //Create row
                string[] row = { (i + 1).ToString(), _easy[i].name, _easy[i].time.ToString() };

                easyDataGridView.Rows.Add(row);
            }

            //
            //
            //               Medium Score Loop
            //
            // Iterate through medium list and add data to grid view
            for (int i = 0; i < _medium.Count; i++)
            {
                //Create row
                string[] row = { (i + 1).ToString(), _medium[i].name, _medium[i].time.ToString() };

                mediumDataGridView.Rows.Add(row);
            }

            //
            //
            //               Hard Score Loop
            //
            // Iterate through hard list and add data to grid view
            for (int i = 0; i < _hard.Count; i++)
            {
                //Create row
                string[] row = { (i + 1).ToString(), _hard[i].name, _hard[i].time.ToString() };

                hardDataGridView.Rows.Add(row);
            }


        }

        private void GetScoreLists()
        {
            //Create Score Controller
            _sc = new ScoreController();

            //Get lists
            _easy = _sc.GetScoreList(Difficulty.Easy);
            _medium = _sc.GetScoreList(Difficulty.Medium);
            _hard = _sc.GetScoreList(Difficulty.Hard);
        }
    }
}
