<Query Kind="Program">
  <Connection>
    <ID>25de84bd-5375-4d79-89b9-b1a34db2b054</ID>
    <Persist>true</Persist>
    <Driver>AstoriaAuto</Driver>
    <Server>http://mfx/brhdataservice/</Server>
  </Connection>
</Query>

void Main()
{
	int[] a = new int[]{17,6,5,32,89,5,26,1}; // 
	HeapSort(a);
	a.Dump();
	
}

public static void HeapSort(int[] input)
	{
	    //Build-Max-Heap
	    int heapSize = input.Length;
	    for (int p = (heapSize - 1) / 2; p >= 0; p--)
	        MaxHeapify(input, heapSize, p);
	 
	    /*for (int i = input.Length - 1; i > 0; i--)
	    {
	        int temp = input[i];
	        input[i] = input[0];
	        input[0] = temp;
	 
	        heapSize--;
	        MaxHeapify(input, heapSize, 0);
	    }*/
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
	 

// Define other methods and classes here
