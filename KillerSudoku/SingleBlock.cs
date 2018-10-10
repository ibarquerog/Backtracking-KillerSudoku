using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KillerSudoku
{
    class SingleBlock
    {
        private int figValue;
        private string operation;
        private Cage Cage;

        public SingleBlock(Cage Cage)
        {
            this.Cage = Cage; 
        }
    }
}