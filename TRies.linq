<Query Kind="Program" />

void Main()
{
	
}

// TRies

public class TrieNode
{
	public char data;
	public int isendofstring;
	public TrieNode[] child;
}

class Trie
{
   public TrieNode subNode(TrieNode root, char ch)
   {
   	if(root.child!=null)
	{
		for (int i = 0; i < 26; i++)
		{
			if(root.child[i].data==ch)
			{
				return root;
			}
		}
	}
   }
}
