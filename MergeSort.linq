<Query Kind="Program" />

void Main()
{
	//Merge Sort
	int[] a = new int[]{67,2,89,6,78,1};
	int[] temp = new int[a.Length];
	MergeSorter m = new MergeSorter();
	m.MergeSort(a,temp,0,a.Length);
	a.Dump();
}

public class MergeSorter
{
	public void MergeSort(int[] a, int[] temp, int left, int right)
	{
		int mid;
		if(right>left)
		{
			mid =  (left+right)/2;
			MergeSort(a,temp,left,mid);
			MergeSort(a,temp,mid+1,right);
			Merge(a,temp,left,mid+1,right);
		}		
	}
	
	public void Merge(int[] a, int[] temp, int left, int mid, int right)
	{
		int i, left_end, temp_pos,size;
		left_end = mid-1;
		temp_pos = left;
		size = right - left+1;
		while((left<=left_end) && (mid<=right))
		{
			if(a[left]<=a[left_end])
			{
				temp[temp_pos]= a[left];
				temp_pos = temp_pos +1;
				left = left+1;
			}
			
			else
			{
				temp[temp_pos] = a[mid];
				mid = mid+1;
				temp_pos = temp_pos+1;
			}
		}
		
		while(left<=left_end)
		{
			temp[temp_pos]= a[left];
			temp_pos = temp_pos +1;
			left = left+1;
		}
		
		/*while(mid<=right)
		{
			temp[temp_pos] = a[mid];
			mid = mid+1;
			temp_pos = temp_pos+1;
		}*/
		
		
		for (i = left ; i <= right; i++)
		{
			a[i] = temp[i];
			right = right-1;
		}
	}
	
}

// Define other methods and classes here