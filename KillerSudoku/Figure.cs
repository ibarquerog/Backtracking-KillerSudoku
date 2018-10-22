using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KillerSudoku
{
    class Figure:MainFigure
    { 
        private Cage Cage1;
        private Cage Cage2;
        private Cage Cage3;
        private Cage Cage4;
        List<Cage> cageList = new List<Cage>();

        public Figure(Cage Cage1, Cage Cage2, Cage Cage3, Cage Cage4)
        {
            this.Cage11 = Cage1;
            this.Cage21 = Cage2;
            this.Cage31 = Cage3;
            this.Cage41 = Cage4;
            this.cageList.Add(this.Cage1);
            this.cageList.Add(this.Cage2);
            this.cageList.Add(this.Cage3);
            this.cageList.Add(this.Cage4);
        }

        internal Cage Cage11 { get => Cage1; set => Cage1 = value; }
        internal Cage Cage21 { get => Cage2; set => Cage2 = value; }
        internal Cage Cage31 { get => Cage3; set => Cage3 = value; }
        internal Cage Cage41 { get => Cage4; set => Cage4 = value; }


        public override void generateResult()
        {
            Random rand = new Random(Guid.NewGuid().GetHashCode());
            int num = rand.Next(0, 2);
            if (num == 0)
            {
                this.FigResult = Cage1.Value + Cage2.Value + Cage3.Value + Cage4.Value;
                this.Operation = "+";
            }
            else
            {
                this.FigResult = Cage1.Value * Cage2.Value * Cage3.Value * Cage4.Value;
                this.Operation = "x";
            }

        }


        public override bool isSafe(int gridValue)
        {
            if (this.Operation == "+")
            {
                if (this.Cage11.Value + this.Cage21.Value + this.Cage31.Value + this.Cage41.Value + gridValue > this.FigResult)
                {
                    return false;
                }

            }
            else if(this.Operation == "*")
            {
                int temporaryResult = 0;
                if (gridValue%this.FigResult != 0)
                {
                    return false;
                }
                if (this.Cage11.Value != 0)
                {
                    temporaryResult *= this.Cage11.Value;
                }
                if (this.Cage21.Value != 0)
                {
                    temporaryResult *= this.Cage21.Value;
                }
                if (this.Cage31.Value != 0)
                {
                    temporaryResult *= this.Cage31.Value;
                }
                if (this.Cage41.Value != 0)
                {
                    temporaryResult *= this.Cage41.Value;
                }
                if (temporaryResult * gridValue > this.FigResult)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
