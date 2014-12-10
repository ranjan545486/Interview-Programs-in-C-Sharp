<Query Kind="Program" />

void Main()
{
	var v = new Dictionary<string, List<string>>
	{
		{"a", new List<string> {"a","b"}},
		{"b", new List<string> {"b","c"}},
		{"c", new List<string> {"c","d"}},
		{"d", new List<string> {"c","e"}},		
		{"e", new List<string> {"c","e"}}		
	};
	
	foreach (var element in v.TopologicalSort())
	{
		Console.WriteLine(element);
	}
}

	public static class GraphExtensions
	{
		public static IEnumerable<string> TopologicalSort(this Dictionary<string, List<string>> graph)
		{
			var result = new List<string>();
			Action<string> dfs = null;
			
			dfs= item =>
			{
				List<string> deps;
				if(!graph.TryGetValue(item, out deps))
				{
					// this item was already visited.
					return;
				}
				
				// mark as visited by removing it from the dictionary.
				graph.Remove(item);			
				foreach (var dep in deps)
				{
					dfs(dep);
				}
				
				// add item to the list after all its dependencies are processed.
				result.Add(item);
			};
			
			foreach(var item in graph.Keys.ToList())
			{
				dfs(item);
			}
			
			return result;
		}
	}
	

// Define other methods and classes here
