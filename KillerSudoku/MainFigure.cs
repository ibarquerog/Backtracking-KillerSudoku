using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KillerSudoku
{
    class MainFigure
    {
        private int figResult;
        private string operation;
        public List<Cage> cageList = new List<Cage>();
        public MainFigure()
        {

        }

        public int FigResult { get => figResult; set => figResult = value; }
        public string Operation { get => operation; set => operation = value; }

        public virtual void generateResult()
        {

        }

        public virtual bool isSafe(int gridValue)
        {
            return false;
        }
    }
}
