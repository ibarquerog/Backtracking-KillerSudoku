using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace KillerSudoku
{
    class Cage
    {
        private int value = 0;
        private string figure;
        private int figureID;
        private Color color;

        public Cage()
        {
            this.Color = new Color();
            this.value = 0;
            this.figure = "";
        }

        public int Value { get => value; set => this.value = value; }
        public string Figure { get => figure; set => figure = value; }
        public int FigureID { get => figureID; set => figureID = value; }
        public Color Color { get => color; set => color = value; }
    }
}
