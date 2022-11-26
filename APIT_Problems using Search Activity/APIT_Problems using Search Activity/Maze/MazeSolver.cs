namespace APIT_Problems_using_Search_Activity.Maze
{
    public class MazeSolver : Maze
    {
        public MazeSolver(int[,] maze) : base(maze)
        {
            baseMaze = maze;
            rows = maze.GetLength(0);
            cols = maze.GetLength(1);
        }

        public MazeSolver(int rows, int cols) : base(rows, cols)
        {
            baseMaze = new int[rows, cols];
            base.rows = rows;
            base.cols = cols;
        }

        private int GetNodeContents(int[,] maze, int nodeNum)
        {
            int length = maze.GetLength(1);
            return maze[nodeNum / length, nodeNum - nodeNum / length * length];
        }

        private void ChangeNodeContents(int[,] maze, int nodeNum, int newVal)
        {
            int length = maze.GetLength(1);
            maze[nodeNum / length, nodeNum - nodeNum / length * length] = newVal;
        }

        public int[,] FindPath(int fromY, int fromX, int toY, int toX) => Search(fromY * this.Cols + fromX, toY * this.Cols + toX);

        private int[,] Search(int start, int end)
        {
            int Rows = rows;
            int Cols = cols;
            int length = Rows * Cols;
            int[] numArray1 = new int[length];
            int[] numArray2 = new int[length];
            int index1 = 0;
            int index2 = 0;

            if (GetNodeContents(baseMaze, start) != 0 || GetNodeContents(baseMaze, end) != 0)
                return (int[,])null;

            int[,] maze_1 = new int[Rows, Cols];

            for (int index3 = 0; index3 < Rows; ++index3)
            {
                for (int index4 = 0; index4 < Cols; ++index4)
                    maze_1[index3, index4] = 0;
            }

            numArray1[index2] = start;
            numArray2[index2] = -1;
            
            for (int index5 = index2 + 1; index1 != index5 && numArray1[index1] != end; ++index1)
            {
                int node_1 = numArray1[index1];
                int node_2 = node_1 - 1;

                if (node_2 >= 0 && node_2 / Cols == node_1 / Cols && GetNodeContents(baseMaze, node_2) == 0 && GetNodeContents(maze_1, node_2) == 0)
                {
                    numArray1[index5] = node_2;
                    numArray2[index5] = node_1;
                    ChangeNodeContents(maze_1, node_2, 1);
                    ++index5;
                }

                int node_3 = node_1 + 1;
               
                if (node_3 < length && node_3 / Cols == node_1 / Cols && GetNodeContents(baseMaze, node_3) == 0 && GetNodeContents(maze_1, node_3) == 0)
                {
                    numArray1[index5] = node_3;
                    numArray2[index5] = node_1;
                    ChangeNodeContents(maze_1, node_3, 1);
                    ++index5;
                }

                int node_4 = node_1 - Cols;
                
                if (node_4 >= 0 && GetNodeContents(baseMaze, node_4) == 0 && GetNodeContents(maze_1, node_4) == 0)
                {
                    numArray1[index5] = node_4;
                    numArray2[index5] = node_1;
                    ChangeNodeContents(maze_1, node_4, 1);
                    ++index5;
                }
                
                int node_5 = node_1 + Cols;
                
                if (node_5 < length && GetNodeContents(baseMaze, node_5) == 0 && GetNodeContents(maze_1, node_5) == 0)
                {
                    numArray1[index5] = node_5;
                    numArray2[index5] = node_1;
                    ChangeNodeContents(maze_1, node_5, 1);
                    ++index5;
                }
                
                ChangeNodeContents(maze_1, node_1, 2);
            }

            int[,] maze_2 = new int[Rows, Cols];
            
            for (int index6 = 0; index6 < Rows; ++index6)
            {
                for (int index7 = 0; index7 < Cols; ++index7)
                    maze_2[index6, index7] = baseMaze[index6, index7];
            }
            
            int nodeNum = end;

            ChangeNodeContents(maze_2, nodeNum, path);

            for (int index8 = index1; index8 >= 0; --index8)
            {
                if (numArray1[index8] == nodeNum)
                {
                    nodeNum = numArray2[index8];
                    if (nodeNum == -1)
                        return maze_2;
                    ChangeNodeContents(maze_2, nodeNum, path);
                }
            }
            return null;
        }
    }
}
