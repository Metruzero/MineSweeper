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
        private MainForm _mainForm;
        private int _maxMineCount;
        private int _mineCount;

        //Constructor
        public MineCountController(MainForm mainForm)
        {
            this._mainForm = mainForm;

        }


        public void ResetCount(int mc)
        {
            this._maxMineCount = mc;
            this._mineCount = mc;
            UpdateMainForm();

        }

        public void DecreaseCount()
        {
            _mineCount--;
            UpdateMainForm();
        }

        public void IncreaseCount()
        {

            _mineCount++;
            if(_mineCount > _maxMineCount)
            {
                _mineCount = _maxMineCount;
            }
            UpdateMainForm();
        }

        private void UpdateMainForm()
        {
            _mainForm.UpdateMineCount(_mineCount);
        }

    }
}
