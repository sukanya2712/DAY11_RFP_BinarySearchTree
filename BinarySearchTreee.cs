using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    public class BinarySearchTreee
    {
        private TreeNode root;

        public BinarySearchTreee()
        {
            root = null;
        }

        public void Insert(int value)
        {
            TreeNode newNode = new TreeNode(value);

            if (root == null)
            {
                root = newNode;
                return;
            }

            TreeNode current = root;

            while (true)
            {
                if (value < current.Value)
                {
                    if (current.Left == null)
                    {
                        current.Left = newNode;
                        break;
                    }
                    else
                    {
                        current = current.Left;
                    }
                }
                else
                {
                    if (current.Right == null)
                    {
                        current.Right = newNode;
                        break;
                    }
                    else
                    {
                        current = current.Right;
                    }
                }
            }
        }

        //Inorder Traversal
        public void InorderTraversal()
        {
            if (root == null)
            {
                return;
            }

            Stack<TreeNode> stack = new Stack<TreeNode>();
            TreeNode current = root;

            while (current != null || stack.Count > 0)
            {
                while (current != null)
                {
                    stack.Push(current);
                    current = current.Left;
                }

                current = stack.Pop();
                Console.Write(current.Value + " ");

                current = current.Right;
            }
        }


    }
}
