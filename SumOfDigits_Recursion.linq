<Query Kind="Program" />

void Main()
{
	var x = SumOfDigits(1234567);
	x.Dump();
}

// Sum Of Digits using a number using recursion SumOfDigits(123) = 6

public int SumOfDigits(int x)
{
	if(x == 0) return x;
	else
	return (x%10) + SumOfDigits(x/10);
}