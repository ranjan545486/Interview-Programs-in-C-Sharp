<Query Kind="Program" />

void Main()
{
	var str = "I ..... wallaw , ! I";
	var x= str;
	Regex r = new Regex(@"[^A-Za-z0-9]+");
	x = r.Replace(str,"");
	x.Dump();
	var c = IsPalindrome(str);
	c.Dump();
	
}

public static bool IsPalindrome(string str)
{
    string temp = str.ToLower().Trim();
	for(int i=0,j=str.Length-1;i<str.Length && j>i;i++,j--)
	{
		while(!Char.IsLetter(temp[i]))
		{
		 i++;		 
		}
		while(!Char.IsLetter(temp[j]))
		{
		 j--;
		}
		
		if(temp[i]!=temp[j])
		{
		  return false;
		}	
		
	}
	
	return true;
}

// Define other methods and classes here