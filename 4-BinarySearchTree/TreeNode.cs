using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_BinarySearchTree
{
    internal class TreeNode<TNode> : IComparable<TNode> where TNode : IComparable<TNode>
    {
        public TreeNode<TNode> Left { get; set; }
        public TreeNode<TNode> Right { get; set; }
        public TNode Value { get; private set; }
        public TreeNode(TNode value)
        {
            Value = value;
        }
        public int CompareTo(TNode other)
        {
            return Value.CompareTo(other);
        }

        
    }
}
