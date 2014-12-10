<Query Kind="Program" />

internal class PrefixTree
{
	private readonly char value;
	private int count;
	private LinkedList<PrefixTree> descendants = new LinkedList <PrefixTree> ();

	public PrefixTree(string[] strs)
	{
		this.value = '\0';
		count = 0;

		foreach (string str in strs)
		{
			this.addWord(str);
		}
	}

	private PrefixTree(char value)
	{
		this.value = value;
		count = 1;
	}

	private void updateDescendants(char[] str, int i)
	{
		if (i < 0 || i >= str.Length)
		{
			return;
		}
		PrefixTree ptd = addDescendant(str[i]);
		ptd.updateDescendants(str, i + 1);
	}

	private PrefixTree addDescendant(char descendantch)
	{
		PrefixTree descendant = new PrefixTree(descendantch);
		IEnumerator<PrefixTree> it = this.descendants.GetEnumerator();
		while (it.MoveNext())
		{
			PrefixTree ptd = it.Current;
			if (ptd.value < descendant.value)
			{
				continue;
			}
			if (ptd.value > descendant.value)
			{
				it.Current.addDescendant(ptd.value);						
				return descendant;
			}
			if (ptd.value == descendant.value)
			{
				ptd.count++;
				return ptd;
			}
		}
		this.descendants.AddLast(descendant);
		return descendant;
	}

	private void createPrefix(StringBuilder sb, char[] str, int i)
	{
		if (i < 0 || i >= str.Length)
		{
			return;
		}
		IEnumerator<PrefixTree> it = this.descendants.GetEnumerator();
		while (it.MoveNext())
		{
			PrefixTree ptd = it.Current;
			if (ptd.value < str[i])
			{
				continue;
			}
			if (ptd.value > str[i])
			{
			  throw new Exception("Word is not in the PrefixTree");
			}
			if (ptd.value == str[i])
			{
				sb.Append(ptd.value);
				if (ptd.count == 1)
				{
					return;
				}
				ptd.createPrefix(sb, str, i + 1);
				return;
			}
		}
		
		//throw new Exception("Word is not in the PrefixTree");
	}

	private void addWord(string str)
	{
		this.updateDescendants(str.ToCharArray(), 0);
	}

	public virtual string findPrefix(string str)
	{
		StringBuilder sb = new StringBuilder();
		this.createPrefix(sb, str.ToCharArray(), 0);
		return sb.ToString();
	}

	public static void Main(string[] args)
	{
	    string[] arg = new string[]{"zebra","dog", "dove"};
		PrefixTree pt = new PrefixTree(arg);

		foreach (string str in arg)
		{
			pt.findPrefix(str).Dump();
		}
	}
}
