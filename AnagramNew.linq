<Query Kind="Program" />

void Main()
{
	var src = GetAnagram("cat");
	src.Dump();
}


public static List<string> GetAnagram(string src)
{
	if(src == null)
	return null;
	
	var permutation = new List<string>();	
	if(src.Length == 0)
	{
		permutation.Add("");
		return permutation;
	}
	
	char first = src[0];
	string remainder = src.Substring(1);
	var words = GetAnagram(remainder);
	foreach (var word in words)
	{
		for (int i = 0; i <= word.Length; i++)
		{
			var temp = InsertCharactersAt(word,first,i);
			permutation.Add(temp);
		}
	}
	
	return permutation;
}

private static string InsertCharactersAt(string word, char first, int i)
{
	var end = word.Substring(0,i);
	var start = word.Substring(i);
	return start + first + end;
}