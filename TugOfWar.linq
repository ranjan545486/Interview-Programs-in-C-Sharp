<Query Kind="Program" />

void Main()
{
	int[] a = new int[]{23, 45, -34, 12, 0, 98, -99, 4, 189, -1, 4};
	int n = a.Length;
	TugOfWar(a,n);
	n.Dump();
}

public void TugOfWar(int[] arr, int n)
{
	bool[] curr_elements = new bool[n];
	bool[] solution = new bool[n];
	int min_diff = 0;
	int sum = 0 ;
	for (int i = 0; i < n; i++)
	{
		sum +=arr[i];
		curr_elements[i] = solution[i] = false;
	}
	
	// Find the solution using recursive function TOWUtil()
    TOWUtil(arr, n, curr_elements, 0, solution, min_diff, sum, 0, 0);
 
    // Print the solution
    Console.WriteLine("The first subset is: ");
    for (int i=0; i<n; i++)
    {
        if (solution[i] == true)
             Console.WriteLine(arr[i] + " ");
    }
     Console.WriteLine("\nThe second subset is: ");
    for (int i=0; i<n; i++)
    {
        if (solution[i] == false)
             Console.WriteLine(arr[i] + " ");
    }

}

public void TOWUtil(int[] arr,int n,bool[] curr_elements, int no_of_selected_elements,bool[] soln, int min_diff,int sum, int curr_sum,int curr_position)
{
	if(curr_position == n)
	{
		return;
	}
	
	if((n/2- no_of_selected_elements)> (n-curr_position))
	{
		return;
	}
	
	TOWUtil(arr,n,curr_elements,no_of_selected_elements,soln,min_diff,sum,curr_sum,curr_position+1);
	no_of_selected_elements++;
	curr_sum = curr_sum+arr[curr_position];
	curr_elements[curr_position] = true;
	 // checks if a solution is formed
    if (no_of_selected_elements == n/2)
    {
        // checks if the solution formed is better than the best solution so far
        if ((sum/2 - curr_sum) < min_diff)
        {
            min_diff = sum/2 - curr_sum;
            for (int i = 0; i<n; i++)
                soln[i] = curr_elements[i];
        }
    }
    else
    {
        // consider the cases where current element is included in the solution
        TOWUtil(arr, n, curr_elements, no_of_selected_elements, soln, min_diff, sum, curr_sum, curr_position+1);
    }
 
    // removes current element before returning to the caller of this function
    curr_elements[curr_position] = false;

}

// Define other methods and classes here
