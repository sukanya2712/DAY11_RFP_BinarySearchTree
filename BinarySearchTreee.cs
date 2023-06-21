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


        //preorder traversal
        public void PreorderTraversal()
        {
            if (root == null)
            {
                return;
            }

            Stack<TreeNode> stack = new Stack<TreeNode>();
            stack.Push(root);

            while (stack.Count > 0)
            {
                TreeNode current = stack.Pop();
                Console.Write(current.Value + " ");

                if (current.Right != null)
                {
                    stack.Push(current.Right);
                }

                if (current.Left != null)
                {
                    stack.Push(current.Left);
                }
            }
        }

        //Postorder Traversal
        public void PostorderTraversal()
        {
            if (root == null)
            {
                return;
            }

            Stack<TreeNode> stack1 = new Stack<TreeNode>();
            Stack<TreeNode> stack2 = new Stack<TreeNode>();
            stack1.Push(root);

            while (stack1.Count > 0)
            {
                TreeNode current = stack1.Pop();
                stack2.Push(current);

                if (current.Left != null)
                {
                    stack1.Push(current.Left);
                }

                if (current.Right != null)
                {
                    stack1.Push(current.Right);
                }
            }

            while (stack2.Count > 0)
            {
                TreeNode current = stack2.Pop();
                Console.Write(current.Value + " ");
            }
        }


    }
}
