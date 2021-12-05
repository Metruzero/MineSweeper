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
    public partial class CustomDifficultyForm : Form
    {
        MainForm mainForm;
        int width, height, mineCount;

        public CustomDifficultyForm(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            if(CheckValidity())
            {
                mainForm.SetDifficultyAndReset(width, height, mineCount);
                this.Close();
            }
            
            
        }

        private bool CheckValidity()
        {
            //Check width value
            if(!Int32.TryParse(widthTextBox.Text, out width))
            {
                widthLabel.ForeColor = Color.Red;
                return false;
            }
            else
            {
                
                if(width < 8 || width > 30)
                {
                    widthLabel.ForeColor = Color.Red;
                    return false;
                }
                else
                {
                    widthLabel.ForeColor = Color.Black;
                }
            }

            //Check height value
            if (!Int32.TryParse(heightTextBox.Text, out height))
            {
                heightLabel.ForeColor = Color.Red;
                return false;
            }
            else
            {
                
                if (height < 8 || height > 30)
                {
                    heightLabel.ForeColor = Color.Red;
                    return false;
                }
                else
                {
                    heightLabel.ForeColor = Color.Black;
                }
            }

            //Check mine value
            if (!Int32.TryParse(mineTextBox.Text, out mineCount))
            {
                mineLabel.ForeColor = Color.Red;
                return false;
            }
            else
            {
                if (mineCount < 1 || mineCount > 99)
                {
                    mineLabel.ForeColor = Color.Red;
                    return false;
                }
                else
                {

                    //Check if number is valid
                    if(mineCount > (float)(height * width) * .8)
                    {
                        ErrorOutput.Text = "Too many mines with size";
                        mineLabel.ForeColor = Color.Red;
                        return false;
                    }
                    else
                    {
                        ErrorOutput.Text = "";
                        mineLabel.ForeColor = Color.Black;
                        return true;
                    }
                }
            }


        }

        private void widthTextBox_TextChanged(object sender, EventArgs e)
        {
            CheckValidity();
        }

        private void heightTextBox_TextChanged(object sender, EventArgs e)
        {
            CheckValidity();
        }

        private void mineTextBox_TextChanged(object sender, EventArgs e)
        {
            CheckValidity();
        }
    }
}
