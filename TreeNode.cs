﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    public class TreeNode
    {
        public int Value;
        public TreeNode Left;
        public TreeNode Right;

        public TreeNode(int value)
        {
            Value = value;
            Left = null;
            Right = null;
        }
    }
}
