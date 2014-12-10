<Query Kind="Program">
  <Output>DataGrids</Output>
</Query>

void Main()
{
	int[,] a = new int[,] { { 1, 0, 0, 1 }, { 0, 0, 1, 0 }, { 0, 0, 1, 0 }, { 1, 0, 0, 1 } };

	//new int[,]{{1,0,0,1},{1,0,1,0},{0,0,1,0}};
	a.Dump();
	int i = 0;	
	ShowConnectedSetsInMatrix m = new ShowConnectedSetsInMatrix();
	i = m.show(a);
	i.Dump();
}

public class ShowConnectedSetsInMatrix
{
 private static void StatMan(int[,] a, int row, int col, int x)
        {
            if (col + 1 > a.GetLength(1) || row + 1 > a.GetLength(0) || col <0 || row<0)
            {
                return;
            }

            if (a[row, col] != 1)
            {
                return;
            }

            a[row, col] = 0;
            x++;
            StatMan(a, row, col + 1, x);
            StatMan(a, row, col - 1, x);
            StatMan(a, row, col, x);
            StatMan(a, row+1, col, x);
            StatMan(a, row-1, col, x);            
        }
		
 	public int show(int[,] arr)
        {
            int count = 0;
            int col = arr.GetLength(1);
            int row = arr.GetLength(0);
			for (int i = 0; i < row; i++)
			{
				for (int j = 0; j < col; j++)
				{
					if(arr[i,j]==1)
					{
						count++;
						StatMan(arr,i,j,count);
					}
				}
			}
			
			return count;
           
        }
}
            /*for(int i = 0; i<length;i++)
            {
                for(int j = 0; j<length; j++)
                {
                 for(int k = 0; k<length;k++)
                 {
			  		  while (row != 0)
            {
                for (int j = i; j <= col - 1; j++)
                {
                    if ((j + 1) < col && (i + 1) < row)
                    {
                        if ((arr[i, j] * arr[i + 1, j]) == 1 || (arr[i, j] * arr[i, j + 1]) == 1)
                        {
                            s=s+1;
                        }
                        if ((arr[i, j] * arr[i + 1, j]) != 1 && 
								 (arr[i, j] * arr[i, j + 1]) != 1 && 
								    ((arr[i, j] + arr[i + 1, j]) == 1 || 
								     (arr[i, j] + arr[i, j + 1]) == 1))
                        {
                            s = s+1;
                        }
                    }
                }

                i++;
                row--;
                temp = s; 
                 }
                }
            }*/

  

// Define other methods and classes here