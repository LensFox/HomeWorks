using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_BinarySearchTree
{
    internal class Tree<T> : IEnumerable<T> where T : IComparable<T>
    {
        private TreeNode<T> _root;
        private int _count;
        public int Count { get { return _count; } }
        
        public bool Contains(T value)
        {
            TreeNode<T> parent;
            return FindWithParent(value, out parent) != null;
        }

        public void Add (T value)
        {
            if (_root == null)
            {
                _root = new TreeNode<T>(value);

            }
            else
            {
                AddTo(_root, value);
            }
            _count++;
        }
        private void AddTo(TreeNode<T> node, T value)
        {
            if (value.CompareTo(node.Value) < 0)

            {
                if (node.Left == null)
                {
                    node.Left = new TreeNode<T>(value);
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
                    node.Right = new TreeNode<T>(value);
                }
                else
                {
                    AddTo(node.Right, value);
                }
            }
        }

        private TreeNode<T> FindWithParent(T value, out TreeNode<T> parent)
        {
            TreeNode<T> current = _root;
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

        public IEnumerable<T> PreOrder(TreeNode<T> node)
        {
            if (node != null)
            {
                if (node == null)
                    yield break;

                if (node.Left != null)
                    foreach (var n in PreOrder(node.Left)) yield return n;

                if (node.Right != null)
                    foreach (var n in PreOrder(node.Right)) yield return n;

                yield return node.Value;
            }
        }
        public IEnumerable<T> PostOrder(TreeNode<T> node)
        {
            if (node != null)
            {
                PostOrder(node.Left);
                PostOrder(node.Right);
                yield return node.Value;
            }
        }

        public void InOrder(TreeNode<T> node)
        {
            if (node != null)
            {
                InOrder(node.Left);
                Console.WriteLine(node.Value.ToString());
                InOrder(node.Right);
            }
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
