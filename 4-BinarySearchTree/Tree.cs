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
                yield return node.Value;
                PreOrder(node.Left);
                PreOrder(node.Right);
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
