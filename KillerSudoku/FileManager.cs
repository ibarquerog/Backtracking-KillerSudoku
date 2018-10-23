using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Drawing;

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
            text += sudoku.width + "\r\n";
            text += sudoku.height + "\r\n";
            for (int i = 0; i < sudoku.figures.Count; i++)
            {
                text += "&" + "\r\n";
                foreach (Cage cage in sudoku.figures[i].cageList)
                {
                    text += cage.Figure + "\r\n";
                    text += cage.FigureID + "\r\n";
                    text += cage.X.ToString() + "\r\n";
                    text += cage.Y.ToString() + "\r\n";
                    text += ColorTranslator.ToHtml(cage.Color) + "\r\n";

                }
                text += sudoku.figures[i].FigResult + "\r\n";
                text += sudoku.figures[i].Operation + "\r\n";

            }
            
            System.IO.File.WriteAllText(path, text);

        }

        public Grid openFile(string path)
        {            
            List<MainFigure> list = new List<MainFigure>();
            System.IO.StreamReader file = new System.IO.StreamReader(path);
            string line;
            int width = int.Parse(file.ReadLine());
            
            int height = int.Parse(file.ReadLine());
            while ((line = file.ReadLine()) != null)
            {
                if (line == "&")
                {
                    line = file.ReadLine();  
                    if(line!="One" && line!="twoH" && line != "twoV" && line != "twoH" && line != "treeH" && line != "treeV")
                    {
                        string figure = line;
                        string id = file.ReadLine();
                        string x = file.ReadLine();
                        string y = file.ReadLine();
                        Color color = ColorTranslator.FromHtml(file.ReadLine());
                        Cage cage1 = new Cage();
                        cage1.X = int.Parse(x);
                        cage1.Y = int.Parse(y);
                        cage1.FigureID = int.Parse(id);
                        cage1.Figure = figure;

                        figure = file.ReadLine(); ; id = file.ReadLine(); x = file.ReadLine();  y = file.ReadLine();
                        file.ReadLine();
                        Cage cage2 = new Cage();
                        cage2.X = int.Parse(x);
                        cage2.Y = int.Parse(y);
                        cage2.Color = color;
                        cage2.FigureID = int.Parse(id);
                        cage2.Figure = figure;

                        figure = file.ReadLine(); ; id = file.ReadLine(); x = file.ReadLine(); y = file.ReadLine();
                        file.ReadLine();
                        Cage cage3 = new Cage();
                        cage3.X = int.Parse(x);
                        cage3.Y = int.Parse(y);
                        cage3.Color = color;
                        cage3.FigureID = int.Parse(id);
                        cage3.Figure = figure;

                        figure = file.ReadLine(); ; id = file.ReadLine(); x = file.ReadLine(); y = file.ReadLine();
                        file.ReadLine();
                        Cage cage4 = new Cage();
                        cage4.X = int.Parse(x);
                        cage4.Y = int.Parse(y);
                        cage4.Color = color;
                        cage4.FigureID = int.Parse(id);
                        cage4.Figure = figure;
                        Figure fig = new Figure(cage1, cage2, cage3, cage4);
                        fig.FigResult = int.Parse(file.ReadLine());
                        fig.Operation = file.ReadLine();
                        list.Add(fig);

                    }
                    else
                    {
                        if(line=="twoH" || line == "twoV")
                        {
                            string figure = line;
                            string id = file.ReadLine();
                            string x = file.ReadLine();
                            string y = file.ReadLine();
                            Color color = ColorTranslator.FromHtml(file.ReadLine());
                            Cage cage1 = new Cage();
                            cage1.X = int.Parse(x);
                            cage1.Y = int.Parse(y);
                            cage1.Color = color;
                            cage1.FigureID = int.Parse(id);
                            cage1.Figure = figure;

                            figure = file.ReadLine(); ; id = file.ReadLine(); x = file.ReadLine(); y = file.ReadLine();
                            file.ReadLine();
                            Cage cage2 = new Cage();
                            cage2.X = int.Parse(x);
                            cage2.Y = int.Parse(y);
                            cage2.Color = color;
                            cage2.FigureID = int.Parse(id);
                            cage2.Figure = figure;

                            Figure2 fig = new Figure2(cage1, cage2);
                            fig.FigResult = int.Parse(file.ReadLine());
                            fig.Operation = file.ReadLine();
                            list.Add(fig);

                        }
                        else
                        {
                            if (line == "treeH" || line == "treeV")
                            {
                                string figure = line;
                                string id = file.ReadLine();
                                string x = file.ReadLine();
                                string y = file.ReadLine();
                                Color color = ColorTranslator.FromHtml(file.ReadLine());
                                Cage cage1 = new Cage();
                                cage1.X = int.Parse(x);
                                cage1.Y = int.Parse(y);
                                cage1.Color = color;
                                cage1.FigureID = int.Parse(id);
                                cage1.Figure = figure;

                                figure = file.ReadLine(); ; id = file.ReadLine(); x = file.ReadLine(); y = file.ReadLine();
                                file.ReadLine();
                                Cage cage2 = new Cage();
                                cage2.X = int.Parse(x);
                                cage2.Y = int.Parse(y);
                                cage2.Color = color;
                                cage2.FigureID = int.Parse(id);
                                cage2.Figure = figure;

                                figure = file.ReadLine(); ; id = file.ReadLine(); x = file.ReadLine(); y = file.ReadLine();
                                file.ReadLine();
                                Cage cage3 = new Cage();
                                cage3.X = int.Parse(x);
                                cage3.Y = int.Parse(y);
                                cage3.Color = color;
                                cage3.FigureID = int.Parse(id);
                                cage3.Figure = figure;

                                Figure3 fig = new Figure3(cage1, cage2, cage3);
                                fig.FigResult = int.Parse(file.ReadLine());
                                fig.Operation = file.ReadLine();
                                list.Add(fig);
                            }
                            else
                            {
                                string figure = line;
                                string id = file.ReadLine();
                                string x = file.ReadLine();
                                string y = file.ReadLine();
                                Color color = ColorTranslator.FromHtml(file.ReadLine());
                                Cage cage1 = new Cage();
                                cage1.Figure = figure;
                                cage1.X = int.Parse(x);
                                cage1.Y = int.Parse(y);
                                cage1.Color = color;
                                cage1.FigureID = int.Parse(id);

                                Figure1 fig = new Figure1(cage1);
                                fig.FigResult = int.Parse(file.ReadLine());
                                fig.Operation = file.ReadLine();
                                list.Add(fig);

                            }

                        }
                    }

                }
            }

            Grid grid = new Grid(width, height);

            for(int i = 0; i < list.Count; i++)
            {
                foreach(Cage cage in list[i].cageList)
                {
                    grid.grid[cage.X, cage.Y] = cage;
                }
            }
            grid.figures = list;
            grid.orderedFigures.Clear();
            grid.orderFigures(); 
            return grid;
        }

        

    }
}
