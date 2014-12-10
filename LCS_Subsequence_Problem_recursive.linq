<Query Kind="Program">
  <Connection>
    <ID>989f3bd4-0cc5-4efe-b835-6ef52975ce9c</ID>
    <Persist>true</Persist>
    <Driver>AstoriaAuto</Driver>
    <Server>http://mfx/brhdataservice/</Server>
  </Connection>
</Query>

void Main()
{
	string word1 = "thisisatest";
            string word2 = "testing123testing";
	Console.WriteLine(LCSString(word1,word2));
	
}

public static string LCSString(string a, string b)
{
	string asub= a.Substring(0,(a.Length - 1<0)?0:a.Length-1);
	string bsub= b.Substring(0,(b.Length - 1<0)?0:b.Length-1);
	if(asub.Length==0 ||bsub.Length==0)
	{
	 return "";
	}
	else if(a[a.Length-1] == b[b.Length-1])
	{
		return LCSString(asub,bsub) + a[a.Length-1];		
	}
	else
	{
		string x = LCSString(a,bsub);
		string y = LCSString(b,asub);
		return (x.Length>y.Length)?x:y;
	}
	
}

// Define other methods and classes here
