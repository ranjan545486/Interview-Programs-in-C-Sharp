<Query Kind="Program" />

void Main()
{
	var c = Power(2,3);
	c.Dump();
}

// Calculate the Power(x,N) using divide and conquer


public int Power(int x, int n)
{
	int temp = 1;
	if(n==0) return 1;
	temp = Power(x,n/2);
	if(n%2==0)
	{
		return (temp*temp);
	}
	else
	{
		return (x*temp*temp);
	}
}

