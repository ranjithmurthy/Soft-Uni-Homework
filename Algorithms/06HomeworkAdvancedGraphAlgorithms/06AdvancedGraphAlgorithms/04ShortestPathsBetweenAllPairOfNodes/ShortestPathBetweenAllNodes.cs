﻿
namespace _04ShortestPathsBetweenAllPairOfNodes
{
    using System;

    public class ShortestPathBetweenAllNodes
    {
        public static void Main(string[] args)
        {
            int nodes = int.Parse(Console.ReadLine().Substring(7));
            int edges = int.Parse(Console.ReadLine().Substring(7));
            long[,] distances = new long[nodes, nodes];

            // initialize matrix
            for (int i = 0; i < nodes; i++)
            {
                for (int j = 0; j < nodes; j++)
                {
                    if (i != j)
                    {
                        distances[i, j] = int.MaxValue;
                    }
                }
            }

            // load edges
            for (int i = 0; i < edges; i++)
            {
                string[] parameters = Console.ReadLine().Split();
                int start = int.Parse(parameters[0]);
                int end = int.Parse(parameters[1]);
                int weight = int.Parse(parameters[2]);

                distances[start, end] = weight;
                distances[end, start] = weight;
            }

            FloydWarshall(distances, nodes);
            Console.WriteLine("Shortest paths matrix:");
            for (int i = 0; i < nodes; i++)
            {
                Console.Write(" {0} ", i);
            }
            Console.WriteLine();
            for (int i = 0; i < nodes; i++)
            {
                Console.Write("---");
            }
            Console.WriteLine();
            for (int i = 0; i < nodes; i++)
            {
                for (int j = 0; j < nodes; j++)
                {
                    Console.Write("{0,2} ", distances[i, j]);
                }
                Console.WriteLine();
            }
        }

        private static void FloydWarshall(long[,] distances, int nodes)
        {
            for (int elementsUsed = 0; elementsUsed < nodes; elementsUsed++)
            {
                for (int start = 0; start < nodes; start++)
                {
                    for (int end = 0; end < nodes; end++)
                    {
                        if (distances[start, end] > distances[start, elementsUsed] + distances[elementsUsed, end])
                        {
                            distances[start, end] = distances[start, elementsUsed] + distances[elementsUsed, end];
                        }
                    }
                }
            }
        }
    }
}
