<Query Kind="Program" />

void Main()
{
	BinaryTree v = new BinaryTree(2);
	v.Left = new BinaryTree(3);
	//v.Right = new BinaryTree(4);
	v.Left.Left= new BinaryTree(5);
	//v.Left.Right = new BinaryTree(6);
	//v.Right.Left = new BinaryTree(7);
	//v.Right.Right = new BinaryTree(8);
	var x = IsBalanced(v);
	x.Dump();
}

public int HeightOfBinaryTree(BinaryTree root)
{
	int leftheight,rightheight;
	 if(root == null)
	 return 0;	 
	 else
	 {
	 	leftheight = HeightOfBinaryTree(root.Left);
		rightheight = HeightOfBinaryTree(root.Right);
		return Math.Max(leftheight,rightheight)+1;
	 }
}

public bool IsBalanced(BinaryTree root)
{
	if(root==null)
	{
		return true;
	}
	
	int heightdiff = HeightOfBinaryTree(root.Left) - HeightOfBinaryTree(root.Right);
	if(Math.Abs(heightdiff)>1)
	{
		return false;
	}
	else
	{
		return IsBalanced(root.Left) && IsBalanced(root.Right);
	}
}

// Define other methods and classes here