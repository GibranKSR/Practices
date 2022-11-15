using System;

namespace BinaryTree
{
    public class TreeNode
    {
        public string dir;
        private int data;

        public int Data
        {
            get { return data; }
        }

        private TreeNode rightNode;
        public TreeNode RightNode
        {
            get { return rightNode; }
            set { rightNode = value; }
        }

        private TreeNode leftNode;
        public TreeNode LeftNode
        {
            get { return leftNode; }
            set { leftNode = value; }
        }

        public TreeNode(int value)
        {
            data = value;
        }

        public TreeNode Find(int value)
        {
            TreeNode currentNode = this;

            while (currentNode != null)
            {
                if (value == currentNode.data)
                {
                    return currentNode;
                }
                else if (value > currentNode.data)
                {
                    currentNode = currentNode.rightNode;
                }
                else
                {
                    currentNode = currentNode.leftNode;
                }
            }
            return null;
        }

        public void Insert(int value)
        {
            if (value >= data)
            {
                if (rightNode == null)
                {
                    rightNode = new TreeNode(value);
                }
                else
                {
                    rightNode.Insert(value);
                }
            }
            else
            {
                if (leftNode == null)
                {
                    leftNode = new TreeNode(value);
                }
                else
                {
                    leftNode.Insert(value);
                }
            }
        }
        public void InOrderTraversal(List<String> IOT)
        {
            if (leftNode != null)
            {
                leftNode.InOrderTraversal(IOT);
            }

            IOT.Add(data.ToString());

            if (rightNode != null)
            {
                rightNode.InOrderTraversal(IOT);
            }
        }
        public void PreOrderTraversal(List<String> PT)
        {
           PT.Add(data.ToString());

            if (leftNode != null)
            {
               leftNode.PreOrderTraversal(PT);
            }

            if (rightNode != null)
            {
                rightNode.PreOrderTraversal(PT);
            }

        }
        public void PostorderTraversal(List<String> POT)
        {
            if (leftNode != null)
                leftNode.PostorderTraversal(POT);

            if (rightNode != null)
                rightNode.PostorderTraversal(POT);

            POT.Add(data.ToString());
        }
        public void PrintTree()
        {
            Console.Write(dir + data + "\n");

            if (leftNode != null)
            {
                leftNode.dir = "I";
                leftNode.PrintTree();
            }

            if (rightNode != null)
            {
                rightNode.dir = "D";
                rightNode.PrintTree();
            }

        }

        public int Height()
        {
            if (this.leftNode == null && this.rightNode == null)
            {
                return 1;
            }

            int left = 0;
            int right = 0;

            if (this.leftNode != null)
                left = this.leftNode.Height();
            if (this.rightNode != null)
                right = this.rightNode.Height();

            if (left > right)
            {
                return (left + 1);
            }
            else
            {
                return (right + 1);
            }

        }
    }
}