using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIT_Problems_using_Search_Activity.Maze
{
    public class Maze
    {
        protected int[,] baseMaze;
        protected int rows;
        protected int cols;
        protected int path = 50;

        public event MazeChangedHandler OnMazeChangedEvent;
        public Maze(int[,] maze)
        {
            this.baseMaze = maze;
            this.rows = maze.GetLength(0);
            this.cols = maze.GetLength(1);
        }

        public Maze(int rows, int cols)
        {
            this.baseMaze = new int[rows, cols];
            this.rows = rows;
            this.cols = cols;
        }

        public int Rows => this.rows;

        public int Cols => this.cols;

        public int[,] GetMaze => this.baseMaze;

        public int PathCharacter
        {
            get => this.path;
            set => this.path = value != 0 ? value : throw new Exception("Invalid path character specified");
        }

        public int this[int row, int col]
        {
            get => this.baseMaze[row, col];
            set
            {
                this.baseMaze[row, col] = value;
                if (this.OnMazeChangedEvent == null)
                    return;
                this.OnMazeChangedEvent(row, col);
            }
        }
    }
}

