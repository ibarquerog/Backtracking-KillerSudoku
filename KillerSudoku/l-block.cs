using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KillerSudoku
{
    class l_block
    {
        private int figValue;
        private string operation;
        private Cage Cage1;
        private Cage Cage2;
        private Cage Cage3;
        private Cage Cage4;

        public l_block(Cage Cage1, Cage Cage2, Cage Cage3, Cage Cage4)
        {
            this.Cage1 = Cage1;
            this.Cage2 = Cage2;
            this.Cage3 = Cage3;
            this.Cage4 = Cage4;
        }
    }
}   
