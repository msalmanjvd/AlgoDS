using System;

namespace DataStructures
{
	public class BinarySearchTree<T> 
	{
		public BinaryNode<int> Root;
		public void AddNode(int value)
		{
			if (Root == null)
			{
				Root = new BinaryNode<int>(value);
			}
			else
			AddNodeToTree(value , Root);
		}

		private void AddNodeToTree(int value, BinaryNode<int> node)
		{
			if (node == null)
			{
				return;
			}

			else
			{
				if (value > node.value && node.right == null)
				{
					node.right = new BinaryNode<int>(value);
				}
				else if (value <= node.value && node.left == null)
				{
					node.left = new BinaryNode<int>(value);
				}

				else if (value > node.value)
				{
					AddNodeToTree(value, node.right);
				}

				else if(value <= node.value)
				{
					AddNodeToTree(value, node.left);
				}
			}
		}

		public bool IsExist(int value)
		{

			if (Root == null)
			{
				return false;
			}

			else
			return FindNode(value, Root);
		}

		public BinaryNode<int> FindWithParent(int value, out BinaryNode<int> parent)
		{
			
			Tuple<BinaryNode<int> , BinaryNode<int>>  res =  FindNode(value, Root, null);
			parent = res.Item2;
			return res.Item1;
		}

		private bool FindNode(int value, BinaryNode<int> node)
		{
			if (node != null)
			{ 
				if (value == node.value)
				{
					return true;
				}

				else if(value > node.value)
				{  
					FindNode(value, node.right);
				}
				else
				{
					FindNode(value, node.left);
				}
			}
			   return false;
			
		}

		public bool RemoveNode(int value){
			if (value < 0)
			{
				return false;
			}

			bool found = false;
			bool isRoot = false;
			bool isRightChild = false ;
			BinaryNode<int> parent;
			BinaryNode<int> target = FindWithParent(value, out  parent);
			BinaryNode<int> newNode = null;
			BinaryNode<int> leftMostChildParent = null;

			if (parent == null)
			{
				isRoot = true;
			}
			else
				isRightChild = target.value > parent.value;

			//if it has no right child
			if (target.right == null)
			{
				//and it hasn't left too
				if (target.left == null)
				{
					if (isRoot)
					{
						Root = null;
					}
					else
					{
						if (isRightChild)
						{
							parent.right = null;
						}
						else
						{
							parent.left = null;
						}
					}
					found = true;

				}

				//the target has a left child only (no right of course)
				else
				{
					if (isRoot)   
						Root = target.left;
					
					else
					{
						if (isRightChild)
							parent.right = target.left;

						else
							target.right.left = target.left;
					}
					found = true;

				}


			}
			//has a right child
			//it can have left child of course but our focus is on the right child
			else
			{
				//that right child has a left child
				if (target.right.left != null)
				{
					BinaryNode<int> leftMostChild = target.right;

					//get most left child
					while (leftMostChild.left.left != null)
					{
						leftMostChild = leftMostChild.left;
						
					}

					//to be able to get the parent of the left most child to remove it is pointer to our new target (which is its left child)
					leftMostChildParent = leftMostChild;
					leftMostChild = leftMostChild.left;
					leftMostChildParent.left = null;
					if (isRoot)
					{
						Root = leftMostChild;
						Root.left = target.left;
						Root.right = target.right;
					}
					else
					{

						if (isRightChild)
						{
							parent.right = leftMostChild;
							parent.right.right = target.right;
							parent.right.left = target.left;

						}

						else
						{

							parent.left = leftMostChild;
							parent.left.right = target.right;
							parent.left.left = target.left;


						}
					}
					found =  true;
				}

				//that right child doesn't have a left child
				else
				{

					if (isRoot)
					{
						Root = target.right;
						Root.left = target.left;
					}
					else
					{
						if (isRightChild)
						{
							parent.right = target.right;
							parent.right.left = target.left;

						}
						else
						{
							//replace the node with its right child
							parent.left = target.right;

							//connects the node with any left child it was connected to before (parent.left is our new node)
							parent.left.left = target.left;


						}
					}

					found = true;
				}

			}

			return found;
		}

		private Tuple<BinaryNode<int> , BinaryNode<int>> FindNode(int value, BinaryNode<int> node, BinaryNode<int> parent)
		{
			BinaryNode<int> target = null;

			if (node != null)
			{
				if (value == node.value)
				{

					return new Tuple<BinaryNode<int>, BinaryNode<int>>(node, parent);
				}

				else if (value > node.value)
				{

					return FindNode(value, node.right, node);

				}
				else
				{

					return FindNode(value, node.left, node);
				}
			}

			else
			return null;

		}

		public void InOrderTraversal(BinaryNode<int> node)
		{

			if (node == null)
			{
				return;
			}

			InOrderTraversal(node.left);
			Console.WriteLine(node.value);
			InOrderTraversal(node.right);

		}

		public void PreOrderTraversal(BinaryNode<int> node)
		{
			if (node == null)
			{
				return;
			}

			Console.WriteLine(node.value);
			PreOrderTraversal(node.left);
			PreOrderTraversal(node.right);
		}

		public void PostOrderTraversal(BinaryNode<int> node)
		{
			if (node == null)
			{
				return;
			}

			PostOrderTraversal(node.left);
			PostOrderTraversal(node.right);
			Console.WriteLine(node.value);
		}

	}
}
