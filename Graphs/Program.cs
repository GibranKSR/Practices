using Graphs;
using System.Runtime.InteropServices;

namespace Program
{
    class Program
    {
        private static void Main(string[] args)
        {
            Vertex vertex1 = new Vertex();
            vertex1.data = "A";
            Vertex vertex2 = new Vertex();
            vertex2.data = "B";
            Vertex vertex3 = new Vertex();
            vertex3.data = "C";
            Vertex vertex4 = new Vertex();
            vertex4.data = "D";
            Vertex vertex5 = new Vertex();
            vertex5.data = "E";
            Vertex vertex6 = new Vertex();
            vertex6.data = "F";
            Vertex vertex7 = new Vertex();
            vertex7.data = "G";
            Vertex vertex8 = new Vertex();
            vertex8.data = "H";


            Graph graph1 = new Graph();
            graph1.insert(vertex1, vertex1, 0);
            graph1.insert(vertex2, vertex1, 2);
            graph1.insert(vertex3, vertex2, 5);
            graph1.insert(vertex4, vertex2, 6);
            graph1.insert(vertex4, vertex1, 4);
            graph1.insert(vertex5, vertex3, 2);
            graph1.insert(vertex5, vertex4, 8);
            graph1.insert(vertex6, vertex4, 3);
            graph1.insert(vertex7, vertex3, 2);
            graph1.insert(vertex8, vertex3, 3);

            Console.WriteLine("----------VERTEXES----------");
            graph1.printVertexes();

            Console.WriteLine("------------EDGES------------");
            foreach (Edge i in vertex1.edges)
            {
                Console.WriteLine("[" + i.fee + "]" + " " + i.from.data + " " + i.to.data);
            }

            Console.WriteLine(" ");
            foreach (Edge i in vertex2.edges)
            {
                Console.WriteLine("[" + i.fee + "]" + " " + i.from.data + " " + i.to.data);
            }


            Console.WriteLine(" ");
            foreach (Edge i in vertex3.edges)
            {
                Console.WriteLine("[" + i.fee + "]" + " " + i.from.data + " " + i.to.data);
            }


            Console.WriteLine(" ");
            foreach (Edge i in vertex4.edges)
            {
                Console.WriteLine("[" + i.fee + "]" + " " + i.from.data + " " + i.to.data);
            }

            Console.WriteLine("------------SEARCH------------");
            graph1.search("E");

            Console.WriteLine("------------MATRIX------------");
            graph1.matrix();
            Console.WriteLine(" ");

            Console.WriteLine("-------------BFS-------------");
            graph1.bfs(vertex1);

            Console.WriteLine("-------------DFS-------------");
            graph1.dfs(vertex1);

            Console.WriteLine("-----------SHORTEST-----------");
            graph1.shortestPath(vertex5, vertex1);
        }
    }
}