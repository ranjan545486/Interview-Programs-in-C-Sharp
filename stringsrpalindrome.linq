<Query Kind="Program" />

void Main()
{
 string[] a = new string[]{"niin","nitin"};
	var i = lps_DP(a);
	i.Dump();
}

int lps_DP(string [] str)
	{	int n = str.Length;
		int [,] table = new int[n,n] ;
		
		for(int i = 0;i<n;i++)
			table[i,i] = 1;
		
		for(int len = 2;len <=n;len++)
		{
			for(int i = 0;i <n-len+1;i++)
				{
				int j = i + len - 1;
				if(str[i]==str[j] && len ==2)
					table[i,j] = 2;
				else if(str[i]==str[j])
					table[i,j] = table[i+1,j-1]+2;
				else
					table[i,j] =Math.Max(table[i,j-1],table[i+1,j]);
				}
			
			
		}
		
		
		return table[0,n-1];
	}
	


// Define other methods and classes here
