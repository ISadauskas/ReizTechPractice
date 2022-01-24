using System;

public class Node
{
	public int data;
	public Node left, middle, right;

	public Node(int item)
	{
		data = item;
		left = right = middle = null;
	}
}

public class Tree
{
	Node root;

	int maxDepth(Node node)
	{
		if (node == null)
			return -1;
		else
		{
			int lDepth = maxDepth(node.left);
			int rDepth = maxDepth(node.right);
			int mDepth = maxDepth(node.middle);

			if (lDepth > mDepth && lDepth > rDepth)
				return lDepth + 1;
			else if (rDepth > mDepth && rDepth > lDepth)
				return rDepth + 1;
			else
				return mDepth + 1;		
		}
	}

	public static void Main(String[] args)
	{
		Tree tree = new Tree();

		tree.root = new Node(1);
		tree.root.left = new Node(2);
		tree.root.right = new Node(3);
		tree.root.left.left = new Node(4);
		tree.root.left.right = new Node(5);
		tree.root.left.middle = new Node(6);
		tree.root.left.middle.middle = new Node(7);
		tree.root.left.middle.middle.middle = new Node(8);
		tree.root.left.middle.middle.middle.middle = new Node(9);

		int depth = 1 + tree.maxDepth(tree.root);

		Console.WriteLine("Height of tree is : " + depth);
	}
}

