using System;

namespace _4_BinarySearchTree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Tree<int> myTree = new Tree<int>();
            
            myTree.Add(9);
            myTree.Add(0);
            myTree.Add(7);
            myTree.Add(12);
            myTree.Add(2);
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
