using System.Drawing;
using System;
namespace KillerSudoku
{
    class Grid
    {
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
            int contId = 0;
            for (int i = 0; i < this.height; i++)
            {
                for (int k = 0; k < this.width; k++)
                {
                    Random rand = new Random(Guid.NewGuid().GetHashCode());
                    int randNum = rand.Next(1, 13);

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
                    }


                }

            }
        }

        private void drawlVertical(int i, int k, int figureID)
        {
            if (i + 3 < this.height)
            {
                if (grid[i, k].Figure == "" && grid[i + 1, k].Figure == "" && grid[i + 2, k].Figure == "" && grid[i + 3, k].Figure == "")
                    this.grid[i, k].Color = Color.CadetBlue;
                    this.grid[i, k].FigureID = figureID;
                    this.grid[i, k].Figure = "lVertical";
                    this.grid[i + 1, k].Color = Color.CadetBlue;
                    this.grid[i + 1, k].FigureID = figureID;
                    this.grid[i + 1, k].Figure = "lVertical";
                    this.grid[i + 2, k].Color = Color.CadetBlue;
                    this.grid[i + 2, k].FigureID = figureID;
                    this.grid[i + 2, k].Figure = "lVertical";
                    this.grid[i + 3, k].Color = Color.CadetBlue;
                    this.grid[i + 3, k].FigureID = figureID;
                    this.grid[i + 3, k].Figure = "lVertical";
                }
            }
        

        private void drawlHorizontal(int i, int k, int figureID)
        {
                if (k + 3 < this.width)
                {
                    if (grid[i, k].Figure == "" && grid[i, k + 1].Figure == "" && grid[i, k + 2].Figure == "" && grid[i, k + 3].Figure == "")
                    {
                        this.grid[i, k].Color = Color.LightGreen;
                        this.grid[i, k].Figure = "lHorizontal";
                        this.grid[i, k].FigureID = figureID;
                        this.grid[i, k + 1].Color = Color.LightGreen;
                        this.grid[i, k + 1].Figure = "lHorizontal";
                        this.grid[i, k + 1].FigureID = figureID;
                        this.grid[i, k + 2].Color = Color.LightGreen;
                        this.grid[i, k + 2].Figure = "lHorizontal";
                        this.grid[i, k + 2].FigureID = figureID;
                        this.grid[i, k + 3].Color = Color.LightGreen;
                        this.grid[i, k + 3].Figure = "lHorizontal";
                        this.grid[i, k + 3].FigureID = figureID;
                }

                }

            }
        private void drawS(int i, int k, int figureID)
        {
            if (k + 3 < this.width && i - 1 >0) 
            {
                if (grid[i, k].Figure == "" && grid[i, k + 1].Figure == "" && grid[i - 1, k + 1].Figure == "" && grid[i - 1, k+2].Figure == "")
                {
                    this.grid[i, k].Color = Color.GreenYellow;
                    this.grid[i, k].Figure = "S";
                    this.grid[i, k].FigureID = figureID;
                    this.grid[i, k + 1].Color = Color.GreenYellow;
                    this.grid[i, k + 1].Figure = "S";
                    this.grid[i, k + 1].FigureID = figureID;
                    this.grid[i - 1, k + 1].Color = Color.GreenYellow;
                    this.grid[i - 1, k + 1].Figure = "S";
                    this.grid[i - 1, k + 1].FigureID = figureID;
                    this.grid[i - 1, k + 2].Color = Color.GreenYellow;
                    this.grid[i - 1, k + 2].Figure = "S";
                    this.grid[i - 1, k + 2].FigureID = figureID;
                }

            }

        }
        private void drawSVertical(int i, int k, int figureID)
        {
            if (k + 1 < this.width && i + 3 < this.height )
            {
                if (grid[i, k].Figure == "" && grid[i + 1, k].Figure == "" && grid[i + 1, k + 1].Figure == "" && grid[i + 2, k + 1].Figure == "")
                {
                    this.grid[i, k].Color = Color.RosyBrown;
                    this.grid[i, k].Figure = "SV";
                    this.grid[i, k].FigureID = figureID;
                    this.grid[i + 1, k].Color = Color.RosyBrown;
                    this.grid[i + 1, k].Figure = "SV";
                    this.grid[i + 1, k].FigureID = figureID;
                    this.grid[i + 1, k + 1].Color = Color.RosyBrown;
                    this.grid[i + 1, k + 1].Figure = "SV";
                    this.grid[i + 1, k + 1].FigureID = figureID;
                    this.grid[i + 2, k + 1].Color = Color.RosyBrown;
                    this.grid[i + 2, k + 1].Figure = "SV";
                    this.grid[i + 2, k + 1].FigureID = figureID;
                }

            }

        }
        private void drawTUp(int i, int k, int figureID)
        {
            if (k + 3 < this.width && i - 1 > 0)
            {
                if (grid[i, k].Figure == "" && grid[i , k+1].Figure == "" && grid[i, k + 2].Figure == "" && grid[i - 1, k + 1].Figure == "")
                {
                    this.grid[i, k].Color = Color.DarkRed;
                    this.grid[i, k].Figure = "TU";
                    this.grid[i, k].FigureID = figureID;
                    this.grid[i, k + 1].Color = Color.DarkRed;
                    this.grid[i, k + 1].Figure = "TU";
                    this.grid[i, k + 1].FigureID = figureID;
                    this.grid[i - 1, k + 1].Color = Color.DarkRed;
                    this.grid[i - 1, k + 1].Figure = "TU";
                    this.grid[i - 1, k + 1].FigureID = figureID;
                    this.grid[i, k + 2].Color = Color.DarkRed;
                    this.grid[i, k + 2].Figure = "TU";
                    this.grid[i, k + 2].FigureID = figureID;
                }

            }

        }
        private void drawTRight(int i, int k, int figureID)
        {
            if (k + 1 < this.width && i + 2 < this.height)
            {
                if (grid[i, k].Figure == "" && grid[i + 1, k].Figure == "" && grid[i + 2, k].Figure == "" && grid[i + 1, k + 1].Figure == "")
                {
                    this.grid[i, k].Color = Color.MediumVioletRed;
                    this.grid[i, k].Figure = "TR";
                    this.grid[i, k].FigureID = figureID;
                    this.grid[i + 1, k].Color = Color.MediumVioletRed;
                    this.grid[i + 1, k].Figure = "TR";
                    this.grid[i + 1, k].FigureID = figureID;
                    this.grid[i + 2, k].Color = Color.MediumVioletRed;
                    this.grid[i + 2, k].Figure = "TR";
                    this.grid[i + 2, k].FigureID = figureID;
                    this.grid[i + 1, k + 1].Color = Color.MediumVioletRed;
                    this.grid[i + 1, k + 1].Figure = "TR";
                    this.grid[i + 1, k + 1].FigureID = figureID;
                }

            }
        }
        private void drawTDown(int i, int k, int figureID)
        {
            if (i + 1 < this.height && k + 2 < this.width)
            {
                if (grid[i, k].Figure == "" && grid[i, k + 1].Figure == "" && grid[i, k+2].Figure == "" && grid[i + 1, k + 1].Figure == "")
                {
                    this.grid[i, k].Color = Color.LightCoral; ;
                    this.grid[i, k].Figure = "TD";
                    this.grid[i, k].FigureID = figureID;
                    this.grid[i, k + 1].Color = Color.LightCoral;
                    this.grid[i, k + 1].Figure = "TD";
                    this.grid[i, k + 1].FigureID = figureID;
                    this.grid[i, k + 2].Color = Color.LightCoral;
                    this.grid[i, k + 2].Figure = "TD";
                    this.grid[i, k + 2].FigureID = figureID;
                    this.grid[i + 1, k + 1].Color = Color.LightCoral;
                    this.grid[i + 1, k + 1].Figure = "TD";
                    this.grid[i + 1, k + 1].FigureID = figureID;
                }

            }

        }
        private void drawTLeft(int i, int k, int figureID)
        {
            if (i + 2 < this.height && k - 1 > 0)
            {
                if (grid[i, k].Figure == "" && grid[i + 1, k].Figure == "" && grid[i + 1, k - 1].Figure == "" && grid[i + 2, k].Figure == "")
                {
                    this.grid[i, k].Color = Color.Orange; 
                    this.grid[i, k].Figure = "TL";
                    this.grid[i, k].FigureID = figureID;
                    this.grid[i + 1, k].Color = Color.Orange;
                    this.grid[i + 1, k].Figure = "TL";
                    this.grid[i + 1, k].FigureID = figureID;
                    this.grid[i + 2, k].Color = Color.Orange;
                    this.grid[i + 2, k].Figure = "TL";
                    this.grid[i + 2, k].FigureID = figureID;
                    this.grid[i + 1, k - 1].Color = Color.Orange;
                    this.grid[i + 1, k - 1].Figure = "TL";
                    this.grid[i + 1, k - 1].FigureID = figureID;
                }

            }


        }
        private void drawZ(int i, int k, int figureID)
        {
            if (i + 1 < this.height && k + 2 < this.width)
            {
                if (grid[i, k].Figure == "" && grid[i, k + 1].Figure == "" && grid[i + 1, k + 1].Figure == "" && grid[i + 1, k + 2].Figure == "")
                {
                    this.grid[i, k].Color = Color.LightPink;
                    this.grid[i, k].Figure = "TL";
                    this.grid[i, k].FigureID = figureID;
                    this.grid[i, k + 1].Color = Color.LightPink;
                    this.grid[i, k + 1].Figure = "TL";
                    this.grid[i, k + 1].FigureID = figureID;
                    this.grid[i + 1, k + 1].Color = Color.LightPink;
                    this.grid[i + 1, k + 1].Figure = "TL";
                    this.grid[i + 1, k + 1].FigureID = figureID;
                    this.grid[i + 1, k + 2].Color = Color.LightPink;
                    this.grid[i + 1, k + 2].Figure = "TL";
                    this.grid[i + 1, k + 2].FigureID = figureID;
                }

            }

        }
        private void drawZVertical(int i, int k, int figureID)
        {
            if (k - 1 > 0 && i + 2 < this.width)
            {
                if (grid[i, k].Figure == "" && grid[i+1, k].Figure == "" && grid[i + 1, k - 1].Figure == "" && grid[i + 2, k - 1].Figure == "")
                {
                    this.grid[i, k].Color = Color.LightSeaGreen;
                    this.grid[i, k].Figure = "ZV";
                    this.grid[i, k].FigureID = figureID;
                    this.grid[i + 1, k].Color = Color.LightSeaGreen;
                    this.grid[i + 1, k].Figure = "ZV";
                    this.grid[i + 1, k].FigureID = figureID;
                    this.grid[i + 1, k - 1].Color = Color.LightSeaGreen;
                    this.grid[i + 1, k - 1].Figure = "ZV";
                    this.grid[i + 1, k - 1].FigureID = figureID;
                    this.grid[i + 2, k - 1].Color = Color.LightSeaGreen;
                    this.grid[i + 2, k - 1].Figure = "ZV";
                    this.grid[i + 2, k - 1].FigureID = figureID;
                }

            }

        }
        private void drawO(int i, int k, int figureID)
        {
            if (k + 1< this.width && i + 1 < this.height)
            {
                if (grid[i, k].Figure == "" && grid[i + 1, k].Figure == "" && grid[i, k + 1].Figure == "" && grid[i + 1, k + 1].Figure == "")
                {
                    this.grid[i, k].Color = Color.LightSeaGreen;
                    this.grid[i, k].Figure = "ZV";
                    this.grid[i, k].FigureID = figureID;
                    this.grid[i + 1, k + 1].Color = Color.LightSeaGreen;
                    this.grid[i + 1, k + 1].Figure = "ZV";
                    this.grid[i + 1, k + 1].FigureID = figureID;
                    this.grid[i + 1, k].Color = Color.LightSeaGreen;
                    this.grid[i + 1, k].Figure = "ZV";
                    this.grid[i + 1, k].FigureID = figureID;
                    this.grid[i, k + 1].Color = Color.LightSeaGreen;
                    this.grid[i, k + 1].Figure = "ZV";
                    this.grid[i, k + 1].FigureID = figureID;
                }

            }

        }

    }

}