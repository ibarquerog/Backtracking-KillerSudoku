using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KillerSudoku
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonGenerar_Click(object sender, EventArgs e)
        {
            Grid grid = new Grid(15, 15);
            Label[,] labelGrid = new Label[grid.width, grid.height];
            int x = 3;
            int y = 3;

            for (int i = 0; i < grid.height; i++)
            {
                for (int k = 0; k < grid.width; k++)
                {
                    Label label = new Label();
                    label.BackColor = grid.grid[i, k].Color;
                    label.Location = new Point(x, y);
                    label.BorderStyle = BorderStyle.Fixed3D;
                    label.Size = new Size(30, 30);
                    x += 30;
                    labelGrid[i, k] = label;

                }
                y += 30;
                x = 3;
            }


            for (int i = 0; i < labelGrid.GetLength(0); i++)
            {
                for (int k = 0; k < labelGrid.GetLength(1); k++)
                {
                    Label label = labelGrid[i, k];
                    this.Controls.Add(label);
                }
            }

        }



    }
}
