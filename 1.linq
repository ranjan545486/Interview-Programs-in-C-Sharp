<Query Kind="Program" />

void Main()
{
	var a = new List<int>();
	a.Add(1);
	a.Add(2);
	a.Add(3);
	int i = 3;
	SubsetOfSet s = new SubsetOfSet();
	var x = s.GetSubSet(a,i);
	x.Dump();
}

public class SubsetOfSet
{
	public List<List<int>> GetSubSet(List<int> set, int index)
	{
		List<List<int>> allsubset = null;
		if(set.Count == index)
		{
			allsubset = new List<List<int>>();
			allsubset.Add(new List<int>());
		}
		else
		{
			allsubset = GetSubSet(set,index+1);
			int item = set[index];
			var moreSubset = new List<List<int>>();
			foreach(var s in allsubset)
			{
				var newsubset = new List<int>();
				newsubset.Union(s);
				newsubset.Add(item);
				moreSubset.Add(newsubset);
			}
			allsubset.Union(moreSubset);
		}
		
		return allsubset;
	}
	
}

// Define other methods and classes here
