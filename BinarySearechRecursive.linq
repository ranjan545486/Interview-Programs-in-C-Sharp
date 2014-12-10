<Query Kind="Program" />

void Main()
{
	BinarySearch bs = new BinarySearch();
	int[] a = new int[] {4,56,3,78,5,90,1};
    int temp = 0;
	temp = bs.BinarySearchRecursive(a,0,a.Length,90);
	temp.Dump();
}

// Recurrsive Binary Search

public class BinarySearch
{
	public int BinarySearchRecursive(int[] a, int low, int high, int data)
	{
		int mid = low + (high - low)/2 ; // toavoid overflow
		if(a[mid] == data)
		{
			return mid;
		}
		
		else if(a[mid]< data)
		{
			return BinarySearchRecursive(a,mid+1,high,data);
		}
		else
		{
			return BinarySearchRecursive(a,low,mid-1,data);
		}
		
		return -1;
	}
}
