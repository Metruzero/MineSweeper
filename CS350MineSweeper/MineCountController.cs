using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS350MineSweeper
{
    class MineCountController
    {
        //Attributes
        private MainForm mainForm;
        private int maxMineCount;
        private int mineCount;

        //Constructor
        public MineCountController(MainForm mainForm)
        {
            this.mainForm = mainForm;

        }


        public void resetCount(int mc)
        {
            this.maxMineCount = mc;
            this.mineCount = mc;
            updateMainForm();

        }

        public void decreaseCount()
        {
            mineCount--;
            updateMainForm();
        }

        public void increaseCount()
        {

            mineCount++;
            if(mineCount > maxMineCount)
            {
                mineCount = maxMineCount;
            }
            updateMainForm();
        }

        private void updateMainForm()
        {
            mainForm.UpdateMineCount(mineCount);
        }

    }
}
