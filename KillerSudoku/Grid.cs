using System.Drawing;
using System;
using System.Collections.Generic;

namespace KillerSudoku
{

    class Grid
    {
        int contId = 0;
        public int width;
        public int height;
        public Cage[,] grid;
        public List<MainFigure> figures = new List<MainFigure>();
        public List<MainFigure> orderedFigures = new List<MainFigure>();

        public void delete()
        {
            this.grid = null;
        }

        public Grid(int width, int height)
        {
            this.width = width;
            this.height = height;
            grid = new Cage[this.width, this.height];
            initializeGrid();
            firstRow();
            firstColumn();
            placeNumbers(this.width);
            generatePuzzle();
            fillEntirePuzzle();
            generateResults();
            orderFigures();
            resetResults();
            solveSudoku();
           
        }

        

        private void fillEntirePuzzle()
        {
            for (int i = 0; i < this.height; i++)
            {
                for (int k = 0; k < this.width; k++)
                {                  
                        drawL(i, k, contId);
                        drawTRight(i, k, contId);
                        drawTUp(i, k, contId);
                        drawO(i, k, contId);
                        drawLU(i, k, contId);
                        drawZVertical(i, k, contId);
                        drawSVertical(i, k, contId);
                        drawLL(i, k, contId);
                        drawTDown(i, k, contId);
                        drawS(i, k, contId);
                        drawlHorizontal(i, k, contId);
                        drawZ(i, k, contId);
                        drawTLeft(i, k, contId);
                        drawlVertical(i, k, contId);
                        draw3blocksHorizontal(i, k, contId);
                        draw3blocksVertical(i, k, contId);
                        draw2blocksHorizontal(i, k, contId);
                        draw2blocksVertical(i, k, contId);
                        drawSingleCage(i, k, contId);
                    
                }
            }
        }

        private void initializeGrid()
        {
            for (int i = 0; i < this.height; i++)
            {
                for (int k = 0; k < this.width; k++)
                {
                    this.grid[i, k] = new Cage();
                }
            }
        }

        private void generatePuzzle()
        {
            
            for (int i = 0; i < this.height; i++)
            {
                for (int k = 0; k < this.width; k++)
                {
                    Console.WriteLine(this.contId.ToString());
                    Random rand = new Random(Guid.NewGuid().GetHashCode());
                    int randNum = rand.Next(1, 14);

                    switch (randNum)
                    {
                        case 1:
                            drawlVertical(i, k, contId);
                            break;
                        case 2:
                            drawlHorizontal(i, k, contId);
                            break;
                        case 3:
                            drawS(i, k, contId);
                            break;
                        case 4:
                            drawSVertical(i, k, contId);
                            break;
                        case 5:
                            drawTUp(i, k, contId);
                            break;
                        case 6:
                            drawTRight(i, k, contId);
                            break;
                        case 7:
                            drawTDown(i, k, contId);
                            break;
                        case 8:
                            drawTLeft(i, k, contId);
                            break;
                        case 9:
                            drawZ(i, k, contId);
                            break;
                        case 10:
                            drawZVertical(i, k, contId);
                            break;
                        case 11:
                            drawO(i, k, contId);
                            break;
                        case 12:
                            drawL(i, k, contId);
                            break;
                        case 13:
                            drawLU(i, k, contId);
                            break;
                        case 14:
                            drawLL(i, k, contId);
                            break;
                    }


                }

            }
        }

        private void drawSingleCage(int i, int k, int figureID)
        {
            if (this.grid[i, k].Figure == "")
            {
                this.contId += 1;
                this.grid[i, k].Color = Color.White;
                this.grid[i, k].FigureID = figureID;
                this.grid[i, k].X = i;
                this.grid[i, k].Y = k;
                this.grid[i, k].Figure = "One";
                Figure1 figure = new Figure1(this.grid[i, k]);
                figure.FigResult = this.grid[i, k].Value;
                this.figures.Add(figure);
            }
           
        }
        private void draw2blocksVertical(int i, int k, int figureID)
        {
            if (i + 1 < this.height)
            {
                if (this.grid[i, k].Figure == "" && this.grid[i + 1, k].Figure == "")
                {
                    this.contId += 1;
                    this.grid[i, k].Color = Color.FromArgb(244, 66, 92);
                    this.grid[i, k].FigureID = figureID;
                    this.grid[i, k].X = i;
                    this.grid[i, k].Y = k;
                    this.grid[i, k].Figure = "twoV";

                    this.grid[i + 1, k].Color = Color.FromArgb(244, 66, 92);
                    this.grid[i + 1, k].FigureID = figureID;
                    this.grid[i + 1, k].X = i + 1;
                    this.grid[i + 1, k].Y = k;
                    this.grid[i + 1, k].Figure = "twoV";

                    Figure2 figure = new Figure2(this.grid[i, k], this.grid[i + 1, k]);
                    this.figures.Add(figure);
                }
            }
        }
        private void draw2blocksHorizontal(int i, int k, int figureID)
        {
            if (k + 1 < this.width)
            {
                if (this.grid[i, k].Figure == "" && this.grid[i, k + 1].Figure == "")
                {
                    this.contId += 1;
                    this.grid[i, k].Color = Color.FromArgb(244, 202, 65);
                    this.grid[i, k].FigureID = figureID;
                    this.grid[i, k].X = i;
                    this.grid[i, k].Y = k;
                    this.grid[i, k].Figure = "twoH";

                    this.grid[i, k + 1].Color = Color.FromArgb(244, 202, 65);
                    this.grid[i, k + 1].FigureID = figureID;
                    this.grid[i, k + 1].X = i;
                    this.grid[i, k + 1].Y = k + 1;
                    this.grid[i, k + 1].Figure = "twoH";

                    Figure2 figure = new Figure2(this.grid[i, k], this.grid[i, k + 1]);
                    this.figures.Add(figure);
                }
            }
        }

        private void draw3blocksHorizontal(int i, int k, int figureID)
        {
            if (k + 2 < this.width)
            {
                if (this.grid[i, k].Figure == "" && this.grid[i, k + 1].Figure == "" && this.grid[i, k + 2].Figure == "")
                {
                    this.contId += 1;
                    this.grid[i, k].Color = Color.FromArgb(114, 130, 81);
                    this.grid[i, k].FigureID = figureID;
                    this.grid[i, k].X = i;
                    this.grid[i, k].Y = k;
                    this.grid[i, k].Figure = "treeH";

                    this.grid[i, k + 1].Color = Color.FromArgb(114, 130, 81);
                    this.grid[i, k + 1].FigureID = figureID;
                    this.grid[i, k + 1].X = i;
                    this.grid[i, k + 1].Y = k + 1;
                    this.grid[i, k + 1].Figure = "treeH";

                    this.grid[i, k + 2].Color = Color.FromArgb(114, 130, 81);
                    this.grid[i, k + 2].FigureID = figureID;
                    this.grid[i, k + 2].X = i;
                    this.grid[i, k + 2].Y = k + 2;
                    this.grid[i, k + 2].Figure = "treeH";

                    Figure3 figure = new Figure3(this.grid[i, k], this.grid[i, k + 1], this.grid[i, k + 2]);
                    this.figures.Add(figure);
                }
            }
        }

        private void draw3blocksVertical(int i, int k, int figureID)
        {
            if (i + 2 < this.height)
            {
                if (this.grid[i, k].Figure == "" && this.grid[i + 1, k].Figure == "" && this.grid[i + 2, k].Figure == "")
                {
                    this.contId += 1;
                    this.grid[i, k].Color = Color.FromArgb(167, 201, 232);
                    this.grid[i, k].FigureID = figureID;
                    this.grid[i, k].X = i;
                    this.grid[i, k].Y = k;
                    this.grid[i, k].Figure = "treeV";

                    this.grid[i + 1, k].Color = Color.FromArgb(167, 201, 232);
                    this.grid[i + 1, k].FigureID = figureID;
                    this.grid[i + 1, k].X = i + 1;
                    this.grid[i + 1, k].Y = k;
                    this.grid[i + 1, k].Figure = "treeV";

                    this.grid[i + 2, k].Color = Color.FromArgb(167, 201, 232);
                    this.grid[i + 2, k].FigureID = figureID;
                    this.grid[i + 2, k].X = i + 2;
                    this.grid[i + 2, k].Y = k;
                    this.grid[i + 2, k].Figure = "treeV";

                    Figure3 figure = new Figure3(this.grid[i, k], this.grid[i + 1, k], this.grid[i + 2, k]);
                    this.figures.Add(figure);
                }
            }
        }


        private void drawlVertical(int i, int k, int figureID)
        {
            if (i + 3 < this.height)
            {
                if (grid[i, k].Figure == "" && grid[i + 1, k].Figure == "" && grid[i + 2, k].Figure == "" && grid[i + 3, k].Figure == "")
                {
                    this.contId += 1;
                    this.grid[i, k].Color = Color.FromArgb(128, 128, 128);
                    this.grid[i, k].FigureID = figureID;
                    this.grid[i, k].X = i;
                    this.grid[i, k].Y = k;
                    this.grid[i, k].Figure = "lVertical";

                    this.grid[i + 1, k].Color = Color.FromArgb(128, 128, 128);
                    this.grid[i + 1, k].FigureID = figureID;
                    this.grid[i + 1, k].X = i + 1;
                    this.grid[i + 1, k].Y = k;
                    this.grid[i + 1, k].Figure = "lVertical";

                    this.grid[i + 2, k].Color = Color.FromArgb(128, 128, 128);
                    this.grid[i + 2, k].FigureID = figureID;
                    this.grid[i + 2, k].Figure = "lVertical";
                    this.grid[i + 2, k].X = i + 2;
                    this.grid[i + 2, k].Y = k;

                    this.grid[i + 3, k].Color = Color.FromArgb(128, 128, 128);
                    this.grid[i + 3, k].FigureID = figureID;
                    this.grid[i + 3, k].Figure = "lVertical";
                    this.grid[i + 3, k].X = i + 3;
                    this.grid[i + 3, k].Y = k;

                    Figure figure = new Figure(this.grid[i, k], this.grid[i + 1, k], this.grid[i + 2, k], this.grid[i + 3, k]);
                    this.figures.Add(figure);
                }
            }
        }


        private void drawlHorizontal(int i, int k, int figureID)
        {
            if (k + 3 < this.width)
            {
                if (grid[i, k].Figure == "" && grid[i, k + 1].Figure == "" && grid[i, k + 2].Figure == "" && grid[i, k + 3].Figure == "")
                {
                    this.contId += 1;

                    this.grid[i, k].Color = Color.FromArgb(106, 90, 205);
                    this.grid[i, k].Figure = "lHorizontal";
                    this.grid[i, k].FigureID = figureID;
                    this.grid[i, k].X = i;
                    this.grid[i, k].Y = k;

                    this.grid[i, k + 1].Color = Color.FromArgb(106, 90, 205);
                    this.grid[i, k + 1].Figure = "lHorizontal";
                    this.grid[i, k + 1].FigureID = figureID;
                    this.grid[i, k + 1].X = i;
                    this.grid[i, k + 1].Y = k + 1;

                    this.grid[i, k + 2].Color = Color.FromArgb(106, 90, 205);
                    this.grid[i, k + 2].Figure = "lHorizontal";
                    this.grid[i, k + 2].FigureID = figureID;
                    this.grid[i, k + 2].X = i;
                    this.grid[i, k + 2].Y = k + 2;

                    this.grid[i, k + 3].Color = Color.FromArgb(106, 90, 205);
                    this.grid[i, k + 3].Figure = "lHorizontal";
                    this.grid[i, k + 3].FigureID = figureID;
                    this.grid[i, k + 3].X = i;
                    this.grid[i, k + 3].Y = k + 3;

                    Figure figure = new Figure(this.grid[i, k], this.grid[i, k + 1], this.grid[i, k + 2], this.grid[i, k + 3]);
                    this.figures.Add(figure);
                }

            }

        }
        private void drawS(int i, int k, int figureID)
        {
            if (k + 3 < this.width && i - 1 > 0)
            {
                if (grid[i, k].Figure == "" && grid[i, k + 1].Figure == "" && grid[i - 1, k + 1].Figure == "" && grid[i - 1, k + 2].Figure == "")
                {
                    this.contId += 1;

                    this.grid[i, k].Color = Color.FromArgb(30, 144, 255);
                    this.grid[i, k].Figure = "S";
                    this.grid[i, k].FigureID = figureID;
                    this.grid[i, k].X = i;
                    this.grid[i, k].Y = k;

                    this.grid[i, k + 1].Color = Color.FromArgb(30, 144, 255);
                    this.grid[i, k + 1].Figure = "S";
                    this.grid[i, k + 1].FigureID = figureID;
                    this.grid[i, k + 1].X = i;
                    this.grid[i, k + 1].Y = k + 1;

                    this.grid[i - 1, k + 1].Color = Color.FromArgb(30, 144, 255);
                    this.grid[i - 1, k + 1].Figure = "S";
                    this.grid[i - 1, k + 1].FigureID = figureID;
                    this.grid[i - 1, k + 1].X = i - 1;
                    this.grid[i - 1, k + 1].Y = k + 1;

                    this.grid[i - 1, k + 2].Color = Color.FromArgb(30, 144, 255);
                    this.grid[i - 1, k + 2].Figure = "S";
                    this.grid[i - 1, k + 2].FigureID = figureID;
                    this.grid[i - 1, k + 2].X = i - 1;
                    this.grid[i - 1, k + 2].Y = k + 2;

                    Figure figure = new Figure(this.grid[i, k], this.grid[i, k + 1], this.grid[i - 1, k + 1], this.grid[i - 1, k + 2]);
                    this.figures.Add(figure);
                }

            }

        }
        private void drawSVertical(int i, int k, int figureID)
        {
            if (k + 1 < this.width && i + 3 < this.height)
            {
                if (grid[i, k].Figure == "" && grid[i + 1, k].Figure == "" && grid[i + 1, k + 1].Figure == "" && grid[i + 2, k + 1].Figure == "")
                {
                    this.contId += 1;

                    this.grid[i, k].Color = Color.FromArgb(218, 165, 32);
                    this.grid[i, k].Figure = "SV";
                    this.grid[i, k].FigureID = figureID;
                    this.grid[i, k].X = i;
                    this.grid[i, k].Y = k;

                    this.grid[i + 1, k].Color = Color.FromArgb(218, 165, 32);
                    this.grid[i + 1, k].Figure = "SV";
                    this.grid[i + 1, k].FigureID = figureID;
                    this.grid[i + 1, k].X = i + 1;
                    this.grid[i + 1, k].Y = k;

                    this.grid[i + 1, k + 1].Color = Color.FromArgb(218, 165, 32);
                    this.grid[i + 1, k + 1].Figure = "SV";
                    this.grid[i + 1, k + 1].FigureID = figureID;
                    this.grid[i + 1, k + 1].X = i + 1;
                    this.grid[i + 1, k + 1].Y = k + 1;

                    this.grid[i + 2, k + 1].Color = Color.FromArgb(218, 165, 32);
                    this.grid[i + 2, k + 1].Figure = "SV";
                    this.grid[i + 2, k + 1].FigureID = figureID;
                    this.grid[i + 2, k + 1].X = i + 2;
                    this.grid[i + 2, k + 1].Y = k + 1;

                    Figure figure = new Figure(this.grid[i, k], this.grid[i + 1, k], this.grid[i + 1, k + 1], this.grid[i + 2, k + 1]);
                    this.figures.Add(figure);
                }

            }

        }
        private void drawTUp(int i, int k, int figureID)
        {
            if (k + 3 < this.width && i - 1 > 0)
            {
                if (grid[i, k].Figure == "" && grid[i, k + 1].Figure == "" && grid[i, k + 2].Figure == "" && grid[i - 1, k + 1].Figure == "")
                {
                    this.contId += 1;

                    this.grid[i, k].Color = Color.FromArgb(47, 79, 79);
                    this.grid[i, k].Figure = "TU";
                    this.grid[i, k].FigureID = figureID;
                    this.grid[i, k].X = i;
                    this.grid[i, k].Y = k;

                    this.grid[i, k + 1].Color = Color.FromArgb(47, 79, 79);
                    this.grid[i, k + 1].Figure = "TU";
                    this.grid[i, k + 1].FigureID = figureID;
                    this.grid[i, k + 1].X = i;
                    this.grid[i, k + 1].Y = k + 1;

                    this.grid[i - 1, k + 1].Color = Color.FromArgb(47, 79, 79);
                    this.grid[i - 1, k + 1].Figure = "TU";
                    this.grid[i - 1, k + 1].FigureID = figureID;
                    this.grid[i - 1, k + 1].X = i - 1;
                    this.grid[i - 1, k + 1].Y = k + 1;

                    this.grid[i, k + 2].Color = Color.FromArgb(47, 79, 79);
                    this.grid[i, k + 2].Figure = "TU";
                    this.grid[i, k + 2].FigureID = figureID;
                    this.grid[i, k + 2].X = i;
                    this.grid[i, k + 2].Y = k + 2;

                    Figure figure = new Figure(this.grid[i, k], this.grid[i, k + 1], this.grid[i - 1, k + 1], this.grid[i, k + 2]);
                    this.figures.Add(figure);
                }

            }

        }
        private void drawTRight(int i, int k, int figureID)
        {
            if (k + 1 < this.width && i + 2 < this.height)
            {
                if (grid[i, k].Figure == "" && grid[i + 1, k].Figure == "" && grid[i + 2, k].Figure == "" && grid[i + 1, k + 1].Figure == "")
                {
                    this.contId += 1;

                    this.grid[i, k].Color = Color.FromArgb(255, 192, 203);
                    this.grid[i, k].Figure = "TR";
                    this.grid[i, k].FigureID = figureID;
                    this.grid[i, k].X = i;
                    this.grid[i, k].Y = k;

                    this.grid[i + 1, k].Color = Color.FromArgb(255, 192, 203);
                    this.grid[i + 1, k].Figure = "TR";
                    this.grid[i + 1, k].FigureID = figureID;
                    this.grid[i + 1, k].X = i + 1;
                    this.grid[i + 1, k].Y = k;

                    this.grid[i + 2, k].Color = Color.FromArgb(255, 192, 203);
                    this.grid[i + 2, k].Figure = "TR";
                    this.grid[i + 2, k].FigureID = figureID;
                    this.grid[i + 2, k].X = i + 2;
                    this.grid[i + 2, k].Y = k;

                    this.grid[i + 1, k + 1].Color = Color.FromArgb(255, 192, 203);
                    this.grid[i + 1, k + 1].Figure = "TR";
                    this.grid[i + 1, k + 1].FigureID = figureID;
                    this.grid[i + 1, k + 1].X = i + 1;
                    this.grid[i + 1, k + 1].Y = k + 1;

                    Figure figure = new Figure(this.grid[i, k], this.grid[i + 1, k], this.grid[i + 2, k], this.grid[i + 1, k + 1]);
                    this.figures.Add(figure);
                }

            }
        }
        private void drawTDown(int i, int k, int figureID)
        {
            if (i + 1 < this.height && k + 2 < this.width)
            {
                if (grid[i, k].Figure == "" && grid[i, k + 1].Figure == "" && grid[i, k + 2].Figure == "" && grid[i + 1, k + 1].Figure == "")
                {
                    this.contId += 1;

                    this.grid[i, k].Color = Color.FromArgb(147, 112, 219); 
                    this.grid[i, k].Figure = "TD";
                    this.grid[i, k].FigureID = figureID;
                    this.grid[i, k].X = i;
                    this.grid[i, k].Y = k;

                    this.grid[i, k + 1].Color = Color.FromArgb(147, 112, 219);
                    this.grid[i, k + 1].Figure = "TD";
                    this.grid[i, k + 1].FigureID = figureID;
                    this.grid[i, k + 1].X = i;
                    this.grid[i, k + 1].Y = k + 1;

                    this.grid[i, k + 2].Color = Color.FromArgb(147, 112, 219);
                    this.grid[i, k + 2].Figure = "TD";
                    this.grid[i, k + 2].FigureID = figureID;
                    this.grid[i, k + 2].X = i;
                    this.grid[i, k + 2].Y = k + 2;

                    this.grid[i + 1, k + 1].Color = Color.FromArgb(147, 112, 219);
                    this.grid[i + 1, k + 1].Figure = "TD";
                    this.grid[i + 1, k + 1].FigureID = figureID;
                    this.grid[i + 1, k + 1].X = i + 1;
                    this.grid[i + 1, k + 1].Y = k + 1;

                    Figure figure = new Figure(this.grid[i, k], this.grid[i, k + 1], this.grid[i, k + 2], this.grid[i + 1, k + 1]);
                    this.figures.Add(figure);
                }

            }

        }
        private void drawTLeft(int i, int k, int figureID)
        {
            if (i + 2 < this.height && k - 1 > 0)
            {
                if (grid[i, k].Figure == "" && grid[i + 1, k].Figure == "" && grid[i + 1, k - 1].Figure == "" && grid[i + 2, k].Figure == "")
                {
                    this.contId += 1;

                    this.grid[i, k].Color = Color.FromArgb(255, 127, 80);
                    this.grid[i, k].Figure = "TL";
                    this.grid[i, k].FigureID = figureID;
                    this.grid[i, k].X = i;
                    this.grid[i, k].Y = k;

                    this.grid[i + 1, k].Color = Color.FromArgb(255, 127, 80);
                    this.grid[i + 1, k].Figure = "TL";
                    this.grid[i + 1, k].FigureID = figureID;
                    this.grid[i + 1, k].X = i + 1;
                    this.grid[i + 1, k].Y = k;

                    this.grid[i + 2, k].Color = Color.FromArgb(255, 127, 80);
                    this.grid[i + 2, k].Figure = "TL";
                    this.grid[i + 2, k].FigureID = figureID;
                    this.grid[i + 2, k].X = i + 2;
                    this.grid[i + 2, k].Y = k;

                    this.grid[i + 1, k - 1].Color = Color.FromArgb(255, 127, 80);
                    this.grid[i + 1, k - 1].Figure = "TL";
                    this.grid[i + 1, k - 1].FigureID = figureID;
                    this.grid[i + 1, k - 1].X = i + 1;
                    this.grid[i + 1, k - 1].Y = k - 1;

                    Figure figure = new Figure(this.grid[i, k], this.grid[i + 1, k], this.grid[i + 2, k], this.grid[i + 1, k - 1]);
                    this.figures.Add(figure);
                }

            }


        }
        private void drawZ(int i, int k, int figureID)
        {
            if (i + 1 < this.height && k + 2 < this.width)
            {
                if (grid[i, k].Figure == "" && grid[i, k + 1].Figure == "" && grid[i + 1, k + 1].Figure == "" && grid[i + 1, k + 2].Figure == "")
                {
                    this.contId += 1;

                    this.grid[i, k].Color = Color.FromArgb(70, 130, 180);
                    this.grid[i, k].Figure = "Z";
                    this.grid[i, k].FigureID = figureID;
                    this.grid[i, k].X = i;
                    this.grid[i, k].Y = k;


                    this.grid[i, k + 1].Color = Color.FromArgb(70, 130, 180);
                    this.grid[i, k + 1].Figure = "Z";
                    this.grid[i, k + 1].FigureID = figureID;
                    this.grid[i, k + 1].X = i;
                    this.grid[i, k + 1].Y = k + 1;

                    this.grid[i + 1, k + 1].Color = Color.FromArgb(70, 130, 180);
                    this.grid[i + 1, k + 1].Figure = "Z";
                    this.grid[i + 1, k + 1].FigureID = figureID;
                    this.grid[i + 1, k + 1].X = i + 1;
                    this.grid[i + 1, k + 1].Y = k + 1;

                    this.grid[i + 1, k + 2].Color = Color.FromArgb(70, 130, 180);
                    this.grid[i + 1, k + 2].Figure = "Z";
                    this.grid[i + 1, k + 2].FigureID = figureID;
                    this.grid[i + 1, k + 2].X = i + 1;
                    this.grid[i + 1, k + 2].Y = k + 2;

                    Figure figure = new Figure(this.grid[i, k], this.grid[i, k + 1], this.grid[i + 1, k + 1], this.grid[i + 1, k + 2]);
                    this.figures.Add(figure);
                }

            }


        }
        private void drawZVertical(int i, int k, int figureID)
        {
            if (k - 1 > 0 && i + 2 < this.width)
            {
                if (grid[i, k].Figure == "" && grid[i + 1, k].Figure == "" && grid[i + 1, k - 1].Figure == "" && grid[i + 2, k - 1].Figure == "")
                {
                    this.contId += 1;

                    this.grid[i, k].Color = Color.FromArgb(0, 139, 139);
                    this.grid[i, k].Figure = "ZV";
                    this.grid[i, k].FigureID = figureID;
                    this.grid[i, k].X = i;
                    this.grid[i, k].Y = k;

                    this.grid[i + 1, k].Color = Color.FromArgb(0, 139, 139);
                    this.grid[i + 1, k].Figure = "ZV";
                    this.grid[i + 1, k].FigureID = figureID;
                    this.grid[i + 1, k].X = i + 1;
                    this.grid[i + 1, k].Y = k;

                    this.grid[i + 1, k - 1].Color = Color.FromArgb(0, 139, 139);
                    this.grid[i + 1, k - 1].Figure = "ZV";
                    this.grid[i + 1, k - 1].FigureID = figureID;
                    this.grid[i + 1, k - 1].X = i + 1;
                    this.grid[i + 1, k - 1].Y = k - 1;

                    this.grid[i + 2, k - 1].Color = Color.FromArgb(0, 139, 139);
                    this.grid[i + 2, k - 1].Figure = "ZV";
                    this.grid[i + 2, k - 1].FigureID = figureID;
                    this.grid[i + 2, k - 1].X = i + 2;
                    this.grid[i + 2, k - 1].Y = k - 1;

                    Figure figure = new Figure(this.grid[i, k], this.grid[i + 1, k], this.grid[i + 2, k - 1], this.grid[i + 2, k - 1]);
                    this.figures.Add(figure);
                }

            }

        }
        private void drawO(int i, int k, int figureID)
        {
            if (k + 1 < this.width && i + 1 < this.height)
            {
                if (grid[i, k].Figure == "" && grid[i + 1, k].Figure == "" && grid[i, k + 1].Figure == "" && grid[i + 1, k + 1].Figure == "")
                {
                    this.contId += 1;

                    this.grid[i, k].Color = Color.FromArgb(154, 205, 50);
                    this.grid[i, k].Figure = "O";
                    this.grid[i, k].FigureID = figureID;
                    this.grid[i, k].X = i;
                    this.grid[i, k].Y = k;

                    this.grid[i + 1, k + 1].Color = Color.FromArgb(154, 205, 50);
                    this.grid[i + 1, k + 1].Figure = "O";
                    this.grid[i + 1, k + 1].FigureID = figureID;
                    this.grid[i + 1, k + 1].X = i + 1;
                    this.grid[i + 1, k + 1].Y = k + 1;

                    this.grid[i + 1, k].Color = Color.FromArgb(154, 205, 50);
                    this.grid[i + 1, k].Figure = "O";
                    this.grid[i + 1, k].FigureID = figureID;
                    this.grid[i + 1, k].X = i + 1;
                    this.grid[i + 1, k].Y = k;

                    this.grid[i, k + 1].Color = Color.FromArgb(154, 205, 50);
                    this.grid[i, k + 1].Figure = "O";
                    this.grid[i, k + 1].FigureID = figureID;
                    this.grid[i, k + 1].X = i;
                    this.grid[i, k + 1].Y = k + 1;

                    Figure figure = new Figure(this.grid[i, k], this.grid[i + 1, k + 1], this.grid[i + 1, k], this.grid[i, k + 1]);
                    this.figures.Add(figure);
                }

            }

        }

        private void drawL(int i, int k, int figureID)
        {
            if (i + 2 < this.height && k + 1 < this.width)
            {
                if (grid[i, k].Figure == "" && grid[i + 1, k].Figure == "" && grid[i + 2, k].Figure == "" && grid[i + 2, k + 1].Figure == "")
                {
                    this.contId += 1;

                    this.grid[i, k].Color = Color.FromArgb(107, 142, 35);
                    this.grid[i, k].Figure = "L";
                    this.grid[i, k].FigureID = figureID;
                    this.grid[i, k].X = i;
                    this.grid[i, k].Y = k;

                    this.grid[i + 1, k].Color = Color.FromArgb(107, 142, 35);
                    this.grid[i + 1, k].Figure = "L";
                    this.grid[i + 1, k].FigureID = figureID;
                    this.grid[i + 1, k].X = i + 1;
                    this.grid[i + 1, k].Y = k;

                    this.grid[i + 2, k].Color = Color.FromArgb(107, 142, 35);
                    this.grid[i + 2, k].Figure = "L";
                    this.grid[i + 2, k].FigureID = figureID;
                    this.grid[i + 2, k].X = i + 2;
                    this.grid[i + 2, k].Y = k;

                    this.grid[i + 2, k + 1].Color = Color.FromArgb(107, 142, 35);
                    this.grid[i + 2, k + 1].Figure = "L";
                    this.grid[i + 2, k + 1].FigureID = figureID;
                    this.grid[i + 2, k + 1].X = i + 2;
                    this.grid[i + 2, k + 1].Y = k + 1;

                    Figure figure = new Figure(this.grid[i, k], this.grid[i + 1, k], this.grid[i + 2, k], this.grid[i + 2, k + 1]);
                    this.figures.Add(figure);

                }

            }

        }
        private void drawLU(int i, int k, int figureID)
        {
            if (i - 1 > 0 && k + 2 < this.width)
            {
                if (grid[i, k].Figure == "" && grid[i, k + 1].Figure == "" && grid[i, k + 2].Figure == "" && grid[i - 1, k + 2].Figure == "")
                {
                    this.contId += 1;

                    this.grid[i, k].Color = Color.FromArgb(255, 165, 0);
                    this.grid[i, k].Figure = "LU";
                    this.grid[i, k].FigureID = figureID;
                    this.grid[i, k].X = i;
                    this.grid[i, k].Y = k;

                    this.grid[i, k + 1].Color = Color.FromArgb(255, 165, 0);
                    this.grid[i, k + 1].Figure = "LU";
                    this.grid[i, k + 1].FigureID = figureID;
                    this.grid[i, k + 1].X = i;
                    this.grid[i, k + 1].Y = k + 1;

                    this.grid[i, k + 2].Color = Color.FromArgb(255, 165, 0);
                    this.grid[i, k + 2].Figure = "LU";
                    this.grid[i, k + 2].FigureID = figureID;
                    this.grid[i, k + 2].X = i;
                    this.grid[i, k + 2].Y = k + 2;

                    this.grid[i - 1, k + 2].Color = Color.FromArgb(255, 165, 0);
                    this.grid[i - 1, k + 2].Figure = "LU";
                    this.grid[i - 1, k + 2].FigureID = figureID;
                    this.grid[i - 1, k + 2].X = i - 1;
                    this.grid[i - 1, k + 2].Y = k + 2;

                    Figure figure = new Figure(this.grid[i, k], this.grid[i, k + 1], this.grid[i, k + 2], this.grid[i - 1, k + 2]);
                    this.figures.Add(figure);

                }

            }

        }
        private void drawLL(int i, int k, int figureID)
        {
            if (i + 3 < this.height && k + 1 < this.width)
            {
                if (grid[i, k].Figure == "" && grid[i, k + 1].Figure == "" && grid[i + 1, k + 1].Figure == "" && grid[i + 2, k + 1].Figure == "")
                {
                    this.contId += 1;

                    this.grid[i, k].Color = Color.FromArgb(178, 34, 34);
                    this.grid[i, k].Figure = "LL";
                    this.grid[i, k].FigureID = figureID;
                    this.grid[i, k].X = i;
                    this.grid[i, k].Y = k;

                    this.grid[i, k + 1].Color = Color.FromArgb(178, 34, 34);
                    this.grid[i, k + 1].Figure = "LL";
                    this.grid[i, k + 1].FigureID = figureID;
                    this.grid[i, k + 1].X = i;
                    this.grid[i, k + 1].Y = k + 1;

                    this.grid[i + 1, k + 1].Color = Color.FromArgb(178, 34, 34);
                    this.grid[i + 1, k + 1].Figure = "LL";
                    this.grid[i + 1, k + 1].FigureID = figureID;
                    this.grid[i + 1, k + 1].X = i + 1;
                    this.grid[i + 1, k + 1].Y = k + 1;

                    this.grid[i + 2, k + 1].Color = Color.FromArgb(178, 34, 34);
                    this.grid[i + 2, k + 1].Figure = "LL";
                    this.grid[i + 2, k + 1].FigureID = figureID;
                    this.grid[i + 2, k + 1].X = i + 2;
                    this.grid[i + 2, k + 1].Y = k + 1;

                    Figure figure = new Figure(this.grid[i, k], this.grid[i, k + 1], this.grid[i + 1, k + 1], this.grid[i + 2, k + 1]);
                    this.figures.Add(figure);

                }

            }
        }

        public void firstRow()
        {
            List<int> list = new List<int>();
            for (int i = 0; i < this.width; i++)
            {
                list.Add(i + 1);
            }

            for (int i = 0; i < this.width; i++)
            {
                if (list.Count == 1)
                {
                    this.grid[0, i].Value = list[0];
                    break;
                }
                Random rand = new Random(Guid.NewGuid().GetHashCode());
                int num = rand.Next(1, list.Count);
                this.grid[0, i].Value = list[num];
                list.RemoveAt(num);
            }
        }

        private void firstColumn()
        {
            List<int> list = new List<int>();

            for (int i = 0; i < this.width; i++)
            {
                list.Add(i+1);
            }

            for (int i = 0; i < this.width; i++)
            {
                if (list.Count == 1)
                {
                    this.grid[1, 0].Value = list[0];
                    break;
                }
                Random rand = new Random(Guid.NewGuid().GetHashCode());
                int num = rand.Next(1, list.Count);
                this.grid[1, 0].Value = list[num];
                list.RemoveAt(num);
            }
        }

        public bool placeNumbers(int n)
        {
            int row = -1;
            int col = -1;
            bool isEmpty = true;
            for (int i = 1; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (this.grid[i, j].Value == 0)
                    {
                        row = i;
                        col = j;

                        // we still have some remaining 
                        // missing values in Sudoku 
                        isEmpty = false;
                        break;
                    }
                }

                if (!isEmpty)
                {
                    break;
                }
            }

            // no empty space left 
            if (isEmpty)
            {
                return true;
            }

            // else for each-row backtrack 

            for (int num = 1; num <= n; num++)
            {
                if (isSafe(row, col, num))
                {
                    this.grid[row, col].Value = num;
                    if (placeNumbers(n))
                    {
                        return true;
                    }
                    else
                    {
                        this.grid[row, col].Value = 0; // replace it 
                    }
                }
            }
            return false;
        }

        private bool solveSudoku()
        {
            MainFigure figure = new MainFigure();
            Cage cage = new Cage();
            bool isEmpty = true;
            for (int i = 0; i < this.orderedFigures.Count; i++)
            {
                for (int j = 0; j < this.orderedFigures[i].cageList.Count; j++)
                {
                    if (this.orderedFigures[i].cageList[j].Value == 0)
                    {
                        cage = this.orderedFigures[i].cageList[j];
                        figure = this.orderedFigures[i];
                        isEmpty = false;
                        break;
                    }
                }
                if (!isEmpty)
                {
                    break;
                }
            }

            if (isEmpty)
            {
                return true;
            }

            for (int num = 1; num <= this.width; num++)
            {
                if (isSafe(cage.X, cage.Y, num) == true && figure.isSafe(num) == true)
                {
                    this.grid[cage.X, cage.Y].Value = num;
                    if (solveSudoku())
                    {
                        return true;
                    }
                    else
                    {
                        this.grid[cage.X, cage.Y].Value = 0;
                    }
                }
            }

            return false;
        }

        public void resetResults()
        {
            for (int i = 0; i < this.width; i++)
            {
                for (int j = 0; j < this.width; j++)
                {
                    this.grid[i, j].Value = 0;
                }
            }
        }

        private bool isSafe(int row, int column, int num)
        {
            for (int i = 0; i < this.width; i++)
            {
                if (this.grid[row, i].Value == num)
                {
                    return false;
                }
            }
            for (int j = 0; j < this.width; j++)
            {
                if (this.grid[j, column].Value == num)
                {
                    return false;
                }
            }
            return true;
        }

        private void generateResults()
        {
            for(int i = 0; i < this.figures.Count; i++)
            {
                this.figures[i].generateResult();
            }
        }

        private void orderFigures()
        {
            foreach (MainFigure i in this.figures)
            {
                if (i.GetType() == typeof(Figure1))
                {
                    this.orderedFigures.Add(i);
                }
            }
            foreach (MainFigure i in this.figures)
            {
                if (i.GetType() == typeof(Figure2))
                {
                    this.orderedFigures.Add(i);
                }
            }
            foreach (MainFigure i in this.figures)
            {
                if (i.GetType() == typeof(Figure3))
                {
                    this.orderedFigures.Add(i);
                }
            }
            foreach (MainFigure i in this.figures)
            {
                if (i.GetType() == typeof(Figure))
                {
                    this.orderedFigures.Add(i);
                }
            }
        }
    }
}