<Query Kind="Program" />

void Main()
{
	int[] a = new int[] {6,1,89,4,78,2};
    Heap.HeapSort(a);
	a.Dump();
}


public class Heap
{
	public static void HeapSort(int[] input)
	{
		//Build-Max-Heap
		int heapSize = input.Length;
		for (int p = (heapSize - 1) / 2; p >= 0; p--)
			MaxHeapify(input, heapSize, p);
	
		for (int i = input.Length - 1; i > 0; i--)
		{
			//Swap
			int temp = input[i];
			input[i] = input[0];
			input[0] = temp;
	
			heapSize--;
			MaxHeapify(input, heapSize, 0);
		}
	}
 
 
	private static void MaxHeapify(int[] input, int heapSize, int index)
	{
		int left = (index + 1) * 2 - 1;
		int right = (index + 1) * 2;
		int largest = 0;
	
		if (left < heapSize && input[left] > input[index])
			largest = left;
		else
			largest = index;
	
		if (right < heapSize && input[right] > input[largest])
			largest = right;
	
		if (largest != index)
		{
			int temp = input[index];
			input[index] = input[largest];
			input[largest] = temp;
	
			MaxHeapify(input, heapSize, largest);
		}
	}
} 

 


/*Define other methods and classes here
Class Heap
{
 int count; // number of elements in heap
 int capacity; // size
 int[] array;
 int heapType // min or max heap
 
}

class heapify
{
	public Heap CreateHeap(int capacity, int heaptype)
	{
		Heap h = new Heap();
		h.heaptype = heaptype;
		h.capacity = capacity;
		h.array = new int[h.capacity];
		return h;
	}
	
	public int Parent(Heap h, int n)
	{
		if(n ==0 || n>= h.count)
		{
		 return -1;
		}
		
		return (n-1)/2;
	}
	
	public int LeftChild(Heap h, int i)
	{
		int left = 2*i+1;
		if(left>= h.count)
		{
			return -1;
		}
		
		return left;
	}
	
	public int RightChild(Heap h , int i)
	{
		int right = 2*i+2;
		if(right>= h.count)
		{
		 return -1;
		}
		
		return right;
	}
	
	public void ShiftDown(Heap h, int i)
	{
		int l,r, temp, max;
		l = this.LeftChild(h,i);
		r= this.RightChild(h,i);
		if(l!=-1 && h.array[l]>h.array[i])
		{
			max = l;
		}
		else
		{
			max = i;
		}
		
		if(r!=-1 && h.array[r]>h.array[max])
		{
		  max= r;
		}
		
	    if(max!=i)
		{
			temp = h.array[i]
			h.array[i] = h.array[max];
			h.array[max] = temp;
		}
		
		ShiftDown(h, max);
	}
	
	public int DeleteMax(Heap h)
	{
		int data;
		if(h.count ==0)
		{
			return -1;
		}
		
		data = h.array[0];
		h.array[0] = h.array[h.count -1];
		h.count --;
		ShiftDown(h,0);
		return data;
	}
	
	
	public void ResizeHeap(Heap h)
	{
		int[] array_old = h.array;
		h.array = new int[h.capacity * 2];
		for(int i = 0; i<h.capacity;i++)
		{
			h.array[i] = array_old[i];			
		}
		
		h.capacity *=2;
	}
	
	public int Insert(Heap h, int data)
	{
	    int i;
		if(h.count == h.capacity)
		{
			ResizeHeap(h);
		}
		
		h.count++;  // increasing the heap size to hold this new item.
		i = h.count -1;
		while(i>=0 && data>h.array[(i-1)/2]
		{
			h.array[i] = h.array[(i-1)/2];
			i= (i-1)/2;
		}
		
		h.array[i] = data;
	}
	
	public void BuildHeap(Heap h, int[] a,int n )
	{
		if(h==null)
		{
		 return;		 
		}
		
		while(n > h.capacity)
		{
			Resize(h);
		}
		
		for(int i=0;i<n;i++)
		{
			h.array[i] = a[i];
		}
		
		h.count = n;
		for(int i=(n-1)/2;i>=0;i--)
		{
			ShiftDown(h,i);
		}		
	}
	
	public void HeapSort(int[] a, int n)
	{
		Heap h = CreateHeap(n);
		int old_size, i, temp;
		BuildHeap(h,a,n);
		old_size = h.count;
		for(i=n;i>0; i--)
		{
			//h.array[0] is the largest element
			temp = h.array[0];
			h.array[0] = h.array[h.count -1];
			h.array[h.count - 1] = temp;
			h.count--;
			Shiftdown(h,i);
		}
		
		h.count = old_size;
	}
	
	
		
}*/


// http://content.gpwiki.org/index.php/C_sharp:BinaryHeapOfT

