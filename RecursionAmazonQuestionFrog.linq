<Query Kind="Program" />

void Main()
{
	//given an input array of integers where each integer represent the maximum amount of jump a frog can take.
	//Frog has to reach the end of the array in minimum number of jumps.
	//Example:[1 5 4 6 9 3 0 0 1 3] answer is 3 for this. 
	//[2 8 3 6 9 3 0 0 1 3] answer is 2 for this
	int[] input = new []{2, 8, 3, 6, 9, 3, 0, 0, 1, 3};
	Console.WriteLine(FindMinimumJumps(input,0,0));
}

// Define other methods and classes here
int FindMinimumJumps(int[] input, int currentPosition, int numberOfJumps)
{
	int lastPosition = input.Length - 1;
	if(currentPosition > lastPosition)
		return int.MaxValue;
	else if(currentPosition == lastPosition)
		return numberOfJumps;
	
	int maxJump = input[currentPosition];	
	if(maxJump == 0)
		return int.MaxValue;
	
	int minHops = int.MaxValue;
	for(int i = 1;i<=maxJump;i++)
	{
		minHops = Math.Min(minHops, FindMinimumJumps(input, currentPosition + i,numberOfJumps+1));
	}
	
	return minHops;
}