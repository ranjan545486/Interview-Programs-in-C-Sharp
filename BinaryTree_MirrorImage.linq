<Query Kind="Program" />

void Main()
{
	
}

// Define other methods and classes here

bool mirrorEquals(BinaryTree left, BinaryTree right)
{
  if (left == null || right == null)
  {
	  return false;
  }
  return left.data == right.data && mirrorEquals(left.Left, right.Right) && mirrorEquals(left.Right, right.Left);
}

private bool isMirror(BinaryTreeNode a, BinaryTreeNode b)
{
	return (a != null && b != null) ? (a.m_nValue == b.m_nValue && isMirror(a.m_pLeft, b.m_pRight) && isMirror(a.m_pRight, b.m_pLeft)) : (a == b);
}
private bool isMirrorItselfRecursively(BinaryTreeNode root)
{
	if (root == null)
	{
		return true;
	}

	return isMirror(root.m_pLeft, root.m_pRight);
}
