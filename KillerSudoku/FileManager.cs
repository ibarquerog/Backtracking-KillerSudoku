using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;

namespace KillerSudoku
{
    class FileManager
    {
        public FileManager()
        {

        }

        public void saveFile(Grid sudoku,string path)
        {
            string text = "";
            for (int i = 0; i < sudoku.figures.Count; i++)
            {
                foreach(Cage cage in sudoku.figures[i].cageList)
                {
                    text += cage.Figure + "," ;
                    text += cage.FigureID+",";
                    text += cage.X.ToString()+",";
                    text += cage.Y.ToString() + ",";
                    text += cage.FigureID.ToString() + ",";
                    text += cage.Color.ToString() + "\r\n";
                }
            }
            
            System.IO.File.WriteAllText(path, text);

        }

        public Grid openFile(string path)
        {
            return null;
        }
        

    }
}
