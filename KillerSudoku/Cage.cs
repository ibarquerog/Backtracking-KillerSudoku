using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KillerSudoku
{
    class Cage
    {
    private int value;
    private int x;
    private int y;
    private string figure;

        public Cage(int x, int y)
        {
            this.value = 0;
            this.x = x;
            this.y = y;
            this.figure = null;
        }

    }
}
