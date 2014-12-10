<Query Kind="Program" />

void Main()
{
	//var x = Pascal(8,8);
	//x.Dump();
	//int[] x = {0, 1, 0};
	//int[] y = {0};
	//var c= PascalR(x, y, 0);
	CreateTriangle(24);
}

// Pascal triangle
// non recirsive
public static void CreateTriangle(int n) {
            if (n > 0) {
                for (int i = 0; i < n; i++) {
                    int c = 1;
                    Console.Write(" ".PadLeft(2 * (n - 1 - i)));
                    for (int k = 0; k <= i; k++) {
                        Console.Write("{0}", c.ToString().PadLeft(3));
                        c = c * (i - k) / (k + 1);
                    }
                    Console.WriteLine();
                }
            }
        }
	

public int Pascal(int row, int col)
{
 int a, b = 0;
 if(row==0||col==0||row==col +1)
 return 1;
 a=Pascal(row-1,col-1);
 b=Pascal(row-1,col);
 return a+b;
}

public int PascalR(int[] x, int[] y, int d)
{
 int D = 32;
	for (int i = 1; i < d; i++)
	{
	if(i<2)
		y[i]=x[i-1]+x[i];
		var c = i < d-1 ?" " : "\n";
		Console.WriteLine("{0}{1}", y[i],c);
		
	}
	return D>d?PascalR(y,x,d+1):0; 
}