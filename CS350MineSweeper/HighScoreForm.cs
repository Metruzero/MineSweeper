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
        private List<Score> easy, medium, hard;
        private ScoreController sc;


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
            for(int i = 0; i < easy.Count; i++)
            {
                //Create row
                string[] row = { (i + 1).ToString(), easy[i].name, easy[i].time.ToString() };

                easyDataGridView.Rows.Add(row);
            }

            //
            //
            //               Medium Score Loop
            //
            // Iterate through medium list and add data to grid view
            for (int i = 0; i < medium.Count; i++)
            {
                //Create row
                string[] row = { (i + 1).ToString(), medium[i].name, medium[i].time.ToString() };

                mediumDataGridView.Rows.Add(row);
            }

            //
            //
            //               Hard Score Loop
            //
            // Iterate through hard list and add data to grid view
            for (int i = 0; i < hard.Count; i++)
            {
                //Create row
                string[] row = { (i + 1).ToString(), hard[i].name, hard[i].time.ToString() };

                hardDataGridView.Rows.Add(row);
            }


        }

        private void GetScoreLists()
        {
            //Create Score Controller
            sc = new ScoreController();

            //Get lists
            easy = sc.GetScoreList(Difficulty.Easy);
            medium = sc.GetScoreList(Difficulty.Medium);
            hard = sc.GetScoreList(Difficulty.Hard);
        }
    }
}
