<Query Kind="Program" />

void Main()
{
	int[,] a = new int[,]{{1,3},{2,4},{3,5},{9,7},{5,3},{7,2}};
	FindSymmetric(a);
	List<int> l = a.Cast<int>().ToList();
	l.Dump();
}

// symmetric in pairs

public void FindSymmetric(int[,] a)
{
	var hs = new HashSet<int[,]>();
	hs.Add(a);
	var d = new Dictionary<int,int>();
	var c = Enumerable.Range(0, a.GetLength(0)).ToDictionary(i => a[i, 0], i => a[i, 1]);
	for (int i = 0; i < a.GetLength(0); i++)
	{
		for (int j = 0; j < a.GetLength(1); j++)
		{
		  d.Add(j,a[i+1,j]);
		}
		
	}
	/*var d = new Dictionary<int,HashSet<int[,]>>();
	
			
		}
	}
	
	
	hs.Dump();*/
}
