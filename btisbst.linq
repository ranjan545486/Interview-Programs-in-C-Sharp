<Query Kind="Program" />

void Main()
{
	boolean isBST(TreeNode node,int min,int max)
		{
		
			if(node==null)
				return true;
			
			if(node.leftchild==null && node.rightchild==null)
				return true;
			
			else if(node.value>min&&node.value<max)
					return(isBST(node.leftchild, min, node.value)&&
					isBST(node.rightchild,node.value,max));
			else 
				return false;
			
		}
}

// Define other methods and classes here