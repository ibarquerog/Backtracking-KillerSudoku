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

                    
                    
                }

            }
        }

    private void drawlVertical(int i, int k)
    {

    }

    private void drawlHorizontal(int i, int k)
    {

    }
    private void drawS(int i, int k)
    {

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

