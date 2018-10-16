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
        private int x;
        private int y;

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
        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }
    }
}
