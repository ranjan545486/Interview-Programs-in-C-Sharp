<Query Kind="Program" />

/*
n a certain language which has same alphabets as in english language (ie. a-z), but the order of the alphabets is different (for eg 's' is the first character, 'g' is second, and likewise). Given a dictionary of this new language (which has words arranged according to new alphabetical order), FInd out the order of alphabets in this language.

Solution
You can create a directed graph where vertices represent the characters in the language and the edges represent the order relationship, i.e., if there is an edge Eij, then character Vi comes before character Vj in the alphabet. 
You need to process two consecutive words in the dictionary at a time to determine the precedence relationship of the characters, so it will take O(N * M) time to create the graph, where N is the number of words and M is the length of the words. 
Then use topological sorting to get characters in the correct order in O(|V| + |E|) time

Example for Alphabet C, A, B:
Imagine this is your dictionary below.
1. C
2. CAC
3. CB
4. BCC
5. BA

These are the steps based on the example above.
1. Compare line 1 and line 2. Create vertices C and A
2. Compare line 2 and 3. Create vertex B. Create Edge E = A->B, meaning A comes before B
3. Compare line 3 and 4. Add edge C->B meaning C comes before B
4. Compare line 4 and line 5: Add edge C->A

This yields to a DAG below.
C->B
C->A
A->B

C->A->B
| ^
|---------|

and the topological sort will give you:
C,B,A

As you can see, you cannot determine the correct order of the alphabet, if there is a directed cycle in the graph. So the dictionary given must generate a DAG to find a solution.
*/
	internal IDictionary<char?, Node> map = new Dictionary<char?, Node>();
	internal Node start = null;
	internal class Node
	{
		internal char c;
		internal Node next;
		internal Node(char c)
		{
			this.c = c;
		}
		public override int GetHashCode()
		{
			return c;
		}
		public override bool Equals(object obj)
		{
			return c == ((Node)obj).c;
		}
	}

	private void print()
	{
		Console.WriteLine();
		Node temp = start;
		while (temp != null)
		{
			Console.Write(temp.c + " -> ");
			temp = temp.next;
		}
	}
	public virtual void findOrder(string[] input)
{
		int max = int.MinValue;
		for (int i = 0 ; i < input.Length ; i++)
		{
			if (input[i].Length > max)
			{
				max = input[i].Length;
			}
		}
		int p = 1;
		while (p <= max)
		{
			for (int j = 0 ; j < input.Length - 1; j++)
			{
				if (input[j].Length < p || input[j + 1].Length < p)
				{
					continue;
				}
				string str1 = input[j].Substring(0, p);
				string str2 = input[j + 1].Substring(0, p);
				char c1 = str1[p - 1];
				char c2 = str2[p - 1];
				if (!alreadyPresent(c1, c2))
				{
					insert(c1, c2);
				}

			}
			print();
			p++;
		}
		print();
}
	private void insert(char c1, char c2)
	{
		if (start == null)
		{
			start = new Node(c1);
			start.next = new Node(c2);
			map.Add(c1, start);
			map.Add(c2, start.next);
		}
		else
		{
			if (map.ContainsKey(c1))
			{
				Node node = map[c1];
				Node temp = new Node(c2);
				temp.next = node.next;
				node.next = temp;
				map.Add(c2, temp);
			}
			else
			{
				Node temp = start;
				while (temp.next != null)
				{
					temp = temp.next;
				}
				temp.next = new Node(c1);
				map.Add(c1, temp.next);
				temp.next.next = new Node(c2);
				map.Add(c2, temp.next.next);
			}

		}
	}


	private bool alreadyPresent(char c1, char c2)
	{
		return map.ContainsKey(c1) && map.ContainsKey(c2);
	}

	void Main(string[] args)
	{
		string[] str = new string[] {"uyy", "yuzx", "yuzy", "zyu", "zyx"};
		findOrder(str);
	}



// Define other methods and classes here
