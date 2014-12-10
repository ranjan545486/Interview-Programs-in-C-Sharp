<Query Kind="Program" />

void Main()
{
	int[] a = new int[] {-10,-9,-8,7,-8,-9,-10};
    int t = Search(a,0,a.Length-1);
	t.Dump();
}

public int Search(int[] a, int first, int last)
{
	int mid = first+(last-first)/2;
	while(first<=last)
	{
	if(first == last)
	{
		return a[first];
	}
	
	else if(first == last -1)
	{
		return Math.Max(a[first],a[last]);
	}
	
	else
	{
		if(a[mid-1]<a[mid] && a[mid]>a[mid+1])
		{
			return a[mid];
		}
		
		if(a[mid-1]<a[mid] && a[mid]<a[mid+1])
		first = mid+1;
		
		if(a[mid-1]>a[mid]&& a[mid]>a[mid+1])
		last = mid-1;
		else
		return int.MinValue;
	}
	
	}
	
	return int.MinValue;
}

//if the list is having negative to positive numbers then the least +ve number 1<k<n so output k

// a1a2a3a4b1b2b3b4-> a1b1a2b2a3b3a4b4

//araay1[i]+array2[i]=k
