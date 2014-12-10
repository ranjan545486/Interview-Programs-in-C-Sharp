<Query Kind="Program" />

void Main()
{
	int[] a = new int[]{999,129,89,67,7,4,78,90};
	ReplaceWithSmallest(a,0,a.Length);
	
}

// Find an array of enormous size cannot sort the array

void ReplaceWithSmallest(int[] k_large, int k, int current)
{
	int small = k_large[0];
	int store_i = 0;
	for (int i = 0; i < current; i++)
	{
		if(small>k_large[i])
		{
			small = k_large[i];
			store_i = i;
		}
	}
	
	if(small<current)
        k_large[store_i]=current;
		
		small.Dump();

}
