using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KillerSudoku
{
    class Figure3:MainFigure
    {

        private Cage Cage1;
        private Cage Cage2;
        private Cage Cage3;

        public Figure3(Cage Cage1, Cage Cage2, Cage Cage3)
        {
            this.Cage11 = Cage1;
            this.Cage21 = Cage2;
            this.Cage31 = Cage3;
        }

        public override void generateResult()
        {
            Random rand = new Random(Guid.NewGuid().GetHashCode());
            int num = rand.Next(0, 1);
            if (num == 0)
            {
                this.FigResult = Cage1.Value + Cage2.Value + Cage3.Value;
                this.Operation = "+";
            }
            else
            {
                this.FigResult = Cage1.Value * Cage2.Value * Cage3.Value;
                this.Operation = "x";
            }

        }

        internal Cage Cage11 { get => Cage1; set => Cage1 = value; }
        internal Cage Cage21 { get => Cage2; set => Cage2 = value; }
        internal Cage Cage31 { get => Cage3; set => Cage3 = value; }
    }
}
