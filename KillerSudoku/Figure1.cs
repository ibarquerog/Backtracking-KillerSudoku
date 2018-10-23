using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KillerSudoku
{
    class Figure1:MainFigure
    {
        Cage cage;
       
        
        public Figure1(Cage cage1)
        {
            this.cage = cage1;
            this.FigResult = cage1.Value;
            this.cageList.Add(cage);
        }

        internal Cage Cage { get => cage; set => cage = value; }

        public override bool isSafe(int gridValue)
        {
            if (gridValue != this.FigResult)
            {
                return false;
            }
            return true;
        }
    }
}
