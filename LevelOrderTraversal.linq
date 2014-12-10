<Query Kind="Program" />

void Main()
{
	/*
Level Order Binary Tree Traversal
	
	
	*/
	
	BinaryTree v = new BinaryTree(2);
	v.Left = new BinaryTree(3);
	v.Right = new BinaryTree(4);
	v.Left.Left= new BinaryTree(5);
	v.Left.Right = new BinaryTree(6);
	v.Right.Left = new BinaryTree(7);
	v.Right.Right = new BinaryTree(8);
	var x = FindLevelLinkList(v);
	x.Dump();
}

public void DisplayBF()
 {
 // breadth-first using a queue
 Queue<BinaryTree> q = new Queue<BinaryTree>();
 q.Enqueue(this.root);
 while (q.Count > 0)
 {
 TreeNode n = q.Dequeue();
 Console.WriteLine(n.data);
 if (n.left != null)
 q.Enqueue(n.left);
 if (n.right != null)
 q.Enqueue(n.right);
 }
 }

public void DisplayDF()
 {
 // depth-first using a stack
 Stack<BinaryTree> s = new Stack<BinaryTree>();
 s.Push(this.root);
 while (s.Count > 0)
 {
 TreeNode n = s.Pop();
 Console.WriteLine(n.data);
 if (n.left != null)
 s.Push(n.left);
 if (n.right != null)
 s.Push(n.right);
 }
 }
