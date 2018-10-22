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
            XmlWriterSettings settings = new XmlWriterSettings { Indent = true };
            using (XmlWriter writer = XmlWriter.Create(path,settings))
            {
                writer.WriteStartDocument();
                writer.WriteStartElement("Cages");

                foreach (Cage cage in sudoku.grid)
                {
                    writer.WriteStartElement("Cage");

                    writer.WriteElementString("X", cage.X.ToString());
                    writer.WriteElementString("Y", cage.Y.ToString());
                    writer.WriteElementString("FigureID", cage.FigureID.ToString());
                    writer.WriteElementString("Figure", cage.Figure.ToString());

                    writer.WriteEndElement();
                }

                writer.WriteEndElement();
                writer.WriteEndDocument();
            }

        }

        public Grid openFile(string path)
        {
            return null;
        }
        

    }
}
