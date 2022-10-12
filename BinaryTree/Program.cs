using System;
using System.Collections.Generic;

namespace BinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Binary Search Tree\n");

            BinaryTree binaryTree = new BinaryTree();

            binaryTree.Insert(75);
            binaryTree.Insert(57);
            binaryTree.Insert(90);
            binaryTree.Insert(32);
            binaryTree.Insert(7);
            binaryTree.Insert(44);
            binaryTree.Insert(60);
            binaryTree.Insert(86);
            binaryTree.Insert(93);
            binaryTree.Insert(99);
            binaryTree.Insert(100);
            binaryTree.Insert(101);
            binaryTree.Insert(98);

            Console.WriteLine("Tree");
            binaryTree.PrintTree();

            Console.WriteLine("\nIn Order Traversal (Left->Root->Right)");
            binaryTree.InOrderTraversal();
            Console.WriteLine("\nPre Order Traversal (Root->Left->Right)");
            binaryTree.PreorderTraversal();
            Console.WriteLine("\nPost Order Traversal (Left->Right->Root)");
            binaryTree.PostorderTraversal();

            Console.WriteLine("\nFind 99");
            var node = binaryTree.Find(99);
            Console.WriteLine(node.Data);
            Console.WriteLine("Delete Node (100)");
            binaryTree.Remove(90);

            Console.WriteLine("In Order Traversal (Left->Root->Right)");
            binaryTree.InOrderTraversal();
            Console.WriteLine("\nPre Order Traversal (Root->Left->Right)");
            binaryTree.PreorderTraversal();
            Console.WriteLine("\nPost Order Traversal (Left->Right->Root)");
            binaryTree.PostorderTraversal();

            Console.WriteLine("\nGet the height of the tree");
            Console.WriteLine(binaryTree.Height());
        
        }

        public static int getHeight(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }

            return Math.Max(getHeight(root.LeftNode), getHeight(root.RightNode)) + 1;
        }
    }
}