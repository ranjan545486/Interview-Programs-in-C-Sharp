<Query Kind="Program" />

void Main()
{
	int[,] sol = new int[,] { {1, 1, 1, 0, 0},
	   {0, 0, 1, 1, 0},
	   {1, 0, 0, 1, 0},
	   {0, 1, 0, 1, 1},
	   {0, 0, 0, 0, 1}};
	sol.Dump();
	var c = SolveMaze(sol);
}

// Given a matrix(maze) with values in all as 0 and 1 find a path from top left to bottom right
/*     1 1 1 0 0
	   0 0 1 1 0
	   1 0 0 1 0
	   0 1 0 1 1
	   0 0 0 0 1

Strategy
Let' say M is the given matrix then the size will be if N is the size M[n,n] and M[i,j] = 0 or 1
4 moves can be defined and that is

UP:--   (i-1,j)
DOWN:-- (i+1,j)
LEFT:-- (i,j-1)
RIGHT:--(i,j+1)

1st condition to have an IsSafe method returning boolean which states whether true or false with the given path to be presumed
2nd condition is M[i',j']!=0
3rd condition is i>=0 && i<N
*/

private bool IsSafe(int[,] M, int i, int j)
        {
            int n = M.GetLength(1);
            if (i >= 0 && i < n && j >= 0 && j < n && M[i, j] == 1)
            {
                return true;
            }

            return false;
        }

        private bool SolveMazeUtil(int[,] m, int x, int y, int[,] sol)
        {
            int n = m.GetLength(1);
            if (x == n - 1 && y == n - 1)
            {
                sol[x, y] = 1;
                return true;
            }

            if (IsSafe(m, x, y))
            {
                sol[x, y] = 1;
                if (SolveMazeUtil(m, x + 1, y, sol)) return true;
                //if (SolveMazeUtil(m, x - 1, y, sol)) return true;
                //if (SolveMazeUtil(m, x, y - 1, sol)) return true;
                if (SolveMazeUtil(m, x, y + 1, sol)) return true;
                sol[x, y] = 0;
                return false;
            }
            return false;
        }

        public bool SolveMaze(int[,] m)
        {
            int[,] sol = new int[,] { {0, 0, 0, 0, 0},
	   {0, 0, 0, 0, 0},
	   {0, 0, 0, 0, 0},
	   {0, 0, 0, 0, 0},
	   {0, 0, 0, 0, 0}};
            if (!SolveMazeUtil(m, 0, 0, sol))
            {
                return false;
            }
            Print(sol);
            Console.ReadLine();
            return true;
        }

        public void Print(int[,] sol)
        {
            int n = sol.GetLength(1);
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.WriteLine("{0}", sol[i, j]);
                }
            }
        }