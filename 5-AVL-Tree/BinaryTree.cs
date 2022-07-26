using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_AVL_Tree
{
    internal class BinaryTree<T> : IEnumerable<T> where T : IComparable<T>
    {
        public BinaryTreeNode<T> _root { set; get; }
        
        private int _count;

        public int Count { get { return _count; } }
        public bool Contains(T value)
        {
            BinaryTreeNode<T> parent;
            return FindWithParent(value, out parent) != null;
        }

        public void Add(T value)
        {
            if (_root == null)
            {
                _root = new BinaryTreeNode<T>(value, null);
                _root._tree = this;

            }
            else
            {
                AddTo(_root, value);
            }

            _count++;
        }
        private void AddTo(BinaryTreeNode<T> node, T value)
        {
            if (value.CompareTo(node.Value) < 0)

            {
                if (node.Left == null)
                {
                    node.Left = new BinaryTreeNode<T>(value, node);
                }
                else
                {
                    AddTo(node.Left, value);
                }
            }
            else
            {
                if (node.Right == null)
                {
                    node.Right = new BinaryTreeNode<T>(value, node);
                }
                else
                {
                    AddTo(node.Right, value);
                }
            }

            node.Balance();
        }

        private BinaryTreeNode<T> FindWithParent(T value, out BinaryTreeNode<T> parent)
        {
            BinaryTreeNode<T> current = _root;
            parent = null;
            while (current != null)
            {
                int result = current.CompareTo(value);
                if (result > 0)
                {
                    parent = current;
                    current = current.Left;
                }
                else if (result < 0)
                {
                    parent = current;
                    current = current.Right;
                }
                else
                {
                    break;
                }
            }
            return current;
        }

        public bool Remove(T value)
        {
            BinaryTreeNode<T> current;
            BinaryTreeNode<T> parent;

            current = FindWithParent(value, out parent);

            if (current == null)
            {
                return false;
            }

            BinaryTreeNode<T> treeToBalance = current.Parent;
            _count--;

            if (current.Right == null)
            {
                if (parent == null)
                {
                    _root = current.Left;
                }
                else
                {
                    int result = parent.CompareTo(current.Value);

                    if (result > 0)
                    {
                        parent.Left = current.Left;
                    }
                    else if (result < 0)
                    {
                        parent.Right = current.Left;
                    }
                }
            }
            else if (current.Right.Left == null)
            {
                current.Right.Left = current.Left;

                if (parent == null)
                {
                    _root = current.Right;
                }
                else
                {
                    int result = parent.CompareTo(current.Value);
                    if (result > 0)
                    {
                        parent.Left = current.Right;
                    }
                    else if (result < 0)
                    {
                        parent.Right = current.Right;
                    }
                }
            }
            else
            {
                BinaryTreeNode<T> leftMost = current.Right.Left;
                BinaryTreeNode<T> leftMostParent = current.Right;

                while (leftMost.Left != null)
                {
                    leftMostParent = leftMost;
                    leftMost = leftMost.Left;
                }

                leftMostParent.Right = leftMost.Right;

                leftMost.Left = current.Left;
                leftMost.Right = current.Right;
                if (parent == null)
                {
                    _root = leftMost;
                }
                else
                {
                    int result = parent.CompareTo(current.Value);
                    if (result > 0)
                    {
                        parent.Left = leftMost;
                    }
                    else if (result < 0)
                    {
                        parent.Right = leftMost;
                    }
                }
            }
            if (treeToBalance != null)
            {
                treeToBalance.Balance();
            }
            else
            {
                if (_root != null)
                {
                    _root.Balance();
                }
            }
            return true;
        }

        //public void PreOrder(BinaryTreeNode<T> node)
        //{
        //    if (node != null)
        //    {
        //        MessageBox.Show(node.Value.ToString());
        //        PreOrder(node.Left);
        //        PreOrder(node.Right);
        //    }
        //}
        public IEnumerable<T> PreOrder(BinaryTreeNode<T> node)
        {
            if (node == null)
                yield break;

            yield return node.Value;

            foreach (var value in PreOrder(node.Left))
                yield return value;

            foreach (var value in PreOrder(node.Right))
                yield return value;
            //var stack = new Stack<BinaryTreeNode<T>>();
            //stack.Push(node);

            //while (stack.Count > 0)
            //{
            //    var n = stack.Pop();

            //    if (node == null)
            //        continue;

            //    yield return node.Value;
            //    stack.Push(node.Right);
            //    stack.Push(node.Left);
            //}
        }
        public IEnumerator<T> GetEnumerator()
        {
            return PreOrder(_root).GetEnumerator();
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

    }
}

