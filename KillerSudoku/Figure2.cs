using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KillerSudoku
{
    class Figure2:MainFigure
    {

        private Cage Cage1;
        private Cage Cage2;

        public Figure2(Cage Cage1, Cage Cage2)
        {
            this.Cage11 = Cage1;
            this.Cage21 = Cage2;
        }
        public override void generateResult()
        {
            Random rand = new Random(Guid.NewGuid().GetHashCode());
            int num = rand.Next(0, 1);
            if (num == 0)
            {
                this.FigResult = Cage1.Value + Cage2.Value;
                this.Operation = "+";
            }
            else
            {
                this.FigResult = Cage1.Value * Cage2.Value;
                this.Operation = "x";
            }

        }

        internal Cage Cage11 { get => Cage1; set => Cage1 = value; }
        internal Cage Cage21 { get => Cage2; set => Cage2 = value; }
    }
}
