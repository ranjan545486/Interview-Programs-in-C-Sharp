<Query Kind="Program" />

void Main()
{
	int[] a = {2,5,6,8,10,2,2};
	int[] b = {2,5,5,8,10,5,6,3};
	Resolve(a,b);

}

public void Resolve(int[] a, int[] b)
{
   
		var d = new Dictionary<int,int>();
		for(int i=0;i<a.Length;i++)
		{
			if(!d.ContainsValue(a[i]))
			{
				d.Add(i,a[i]);
			}
		}
		
		for (int i = 0; i < b.Length; i++)
		{
			if(!d.ContainsValue(b[i]))
			{
				Console.WriteLine("No dups in both array");
				return;
			}
		}
		
		Console.WriteLine("Dups exist");
		
	
}
// Define other methods and classes here
