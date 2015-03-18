using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    class Program
    {
        public static int cnt = 0;
        static void Main(string[] args)
        {
            //Stack
           // StackDS<int> mystack = new StackDS<int>();
           // mystack.push(5);
           // mystack.push(4);
           // mystack.push(3);
           // mystack.push(2);
           // mystack.push(1);
           //while(mystack.count > 0)
           // {
           // //    Console.WriteLine(mystack.pop() + " \n");
        
           // }

            //BinarySearchTree

           //BinaryTree<int> bt = new BinaryTree<int>();
           //bt.Root = new BinaryTreeNode<int>(13);
           //bt.Root.left = new BinaryTreeNode<int>(10, new BinaryTreeNode<int>(2), new BinaryTreeNode<int>(12));
           //bt.Root.right = new BinaryTreeNode<int>(25, new BinaryTreeNode<int>(20), new BinaryTreeNode<int>(31, new BinaryTreeNode<int>(29), null));
           //Console.WriteLine("Preorder Traverse\n");
           // preorder(bt.Root);
           //Console.WriteLine("inorder Traverse\n");
           // inorder(bt.Root);
           // Console.WriteLine("Postorder Traverse\n");
           // postorder(bt.Root);
           // Console.WriteLine("No Of Nodes" + cnt);
           // Console.ReadLine();


            BinarySearchTree<int> tree = new BinarySearchTree<int>();
            tree.AddNode(6);
            tree.AddNode(4);
            tree.AddNode(2);
            tree.AddNode(1);
            tree.AddNode(3);
            tree.AddNode(5);
            tree.AddNode(9);
            tree.AddNode(10);
            tree.AddNode(8);
            tree.AddNode(7);

            tree.InOrderTraversal(tree.Root);
            Console.WriteLine("---------------------");
            tree.PreOrderTraversal(tree.Root);
            Console.WriteLine("---------------------");
            tree.PostOrderTraversal(tree.Root);
            Console.WriteLine("---------------------");
            BinaryNode<int> parent;
            BinaryNode<int> target = tree.FindWithParent(6, out parent);

            tree.RemoveNode(6);

            Console.WriteLine("---------------------");
            tree.PreOrderTraversal(tree.Root);
            Console.ReadLine();
        }


    }

    
}
