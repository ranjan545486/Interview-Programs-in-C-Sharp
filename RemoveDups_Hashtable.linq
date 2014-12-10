<Query Kind="Program" />

void Main()
{
	char[] a = new char[] {'a','b','c','a','d'};
	RemoveDuplicates(a);
}

// remove duplicates from the character array

public void RemoveDuplicates(char[] a)
{
	Hashtable h = new Hashtable();
	for (int i = 0; i < a.Length; i++)
	{
		if(!h.ContainsValue(a[i]))
		{
			h.Add(i,a[i]);
		}
	}
	
	foreach (var element in h.Values)
	{
		element.Dump();
	}
}