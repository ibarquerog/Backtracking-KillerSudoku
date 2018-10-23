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
        Grid grid;
        public Form1()
        {
            InitializeComponent();
        }

        public static List<List<int>> randomNumbersForSudoku(int matrixSize)
        {
            Random random = new Random();
            int randomNumber;
            List<List<int>> listNumbers = new List<List<int>>();
            for (int i = 0; i < matrixSize; i++)
            {
                List<int> newList = new List<int>();
                listNumbers.Add(newList);
                for (int j = 0; j < matrixSize; j++)
                {
                    do
                    {
                        randomNumber = random.Next(1, matrixSize);
                    } while (listNumbers[i].Contains(randomNumber));
                    listNumbers[i].Add(randomNumber);
                }
            }
            
            return listNumbers;
        }

        private void buttonGenerar_Click(object sender, EventArgs e)
        {
            clear();
            grid = new Grid(11, 11);
            dibujar();

        }

        private void dibujar()
        {
            Label[,] labelGrid = new Label[grid.width, grid.height];
            int x = 5;
            int y = 5;

            for (int i = 0; i < grid.height; i++)
            {
                for (int k = 0; k < grid.width; k++)
                {
                    Label label = new Label();
                    label.Text = grid.grid[i, k].Value.ToString();
                    label.Font = new Font("Roboto", 10);
                    label.TextAlign = ContentAlignment.BottomRight;
                    label.ForeColor = System.Drawing.Color.Black;
                    label.BackColor = grid.grid[i, k].Color;
                    //Console.WriteLine(grid.grid[i, k].Color.ToString());
                    label.Location = new Point(x, y);
                    label.BorderStyle = BorderStyle.Fixed3D;
                    label.Size = new Size(50, 50);
                    x += 50;
                    labelGrid[i, k] = label;

                }
                y += 50;
                x = 5;
            }



            for (int i = 0; i < labelGrid.GetLength(0); i++)
            {
                for (int k = 0; k < labelGrid.GetLength(1); k++)
                {
                    Label label = labelGrid[i, k];
                    int id = grid.grid[i, k].FigureID;
                    string labelText = grid.figures[id].FigResult + grid.figures[id].Operation;
                    Label miniLabel = new Label();
                    miniLabel.Text = labelText;
                    miniLabel.BackColor = label.BackColor;
                    miniLabel.Size = new Size(47, 20);
                    ToolTip tip = new ToolTip();
                    tip.ToolTipTitle = miniLabel.Text;
                    tip.SetToolTip(miniLabel, miniLabel.Text);
                    miniLabel.Font = new Font("Roboto", 7);
                    miniLabel.Location = new Point(label.Location.X + 2, label.Location.Y + 2);
                    panel1.Controls.Add(miniLabel);
                    panel1.Controls.Add(label);


                }
            }
        }

        private void clear()
        {
            panel1.Controls.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.saveFileDialog1.ShowDialog();
            string file = saveFileDialog1.FileName+".txt";
            FileManager fileToSave = new FileManager();
            fileToSave.saveFile(grid, file);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            clear();
           this.openFileDialog1.ShowDialog();
            string file = openFileDialog1.FileName;

            FileManager fileToOpen = new FileManager();
            grid = fileToOpen.openFile(file);
            dibujar();
            
        }
    }
}
