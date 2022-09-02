using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_AVL_Tree
{
    internal class BinaryTreeNode<TNode> : IComparable<TNode> where TNode : IComparable<TNode>
    {
        public TNode Value { get; private set; }
        private BinaryTreeNode<TNode> _left;
        private BinaryTreeNode<TNode> _right;

        public BinaryTreeNode<TNode> Left
        {
            get
            {
                return _left;
            }
            internal set
            {
                _left = value;
                if (_left != null)
                {
                    _left.Parent = this;
                }
            }
        }
        public BinaryTreeNode<TNode> Right
        {
            get
            {
                return _right;
            }
            internal set
            {
                _right = value;
                if (_right != null)
                {
                    _right.Parent = this;
                }
            }
        }
        internal BinaryTree<TNode> _tree;
        public BinaryTreeNode<TNode> Parent { get; internal set; }
        public BinaryTreeNode(TNode value, BinaryTreeNode<TNode> parent)
        {
            Value = value;
            Parent = Parent;
            
        }
        public int CompareTo(TNode other)
        {
            return Value.CompareTo(other);
        }
        public int CompareNode(BinaryTreeNode<TNode> other)
        {
            return Value.CompareTo(other.Value);
        }
        private int LeftHeight { get { return MaxChildHeight(Left); } }
        private int RightHeight { get { return MaxChildHeight(Right); } }
        enum TreeState
        {
            Balanced,
            LeftHeavy,
            RightHeavy
        }
        internal void Balance()
        {
            if (State == TreeState.RightHeavy)
            {
                if (Right != null && Right.BalanceFactor < 0)
                {
                    LeftRightRotation();
                }

                else
                {
                    LeftRotation();
                }
            }
            else if (State == TreeState.LeftHeavy)
            {
                if (Left != null && Left.BalanceFactor > 0)
                {
                    RightLeftRotation();
                }
                else
                {
                    RightRotation();
                }
            }
        }

        private TreeState State
        {
            get
            {
                if (LeftHeight - RightHeight > 1)
                    return TreeState.LeftHeavy;
                if (RightHeight - LeftHeight > 1)
                    return TreeState.RightHeavy;
                return TreeState.Balanced;
            }
        }
        private int BalanceFactor
        {
            get
            {
                return RightHeight - LeftHeight;
            }
        }
        private int MaxChildHeight(BinaryTreeNode<TNode> node)
        {
            if (node != null)
            {
                return 1 + Math.Max(MaxChildHeight(node.Left), MaxChildHeight(node.Right));
            }
            return 0;
        }
        private void LeftRotation()
        {
            BinaryTreeNode<TNode> newRoot = Right;
            ReplaceRoot(newRoot);
            Right = newRoot.Left;
            newRoot.Left = this;
        }
        private void RightRotation()
        {
            BinaryTreeNode<TNode> newRoot = Left;
            ReplaceRoot(newRoot);
            Left = newRoot.Right;
            newRoot.Right = this;
        }
        private void LeftRightRotation()
        {
            Right.RightRotation();
            LeftRotation();
        }

        private void RightLeftRotation()
        {
            Left.LeftRotation();
            RightRotation();
        }

        public void ReplaceRoot(BinaryTreeNode<TNode> newRoot)
        {
            
            if (this.Parent != null)
            {
                if (this.Parent.Left == this)
                {
                    this.Parent.Left = newRoot;
                }
                else if (this.Parent.Right == this)
                {
                    this.Parent.Right = newRoot;
                }
                newRoot.Parent = this.Parent;
                this.Parent = newRoot;
            }
            else
            {
                _tree.Root = newRoot;
            }
        }
    }

}
