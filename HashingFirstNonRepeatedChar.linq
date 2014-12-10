<Query Kind="Program" />

void Main()
{
  int[] i = new int[]{140,41,67,382,2,90};
  int[] p = new int[i.Length];
  for(int j = 0; j<i.Length;j++)
  {
	//char[] c = new char[i.Length];
	p[j] = GetIntToArray(i[j]);
	
  }
  
  for(int j=0;j<p.Length;j++)
  {
  	if(j+1<p.Length && p[j] ==p[j+1])
	{
	    i[j+1].Dump();
		p[j+1].Dump();
	}
  }
  
  
 /* char[] h = new char[]{'a','b','z','d','d','a','b'};
  HashString hs = new HashString();
  char t = hs.FirstNonRepeatedCharUsingHash(h);
  t.Dump();*/
}


public int GetIntToArray(int num)
{
  int i=0;
  while(num>0)
  {
  	i= i+(num%10);
	num = num/10;	
  }
  
  return i;
}

/*public int[] GetIntToArray(int num)
{
  List<int> listOfInts = new List<int>();
  while(num>0)
  {
  	listOfInts.Add(num%10);
	num = num/10;	
  }
  
  listOfInts.Reverse();
  return listOfInts.ToArray();
}*/

// Find the first non repeated character in the given string
public class HashString
{
	public char FirstNonRepeatedCharUsingHash(char[] input)
	{
		int i;
		int len = input.Length;
		int[] count = new int[256];
		for(i=0;i<len;i++)
		{
			count[i] = 0;
		}
		
		for(i=0;i<len;i++)
		{
			count[input[i]]++;
		}
		
		for(i=0;i<len;i++)
		{
			if(count[input[i]] ==1)
			{
			 return input[i];
			}
		}
		
		return '0';
		
	}
}
