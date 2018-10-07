using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class Grid
    {
        public int width;
        public int height;
        public SingleBlock[,] grid;
        

        public Grid(int width,int height)
        {
            this.width = width;
            this.height = height;
            grid = new SingleBlock[this.width, this.height];
            initializeGrid();
            generatePuzzle();
        }

    private void initializeGrid()
    {
        for (int i = 0; i < this.height; i++)
        {
            for (int k = 0; k < this.width; k++)
            {
                this.grid[i, k] = new SingleBlock();
            }
        }
    }

    private void generatePuzzle()
        {
            for(int i = 0; i < this.height; i++)
            {
                for(int k = 0; k < this.width; k++)
                {
                Random rand = new Random(Guid.NewGuid().GetHashCode());
                int num = rand.Next(1, 4);
                if (this.grid[i, k].type == "")
                {
                    switch (num)
                    {
                        case 1:
                            drawlVertical(i,k);
                            break;
                        case 2:
                            drawlHorizontal(i,k);
                            break;
                        case 3:
                            drawS(i, k);
                            break;

                    }
                }
                    
                    
                }

            }
        }

    private void drawlVertical(int i, int k)
    {
        if (i + 3 < this.height)
        {
            if (grid[i, k].type == "" && grid[i + 1, k].type == "" && grid[i + 2, k].type == "" && grid[i + 3, k].type == "")
            {
                this.grid[i, k].color = Color.LightBlue;
                this.grid[i, k].type = "lVertical";
                this.grid[i + 1, k].color = Color.LightBlue;
                this.grid[i + 1, k].type = "lVertical";
                this.grid[i + 2, k].color = Color.LightBlue;
                this.grid[i + 2, k].type = "lVertical";
                this.grid[i + 3, k].color = Color.LightBlue;
                this.grid[i + 3, k].type = "lVertical";
            }

        }
    }

    private void drawlHorizontal(int i, int k)
    {
        if (k + 3 < this.width)
        {
            if (grid[i, k].type == "" && grid[i, k + 1].type == "" && grid[i, k + 2].type == "" && grid[i, k + 3].type == "")
            {
                this.grid[i, k].color = Color.Green;
                this.grid[i, k].type = "lHorizontal";
                this.grid[i, k + 1].color = Color.Green;
                this.grid[i, k + 1].type = "lHorizontal";
                this.grid[i, k + 2].color = Color.Green;
                this.grid[i, k + 2].type = "lHorizontal";
                this.grid[i, k + 3].color = Color.Green;
                this.grid[i, k + 3].type = "lHorizontal";
            }

        }
    }
    private void drawS(int i, int k)
    {
        if (k + 1 < this.width && i + 1 > +this.height && k - 1 > 0)
        {
            if (grid[i, k].type == "" && grid[i, k + 1].type == "" && grid[i - 1, k + 1].type == "" && grid[i + 1, k].type == "")
            {
                this.grid[i, k].color = Color.Red;
                this.grid[i, k].type = "S";
                this.grid[i, k + 1].color = Color.Red;
                this.grid[i, k + 1].type = "S";
                this.grid[i - 1, k - 1].color = Color.Red;
                this.grid[i - 1, k - 1].type = "S";
                this.grid[i + 1, k].color = Color.Red;
                this.grid[i + 1, k].type = "S";
            }

        }
    }
        private void drawSVertical(int i, int k)
        {
            

        }
        private  void drawTUp(int i, int k)
        {
                
        }
        private void drawTRight(int i, int k)
        {

        }
        private void drawTDown(int i, int k)
        {

        }
        private void drawTLeft(int i, int k)
        {

        }
        private void drawZ(int i, int k)
        {

        }
        private void drawZHorizontal(int i, int k)
        {

        }
        private void drawO(int i, int k)
        {

        }

    }

