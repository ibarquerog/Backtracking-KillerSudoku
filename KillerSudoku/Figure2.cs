﻿using System;
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
            this.cageList.Add(this.Cage1);
            this.cageList.Add(this.Cage2);
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

        public override bool isSafe(int gridValue)
        {
            if (this.Operation == "+")
            {
                if (this.Cage11.Value + this.Cage21.Value + gridValue > this.FigResult)
                {
                    return false;
                }
                if (this.Cage11.Value != 0 && (this.Cage11.Value + gridValue != this.FigResult))
                {
                    return false;
                }
            }
            else if (this.Operation == "x")
            {
                int temporaryResult = 1;
                if (this.FigResult%gridValue != 0)
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
                if (temporaryResult * gridValue > this.FigResult)
                {
                    return false;
                }
                if (this.Cage11.Value != 0 && (temporaryResult * gridValue != this.FigResult))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
