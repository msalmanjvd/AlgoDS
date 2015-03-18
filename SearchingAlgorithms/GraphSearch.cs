using System;
using System.Collections.Generic;

namespace SearchingAlgorithms
{
    public class GraphSearch
    {
        static bool[] graphFlag;

        public static void RunDFS(List<int>[] graph)
        {
            graphFlag = new bool[graph.Length];

            int len = graph.Length;

            DFS(len - 1, graph);
        }


        public static void RunBFS(List<int>[] graph)
        {
            graphFlag = new bool[graph.Length];
            BFS(6, graph);
        }

        private static void DFS(int node, List<int>[] graph)
        {
            if (graphFlag[node])
            {
                return;
            }
            graphFlag[node] = true;

            for (int j = 0; j < graph[node].Count; j++)
            {
                if (!graphFlag[graph[node][j]])
                {
                    DFS(graph[node][j], graph);
                }

            }

        }

        private static void BFS(int node, List<int>[] graph)
        {
            Queue<int> bfsQueue = new Queue<int>();
            bfsQueue.Enqueue(node);
            graphFlag[node] = true;
            Console.WriteLine(node);

            while (bfsQueue.Count != 0)
            {
                int target = bfsQueue.Dequeue(); //Remove the top element
                for (int i = 0; i < graph[target].Count; i++)
                {
                    if (!graphFlag[graph[target][i]])
                    {
                        bfsQueue.Enqueue(graph[target][i]);
                        Console.WriteLine(graph[target][i]);
                        graphFlag[graph[target][i]] = true;
                    }
                }
            }
        }


        public static int[] DijkstraShortestPath(List<Tuple<int, int>>[] graph, int start)
        {
            int[] A = new int[graph.Length];
            for (int i = 0; i < A.Length; i++)
            {
                A[i] = 1000000;

            }
            List<int> X = new List<int>();
            string[] B = new string[graph.Length];
            int current = start;
            int distance = 0;
            string path;

            A[start] = distance;
            path = start + "";
            B[start] = path;
            X.Add(start);


            while (X.Count <= graph.Length - 1)
            {

                int minDist = int.MaxValue;
                int minNode;

                minNode = graph[current][0].Item1;

                for (int i = 0; i < graph[current].Count; i++)
                {
                    int node = graph[current][i].Item1;


                    if (!X.Contains(node))
                    {
                        int edge = graph[current][i].Item2;


                        if (A[node] > distance + edge)
                        {
                            A[node] = distance + edge;
                            B[node] = path + current;
                        }


                    }
                }
                X.Add(current);

                int min = int.MaxValue;
                int minIndex = 0;
                for (int i = 0; i < A.Length; i++)
                {

                    if (A[i] < min && !X.Contains(i))
                    {
                        min = A[i];
                        minIndex = i;
                    }
                }

                current = minIndex;

                distance = A[current];
                path += current;
            }

            return A;
        }

    }
}
