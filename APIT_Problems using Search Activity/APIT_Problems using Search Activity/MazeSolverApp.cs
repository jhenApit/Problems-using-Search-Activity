using APIT_Problems_using_Search_Activity.Maze;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace APIT_Problems_using_Search_Activity
{
    public partial class MazeSolverApp : Form
    {
        private MazeSolver mazeSolver;
        private int[,] maze;
        private int mazeSize = 18;
        private int mazeRows = 15;
        private int mazeCols = 15;
        private int selectX;
        private int selectY;

        public MazeSolverApp() => InitializeComponent();

        private void MazeSolverApp_Load(object sender, EventArgs e)
        {
            mazeSolver = new MazeSolver(mazeRows, mazeCols);
            mazeArea.Size = new Size(mazeCols * mazeSize + 3, mazeRows * mazeSize + 3);
            maze = mazeSolver.GetMaze;
            lblPath.Visible = false;
            lblPathCaption.Visible = false;
        }

        private void btn_Exit_Click(object sender, EventArgs e) => Close();

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            mazeSolver = new MazeSolver(mazeRows, mazeCols);
            maze = mazeSolver.GetMaze;
            Refresh();
        }

        private void rdb_Find_CheckedChanged(object sender, EventArgs e)
        {
            lblPath.Visible = true;
            lblPathCaption.Visible = true;
        }

        private void rdb_Draw_CheckedChanged(object sender, EventArgs e)
        {
            maze = mazeSolver.GetMaze;
            lblPath.Visible = false;
            lblPathCaption.Visible = false;
            Refresh();
        }

        private void mazeArea_MouseMove(object sender, MouseEventArgs e)
        {
            int toY = e.Y / mazeSize;
            int toX = e.X / mazeSize;

            if (toX >= mazeCols || toX < 0 || toY >= mazeRows || toY < 0)
                return;

            maze = mazeSolver.GetMaze;

            if (!rdb_Draw.Checked)
            {
                int[,] path = mazeSolver.FindPath(selectY, selectX, toY, toX);

                if (path != null)
                {
                    maze = path;
                    lblPath.Text = "" + selectY + "," + selectX + " to " + toY + "," + toX;
                }
                else
                {
                    lblPath.Text = "No Path Found";
                }

                Refresh();
            }
        }

        private void mazeArea_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;

            for (int index1 = 0; index1 < mazeRows; ++index1)
            {
                for (int index2 = 0; index2 < mazeCols; ++index2)
                {
                    graphics.DrawRectangle(new Pen(Color.MediumPurple), index2 * mazeSize, index1 * mazeSize, mazeSize, mazeSize);

                    if (maze[index1, index2] == 1)
                    {
                        graphics.DrawString("✖", new Font("Arial Black", 10f), (Brush)new SolidBrush(Color.BlueViolet), index2 * mazeSize + 1, index1 * mazeSize + 1);
                    }
                   
                    if (maze[index1, index2] == 50)
                    {
                        graphics.FillRectangle((Brush)new SolidBrush(Color.Pink), index2 * mazeSize + 1, index1 * mazeSize + 1, mazeSize - 1, mazeSize - 1);
                    }
                }
            }

            graphics.FillEllipse((Brush)new SolidBrush(Color.DeepPink), selectX * mazeSize + 5, (selectY * mazeSize) + 5, mazeSize - 10, mazeSize - 10);
        }

        private void mazeArea_MouseDown(object sender, MouseEventArgs e)
        {
            int index1 = e.X / mazeSize;
            int index2 = e.Y / mazeSize;

            if (index1 >= mazeCols || index1 < 0 || index2 >= mazeRows || index2 < 0)
                return;

            if (rdb_Draw.Checked)
            {
                maze = mazeSolver.GetMaze;
                maze[index2, index1] = maze[index2, index1] != 0 ? 0 : 1;
                Refresh();
            }
            else if (maze[index2, index1] == 50)
            {
                while (selectX != index1 || selectY != index2)
                {
                    maze[selectY, selectX] = 0;

                    if (selectX - 1 >= 0 && selectX - 1 < mazeCols && maze[selectY, selectX - 1] == 50)
                    {
                        --selectX;
                    }
                    else if (selectX + 1 >= 0 && selectX + 1 < mazeCols && maze[selectY, selectX + 1] == 50)
                    {
                        ++selectX;
                    }
                    else if (selectY - 1 >= 0 && selectY - 1 < mazeRows && maze[selectY - 1, selectX] == 50)
                    {
                        --selectY;
                    }
                    else if (selectY + 1 >= 0 && selectY + 1 < mazeRows && maze[selectY + 1, selectX] == 50)
                    {
                        ++selectY;
                    }
                    else if (selectY + 1 >= 0 && selectY + 1 < mazeRows && selectX + 1 >= 0 && selectX + 1 < mazeCols && maze[selectY + 1, selectX + 1] == 50)
                    {
                        ++selectX;
                        ++selectY;
                    }
                    else if (selectY - 1 >= 0 && selectY - 1 < mazeRows && selectX + 1 >= 0 && selectX + 1 < mazeCols && maze[selectY - 1, selectX + 1] == 50)
                    {
                        ++selectX;
                        --selectY;
                    }
                    else if (selectY + 1 >= 0 && selectY + 1 < mazeRows && selectX - 1 >= 0 && selectX - 1 < mazeCols && maze[selectY + 1, selectX - 1] == 50)
                    {
                        --selectX;
                        ++selectY;
                    }
                    else if (selectY - 1 >= 0 && selectY - 1 < mazeRows && selectX - 1 >= 0 && selectX - 1 < mazeCols && maze[selectY - 1, selectX - 1] == 50)
                    {
                        --selectX;
                        --selectY;
                    }
                    Refresh();
                }
            }
        }
    }
}
