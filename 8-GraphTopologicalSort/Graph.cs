using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_GraphTopologicalSort
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
            list[from, to] = cost;
        }
        enum Colours { WHITE, GREY, BLACK };

        public IList<int> TopologicalSort()
        {
            Stack<int> result = new Stack<int>();
            Colours[] colours = new Colours[n];
            Stack<int> path = new Stack<int>();

            for (int i = 0; i < n; i++)
            {
                int vertex = i;
                int saved = i;

                if (path.Count > 0)
                {
                    i--;
                    vertex = path.Pop();
                    saved = vertex;
                }

                if (colours[vertex] == Colours.BLACK)
                    continue;

                colours[vertex] = Colours.GREY;
                path.Push(vertex);
                for (int j = 0; j < n; j++)
                {
                    if (list[vertex, j] != 0 && colours[j] != Colours.BLACK)
                    {
                        if (colours[j] == Colours.GREY)
                            return null;
                        vertex = j;
                        path.Push(vertex);
                        break;
                    }
                }
                if (vertex == saved)
                {
                    colours[vertex] = Colours.BLACK;
                    result.Push(vertex);
                    path.Pop();
                }
            }

            return result.ToList();
        }
    }
}
