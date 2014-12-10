<Query Kind="Program" />

internal static partial class DefineConstants
    {
        public const int UNASSIGNED = 0;
        public const int N = 4;
        public const int SQN = 2;
    }

    class Program
    {
        public static int Main()
        {
            Program p = new Program();
            // 0 means unassigned cells
            int[,] grid =
    	{
	    	{0,0,3,4},
		    {3,4,0,0},
		    {0,0,4,3},
		    {0,3,2,0}
	    };

            if (p.SolveSudoku(grid) == true)
            {
                p.printGrid(grid);
            }
            else
            {
                Console.Write("No solution exists");
            }
            Console.ReadLine();
            return 0;

        }

        // This function finds an entry in grid that is still unassigned
        private bool FindUnassignedLocation(int[,] grid, ref int row, ref int col)
        {
            for (row = 0; row < DefineConstants.N; row++)
            {
                for (col = 0; col < DefineConstants.N; col++)
                {
                    if (grid[row, col] == DefineConstants.UNASSIGNED)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        /* Returns a boolean which indicates whether it will be legal to assign
           num to the given row,col location. */

        // Checks whether it will be legal to assign num to the given row,col
        private bool isSafe(int[,] grid, int row, int col, int num)
        {
            /* Check if 'num' is not already placed in current row,
               current column and current 3x3 box */
            return !UsedInRow(grid, row, num) && !UsedInCol(grid, col, num) && !UsedInBox(grid, row - row % DefineConstants.SQN, col - col % DefineConstants.SQN, num);
        }

        /* Takes a partially filled-in grid and attempts to assign values to
          all unassigned locations in such a way to meet the requirements
          for Sudoku solution (non-duplication across rows, columns, and boxes) */
        private bool SolveSudoku(int[,] grid)
        {
            int row = 0;
            int col = 0;

            // If there is no unassigned location, we are done
            if (!FindUnassignedLocation(grid, ref row, ref col))
            {
                return true; // success!
            }

            // consider digits 1 to 9
            for (int num = 1; num <= DefineConstants.N; num++)
            {
                // if looks promising
                if (isSafe(grid, row, col, num))
                {
                    // make tentative assignment
                    grid[row, col] = num;

                    // return, if success, yay!
                    if (SolveSudoku(grid))
                    {
                        return true;
                    }

                    // failure, unmake & try again
                    grid[row, col] = DefineConstants.UNASSIGNED;
                }
            }
            return false; // this triggers backtracking
        }

        /* Returns a boolean which indicates whether any assigned entry
           in the specified row matches the given number. */
        private bool UsedInRow(int[,] grid, int row, int num)
        {
            for (int col = 0; col < DefineConstants.N; col++)
            {
                if (grid[row, col] == num)
                {
                    return true;
                }
            }
            return false;
        }

        /* Returns a boolean which indicates whether any assigned entry
           in the specified column matches the given number. */
        private bool UsedInCol(int[,] grid, int col, int num)
        {
            for (int row = 0; row < DefineConstants.N; row++)
            {
                if (grid[row, col] == num)
                {
                    return true;
                }
            }
            return false;
        }

        /* Returns a boolean which indicates whether any assigned entry
           within the specified 3x3 box matches the given number. */
        private bool UsedInBox(int[,] grid, int boxStartRow, int boxStartCol, int num)
        {
            for (int row = 0; row < DefineConstants.SQN; row++)
            {
                for (int col = 0; col < DefineConstants.SQN; col++)
                {
                    if (grid[row + boxStartRow, col + boxStartCol] == num)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        /* A utility function to print grid  */
        private void printGrid(int[,] grid)
        {
            for (int row = 0; row < DefineConstants.N; row++)
            {
                for (int col = 0; col < DefineConstants.N; col++)
                {
                    Console.Write("{0,2:D}", grid[row, col]);
                }
                Console.Write("\n");
            }
        }
    }