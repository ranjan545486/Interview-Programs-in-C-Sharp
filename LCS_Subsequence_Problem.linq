<Query Kind="Program" />

#define m
#define n

#define MIN

void Main()
{
	 findLCS();
    printLCSMatrix();
    //printLCS();    
    Console.Read();
}

internal static partial class DefineConstants
{
    public const int m = 2;
    public const int n = 4;
}

private int MAX(int a, int b)
{
    if (a > b)
    {
        return (a);
    }
    else
    {
        return (b);
    }
}

//we dont use X[0] and Y[0] we use X[1..m]  Y[1..n]

private string X = "Ran";

private string Y = "XYadp";
// LCS[i][j] = means length of common subsequence till X[1..i] and Y[1..j]
private int[,] LCS = new int[DefineConstants.m + 1, DefineConstants.n + 1];

private void findLCS()
{
    for (int i = 0; i <= DefineConstants.m; i++)
    {
        LCS[i, 0] = 0;
    }
    for (int j = 0; j <= DefineConstants.n; j++)
    {
        LCS[0, j] = 0;
    }
    for (int i = 1; i <= DefineConstants.m; i++)
    {
         for (int j = 1; j <= DefineConstants.n; j++)
         {
              if (X[i] == Y[j])
              {

                        LCS[i, j] = 1 + LCS[i - 1, j - 1];
              }
              else
              {
                   LCS[i, j] = MAX(LCS[i - 1, j], LCS[i, j - 1]);
              }
         }
    }

}

private void printLCSMatrix()
{
    for (int i = 0; i <= DefineConstants.m; i++)
    {
        for (int j = 0; j <= DefineConstants.n; j++)
        {
            Console.Write("L({0:D},{1:D})= {2:D} ",i,j,LCS[i, j]);
        }
        Console.Write("\n");
    }
}