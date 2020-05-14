using System.Collections.Generic;

namespace Algorithms.Recursion
{
    public class RobotGrid
    {
        public class Point
        {
            public Point(int r, int c)
            {
                row = r;
                column = c;
            }

            public int row { get; set; }
            public int column { get; set; }
        }

        public List<Point> FindPath(bool[][] grid)
        {
            if (grid == null || grid.Length == 0)
                return null;

            List<Point> path = new List<Point>();
            if (FindPath(path, grid, grid.Length - 1, grid[0].Length - 1))
                return path;

            return null;
        }

        private bool FindPath(List<Point> path, bool[][] grid, int row, int col)
        {
            if (row < 0 || col < 0 || !grid[row][col])
                return false;

            if ((row == 0 && col == 0) || FindPath(path, grid, row, col - 1) || FindPath(path, grid, row - 1, col))
            {
                path.Add(new Point(row, col));
                return true;
            }

            return false;
        }
    }
}
