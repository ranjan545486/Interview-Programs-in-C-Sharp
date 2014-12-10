<Query Kind="Program" />

void Main()
{
	Tree node = new Tree(6);
	node.left= new Tree(5);
	node.right = new Tree(2);
	node.printNode(node);
	//var x = node.Transform(node);
	//var x = node.transform2(node);
	//x.Dump();
	node.TransformUsingStack(node);
	
}



public class Tree
{
	public int data;
	public Tree left;
	public Tree right;
	
	public Tree(int data)
	{
		this.data = data;
		this.left = null;
		this.right = null;
	}
	
	public int Data
	{
		get {return data;}
		set{this.data = value;}
	}
	
	public void printNode(Tree node)
	{
		if(node!=null)
		{
			Console.WriteLine(node.data);
			if(node.left!=null)			
			printNode(node.left);			
			if(node.right!=null)
			printNode(node.right);
		}	
	}
	
	public void TransformUsingStack(Tree node)
	{
		Stack<Tree> s;
		Tree previous = null;
		bool init = true;
		
		s.Push(node.data);
		
		while(s.Any())
		{
			Tree n = s.Peek();
			Console.WriteLine(s.Pop());
			if(node.right!=null)
			{
			 s.Push(n.right);
			}
			if(node.left!=null)
			{
			 s.Push(n.left);
			}
			
			if(init)
			{
				init = false;
			}
		}
	}
	
	public Tree Transform(Tree node)
	{
		if(node== null)
		{return null;}
		
		if(node.left ==null)
		return node;
		
		Tree leftsubtree = Transform(node.left);
		Tree rightsubtree = Transform(node.right);
		node.right = leftsubtree;
		while(leftsubtree.right!=null)
		{
			leftsubtree = leftsubtree.right;
		}
		
		leftsubtree.right = rightsubtree;
		return node;
	}
	
		
public Tree transform2(Tree root) {
		Tree right = root.right;
		Tree rightMost = root;

		if (root.left != null) {
			rightMost = transform2(root.left);
			root.right = root.left;
			root.left = null;
		}

		if (right == null) {
			return rightMost;
		}

		rightMost.right = right;
		rightMost = transform2(right);
		return rightMost;
	}			

	
}

// Define other methods and classes here
