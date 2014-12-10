<Query Kind="Program" />

void Main()
{
	var c = "abcde";
	var x = ReverseStringRecursive(c);
	x.Dump();
}

public static string ReverseStringRecursive(string str)
{
	if(str==null)
	return string.Empty;
	if(str.Length==0)
	return str;
	
	return (ReverseStringRecursive(str.Substring(1))+str[0]);
}

// Define other methods and classes here