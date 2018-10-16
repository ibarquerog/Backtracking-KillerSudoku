using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KillerSudoku
{
    class Figure
    {
        private int figResult;
        private string operation;
        private Cage Cage1;
        private Cage Cage2;
        private Cage Cage3;
        private Cage Cage4;

        public Figure(Cage Cage1, Cage Cage2, Cage Cage3, Cage Cage4)
        {
            this.Cage1 = Cage1;
            this.Cage2 = Cage2;
            this.Cage3 = Cage3;
            this.Cage4 = Cage4;
        }

        public bool isSafe(int gridValue)
        {
            if (this.operation == "+")
            {
                if (this.Cage1.Value + this.Cage2.Value + this.Cage3.Value + this.Cage4.Value + gridValue > this.figResult)
                {
                    return false;
                }

            }
            else if(this.operation == "*")
            {
                int temporaryResult = 0;
                if (gridValue%this.figResult != 0)
                {
                    return false;
                }
                if (this.Cage1.Value != 0)
                {
                    temporaryResult *= this.Cage1.Value;
                }
                if (this.Cage2.Value != 0)
                {
                    temporaryResult *= this.Cage2.Value;
                }
                if (this.Cage3.Value != 0)
                {
                    temporaryResult *= this.Cage3.Value;
                }
                if (this.Cage4.Value != 0)
                {
                    temporaryResult *= this.Cage4.Value;
                }
                if (temporaryResult * gridValue > this.figResult)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
