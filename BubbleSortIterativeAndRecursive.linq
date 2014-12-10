<Query Kind="Program" />

//First sort Bubble Sort

void Main()
{
  int[] i = new int[] { 3, 1, 7, 9, 6, 8, 2 };
            BubbleSort b = new BubbleSort();
            int[] c = new int[i.Length];
            int n = 0;
            b.RecurrsiveBubbleSort(i, n);
            i = b.BubbleSortIterative(i);
            foreach (var item in c)
            {
                Console.WriteLine(item);
            }
            foreach (var item in i)
            {
                Console.WriteLine(item);
            }
            
            Console.ReadLine();
}

public class BubbleSort
{
    public void RecurrsiveBubbleSort(int[] arr, int n)
            {
                for (int i = 1; i < arr.Length; i++)
                {
                    if (arr[i-1] > arr[i])
                    {
                        Swap(ref arr[i], ref arr[i - 1]);
                    }
                }
                if (n<arr.Length)
                {
                    RecurrsiveBubbleSort(arr, ++n);                    
                }                
            }

    public int[] BubbleSortIterative(int[] n)
            {
                for (int i = 0; i < n.Length; i++)
                {
                    for (int j = 0; j < i; j++)
                    {
                        if ( n[i] < n[j])
                        {
                            Swap(ref n[i], ref n[j]);
                        }
                    }
                }

                return n;
            }

    public void Swap(ref int i, ref int j)
            {
                int temp = 0;
                temp = i;
                i = j;
                j = temp;
            }
        }
}
// Divide and Conquer Merge Sort.

/*void Main()
{
	
}

// Define other methods and classes here
class  MergeSort
{
	
}*/
