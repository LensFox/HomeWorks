using System;

namespace _5_AVL_Tree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            BinaryTree<int> myTree = new BinaryTree<int>();

            myTree.Add(9);
            myTree.Add(2);
            myTree.Add(3);
            myTree.Add(0);
            myTree.Add(5);
            myTree.Add(4);
            myTree.Add(9);
            myTree.Add(11);

            foreach (var item in myTree)
            {
                Console.WriteLine(item);
            }
        }
    }
}
