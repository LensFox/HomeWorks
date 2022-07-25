using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_GraphsCities
{
    internal class Graph
    {
        private int[,] list;
        private int n;
        private int _count = 0;
        public int Count { get { return _count; } }
        public Graph(int n)
        {
            list = new int[n, n];
            this.n = n;
        }
        public Graph(int[,] arr)
        {
            list = arr;
            n = arr.GetLength(0);
        }
        public void Add(int from, int to, int cost)
        {

            if (list[from, to] == 1 && cost == 0 && list[to, from] == 0)
            {
                _count--;
            }
            else if (list[from, to] == 0 && cost == 1 && list[to, from] == 0)
            {
                _count++;
            }

            list[from, to] = cost;
        }
        public IList<int> DFS()
        {
            bool[] visited = new bool[n];
            Stack<int> stack = new Stack<int>();
            IList<int> result = new List<int>();

            stack.Push(list[0, 0]);
            visited[0] = true;

            while (stack.Count != 0)
            {
                int index = stack.Pop();
                result.Add(index);

                for (int i = 0; i < n; i++)
                {
                    if (!visited[n] && list[index, i] != 0)
                    {
                        stack.Push(i);
                        visited[i] = true;
                    }
                }
            }
            return result;
        }
    }
}
