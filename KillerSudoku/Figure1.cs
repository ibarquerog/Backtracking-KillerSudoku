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
           
        }

        internal Cage Cage { get => cage; set => cage = value; }
    }
}
