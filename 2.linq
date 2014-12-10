<Query Kind="Program" />

void Main()
{
	var tree = new BinaryTree(2);
	tree.Left = new BinaryTree(3);
	tree.Right = new BinaryTree(4);
	var x = PreOrder(tree);
	x.Dump();
	
}

public BinaryTree PreOrder(BinaryTree root)
{
	if(root== null)
	return null;
	
	Console.Write(root);
	PreOrder(root.Left);
	PreOrder(root.Right);
	return root;
}



// Define other methods and classes here
