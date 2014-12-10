<Query Kind="Program" />

	public static int min(int x, int y)
	{
		return (x < y)? x : y;
	}
	public static void printOrder(string[] words, int n, int alpha)
	{
		// Create a graph with 'aplha' edges
		Graph g = new Graph(alpha);

		// Process all adjacent pairs of words and create a graph
		for (int i = 0; i < n - 1; i++)
		{
			// Take the current two words and find the first mismatching
			// character
			string word1 = words[i];
			string word2 = words[i + 1];
			for (int j = 0; j < min(word1.Length, word2.Length); j++)
			{
				// If we find a mismatching character, then add an edge
				// from character of word1 to that of word2
				if (word1[j] != word2[j])
				{
					g.addEdge(word1[j] - 'a', word2[j] - 'a');
					break;
				}
			}
		}

		// Print topological sort of the above created graph
		g.topologicalSort();
	}

	// Driver program to test above functions
	void Main()
	{
		string[] words = {"caa", "aaa", "aab"};
		printOrder(words, 3, 3);
		
	}


// Class to represent a graph
public class Graph
{
	private int V; // No. of vertices'

	// Pointer to an array containing adjacency listsList
	private LinkedList<int> adj;

	// A function used by topologicalSort

	public void topologicalSortUtil(int v, bool[] visited, Stack<int> Stack)
	{
		// Mark the current node as visited.
		visited[v] = true;
    
		// Recur for all the vertices adjacent to this vertex
		LinkedList<int>.Enumerator i;
		for (i = adj[v].begin(); i.MoveNext();)
		{
			if (!visited[i.Current])
			{
	//C++ TO C# CONVERTER TODO TASK: Iterators are only converted within the context of 'while' and 'for' loops:
				topologicalSortUtil(i, visited, Stack);
			}
		}
    
		// Push current vertex to stack which stores result
		Stack.Push(v);
	}

	public Graph(int V)
	{
		this.V = V;
		adj = new LinkedList<int>[V];
	}

	// function to add an edge to graph
	public void addEdge(int v, int w)
	{
		adj[v].push_back(w); // Add w to v’s list.
	}

	// prints a Topological Sort of the complete graph

	// The function to do Topological Sort. It uses recursive topologicalSortUtil()
	public void topologicalSort()
	{
		Stack<int> Stack = new Stack<int>();
		// Mark all the vertices as not visited
		bool[] visited = new bool[V];
		for (int i = 0; i < V; i++)
		{
			visited[i] = false;
		}

		// Call the recursive helper function to store Topological Sort
		// starting from all vertices one by one
		for (int i = 0; i < V; i++)
		{
			if (visited[i] == false)
			{
				topologicalSortUtil(i, visited, Stack);
			}
		}

		// Print contents of stack
		while (Stack.Count == 0 == false)
		{
			Console.Write((sbyte)('a' + Stack.Peek()));
			Console.Write(" ");
			Stack.Pop();
		}
	}
}