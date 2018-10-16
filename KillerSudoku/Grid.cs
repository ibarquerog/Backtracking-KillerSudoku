﻿using System.Drawing;
using System;
namespace KillerSudoku
{

    class Grid
    {
        int contId = 0;
        public int width;
        public int height;
        public Cage[,] grid;


        public Grid(int width, int height)
        {
            this.width = width;
            this.height = height;
            grid = new Cage[this.width, this.height];
            initializeGrid();
            generatePuzzle();
            fillEntirePuzzle();
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

        private void drawlVertical(int i, int k, int figureID)
        {
            if (i + 3 < this.height)
            {
                if (grid[i, k].Figure == "" && grid[i + 1, k].Figure == "" && grid[i + 2, k].Figure == "" && grid[i + 3, k].Figure == "")
                {
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
                }
            }
        }


        private void drawlHorizontal(int i, int k, int figureID)
        {
            if (k + 3 < this.width)
            {
                if (grid[i, k].Figure == "" && grid[i, k + 1].Figure == "" && grid[i, k + 2].Figure == "" && grid[i, k + 3].Figure == "")
                {
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
                }

            }

        }
        private void drawS(int i, int k, int figureID)
        {
            if (k + 3 < this.width && i - 1 > 0)
            {
                if (grid[i, k].Figure == "" && grid[i, k + 1].Figure == "" && grid[i - 1, k + 1].Figure == "" && grid[i - 1, k + 2].Figure == "")
                {
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
                }

            }

        }
        private void drawSVertical(int i, int k, int figureID)
        {
            if (k + 1 < this.width && i + 3 < this.height)
            {
                if (grid[i, k].Figure == "" && grid[i + 1, k].Figure == "" && grid[i + 1, k + 1].Figure == "" && grid[i + 2, k + 1].Figure == "")
                {
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
                }

            }

        }
        private void drawTUp(int i, int k, int figureID)
        {
            if (k + 3 < this.width && i - 1 > 0)
            {
                if (grid[i, k].Figure == "" && grid[i, k + 1].Figure == "" && grid[i, k + 2].Figure == "" && grid[i - 1, k + 1].Figure == "")
                {
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
                }

            }

        }
        private void drawTRight(int i, int k, int figureID)
        {
            if (k + 1 < this.width && i + 2 < this.height)
            {
                if (grid[i, k].Figure == "" && grid[i + 1, k].Figure == "" && grid[i + 2, k].Figure == "" && grid[i + 1, k + 1].Figure == "")
                {
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
                }

            }
        }
        private void drawTDown(int i, int k, int figureID)
        {
            if (i + 1 < this.height && k + 2 < this.width)
            {
                if (grid[i, k].Figure == "" && grid[i, k + 1].Figure == "" && grid[i, k + 2].Figure == "" && grid[i + 1, k + 1].Figure == "")
                {
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
                }

            }

        }
        private void drawTLeft(int i, int k, int figureID)
        {
            if (i + 2 < this.height && k - 1 > 0)
            {
                if (grid[i, k].Figure == "" && grid[i + 1, k].Figure == "" && grid[i + 1, k - 1].Figure == "" && grid[i + 2, k].Figure == "")
                {
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
                }

            }


        }
        private void drawZ(int i, int k, int figureID)
        {
            if (i + 1 < this.height && k + 2 < this.width)
            {
                if (grid[i, k].Figure == "" && grid[i, k + 1].Figure == "" && grid[i + 1, k + 1].Figure == "" && grid[i + 1, k + 2].Figure == "")
                {
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
                }

            }


        }
        private void drawZVertical(int i, int k, int figureID)
        {
            if (k - 1 > 0 && i + 2 < this.width)
            {
                if (grid[i, k].Figure == "" && grid[i + 1, k].Figure == "" && grid[i + 1, k - 1].Figure == "" && grid[i + 2, k - 1].Figure == "")
                {
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
                }

            }

        }
        private void drawO(int i, int k, int figureID)
        {
            if (k + 1 < this.width && i + 1 < this.height)
            {
                if (grid[i, k].Figure == "" && grid[i + 1, k].Figure == "" && grid[i, k + 1].Figure == "" && grid[i + 1, k + 1].Figure == "")
                {
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
                }

            }

        }

        private void drawL(int i, int k, int figureID)
        {
            if (i + 2 < this.height && k + 1 < this.width)
            {
                if (grid[i, k].Figure == "" && grid[i + 1, k].Figure == "" && grid[i + 2, k].Figure == "" && grid[i + 2, k + 1].Figure == "")
                {
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


                }

            }

        }
        private void drawLU(int i, int k, int figureID)
        {
            if (i - 1 > 0 && k + 2 < this.width)
            {
                if (grid[i, k].Figure == "" && grid[i, k + 1].Figure == "" && grid[i, k + 2].Figure == "" && grid[i - 1, k + 2].Figure == "")
                {
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


                }

            }

        }
        private void drawLL(int i, int k, int figureID)
        {
            if (i + 3 < this.height && k + 1 < this.width)
            {
                if (grid[i, k].Figure == "" && grid[i, k + 1].Figure == "" && grid[i + 1, k + 1].Figure == "" && grid[i + 2, k + 1].Figure == "")
                {
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


                }

            }

        }

    }
}