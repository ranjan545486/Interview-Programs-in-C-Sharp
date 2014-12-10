<Query Kind="Program" />

// sum of all n natural numbers using recursion
void Main()
{
	int n = 3;
	var p = func(5);
	p.Dump();
	
	var c = func2(5);
	c.Dump();
}

public int func2(int n)
{
	if(n==1)
	return n;
	else{
	return (func2(n-1)+n);
	}
}

public int func(int n)
{
	while(n!=0)
	{
	  return (func(n-1)+n);
	
	}
	
	return n;
	
}

// Define other methods and classes here
