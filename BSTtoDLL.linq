<Query Kind="Program" />

void Main()
{
	
}

public class Node1
{
	public int data;
	public Node1 Left;
	public Node1 Right;
}

public int bst2dll(Node1 root)
{
	Queue<Node1> q = new Queue<Node1>();
	q.Enqueue(root);
	Node1 last = null;
	Node1 node = null;
	
	while(q.Count>0)
	{
		node = q.Dequeue();
		if(node.Left!=null)
		q.Enqueue(node.Left);
		if(node.Right!=null)
		q.Enqueue(node.Right);
		node.Left = last;
		node.Right = q.Peek();
		last = node;
	}
}

// Binary Tree to Doubly Linked List
