using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Graphs
{
    internal class Graph
    {
        public Vertex? root { get; set; }
        public List<Vertex> vertexes = new List<Vertex>();

        public void insert(Vertex vertex, Vertex onVertex, int wei)
        {
            if (root == null)
            {
                root = vertex;
                vertexes.Add(vertex);
            }
            else
            {
                Edge edge1 = new Edge();
                edge1.fee = wei;
                edge1.from = onVertex;
                edge1.to = vertex;
                onVertex.edges.Add(edge1);

                onVertex.vertexes.Add(vertex);
                vertex.vertexes.Add(onVertex);

                int x = 0;
                foreach (Vertex v in vertexes)
                {
                    if (v.data.Equals(vertex.data))
                    {
                        x += 1;
                    }
                }
                if (x == 0)
                {
                    vertexes.Add(vertex);
                }
            }
        }
        public void delete(string data)
        {

            for (int i = 0; i < vertexes.Count; i++)
            {
                if (vertexes[i].data.Equals(data))
                {
                    vertexes[i].vertexes.Clear();
                    vertexes[i].edges.Clear();
                    vertexes.Remove(vertexes[i]);
                }
            }
            foreach (Vertex v in vertexes)
            {
                foreach (Edge e in v.edges)
                {
                    if (e.to.data.Equals(data))
                    {
                        v.edges.Remove(e);
                        break;
                    }
                }
            }
        }

        public void search(string data)
        {
            foreach (Vertex v in vertexes)
            {
                if (v.data.Equals(data))
                {
                    Console.WriteLine("Value found: " + v.data);
                }
            }
            foreach (Vertex v in vertexes)
            {
                foreach (Edge e in v.edges)
                {
                    if (e.from.data.Equals(data) | e.to.data.Equals(data))
                    {
                        Console.WriteLine("Edge: " + "[" + e.from.data + "]" + " " + "[" + e.to.data + "]");
                    }
                }
            }
        }
        public void printVertexes()
        {
            foreach (Vertex v in vertexes)
            {
                Console.WriteLine("["+v.data+"]");
            }
        }


        public void matrix()
        {
            Console.Write("   ");
            for (int i = 0; i < vertexes.Count(); i++)
            {
                Console.Write(" " +"["+vertexes[i].data+"]");
            }
            for (int i = 0; i < vertexes.Count(); i++)
            {
                Console.WriteLine(" ");
                Console.Write("[" + vertexes[i].data + "]");
                for (int j = 0; j < vertexes.Count(); j++)
                {

                    if (vertexes[j].vertexes.Contains(vertexes[i]))
                    {
                        Console.Write(" [1]");
                    }
                    else
                    {
                        Console.Write(" [0]");
                    }
                }
            }
        }
        public void bfs(Vertex vertex)
        {

            List<Vertex> visited = new List<Vertex>();
            LinkedList<Vertex> queue = new LinkedList<Vertex>();
            visited.Add(vertex);
            queue.AddLast(vertex);

            while (queue.Count != 0)
            {
                vertex = queue.First();
                Console.WriteLine("next-> " + vertex.data);
                queue.RemoveFirst();

                foreach (Vertex v in vertex.vertexes)
                {
                    if (!visited.Contains(v))
                    {
                        visited.Add(v);
                        queue.AddLast(v);
                    }
                }
            }

        }
        public void dfs(Vertex vertex)
        {
            List<Vertex> visited = new List<Vertex>();
            Stack<Vertex> stack = new Stack<Vertex>();
            visited.Add(vertex);
            stack.Push(vertex);

            while (stack.Count != 0)
            {
                vertex = stack.Pop();
                Console.WriteLine("next-> " + vertex.data);
                foreach (Vertex v in vertex.vertexes)
                {
                    if (!visited.Contains(v))
                    {
                        visited.Add(v);
                        stack.Push(v);
                    }
                }
            }
        }


        public void shortestPath(Vertex vertex, Vertex from)
        {
            List<Vertex> path = new List<Vertex>();
            List<Vertex> path2 = new List<Vertex>();
            Stack<Vertex> stack = new Stack<Vertex>();
            Stack<Vertex> vers = new Stack<Vertex>();
            Vertex vertexs = vertex;


            foreach (Vertex v in vertex.vertexes)
            {
                vers.Push(v);
            }

            path.Add(vertex);
            Vertex pred = vertex;
            stack.Push(vertex);


            while (stack.Count != 0)
            {
                vertex = stack.Pop();
                foreach (Vertex v in vertex.vertexes)
                {
                    if (!path.Contains(v) && v.vertexes.Contains(pred))
                    {
                        pred = v;
                        stack.Push(v);
                        path.Add(v);
                    }
                }
            }
            int sum = 0;
            List<Vertex> final = new List<Vertex>();

            foreach (Vertex v in path)
            {
                final.Add(v);
                if (v.data.Equals("A"))
                {
                    break;
                }
            }

            Console.WriteLine(" ");

            foreach (Vertex v in final)
            {
                foreach (Edge e in v.edges)
                {
                    if (final.Contains(e.from) && final.Contains(e.to))
                    {
                        sum += e.fee;
                    }

                }
            }




            int sum2 = 0;
            List<Vertex> final2 = new List<Vertex>();

            if (vers.Count > 1)
            {
                path2.Add(vertexs);
                vertex = vers.Pop();

                path2.Add(vertex);
                pred = vertex;
                stack.Push(vertex);


                while (stack.Count != 0)
                {
                    vertex = stack.Pop();
                    foreach (Vertex v in vertex.vertexes)
                    {
                        if (!path2.Contains(v) && v.vertexes.Contains(pred))
                        {
                            pred = v;
                            stack.Push(v);
                            path2.Add(v);
                        }
                    }
                }
                foreach (Vertex v in path2)
                {
                    final2.Add(v);
                    if (v.data.Equals("A"))
                    {
                        break;
                    }
                }

                Console.WriteLine(" ");
                foreach (Vertex v in final2)
                {
                    foreach (Edge e in v.edges)
                    {
                        if (final2.Contains(e.from) && final2.Contains(e.to))
                        {
                            sum2 += e.fee;
                        }

                    }
                }
            }



            Console.WriteLine(" ");
            if (sum < sum2)
            {
                foreach (Vertex v in path)
                {
                    Console.WriteLine(v.data);
                    if (v.data.Equals("A"))
                    {
                        break;
                    }
                }

                Console.WriteLine(" ");

                foreach (Vertex v in final)
                {
                    foreach (Edge e in v.edges)
                    {
                        if (final.Contains(e.from) && final.Contains(e.to))
                        {
                            Console.WriteLine(e.from.data + "-> " + e.fee + " <-" + e.to.data);
                        }

                    }
                }
                Console.WriteLine(" ");
                Console.WriteLine(sum);
            }


            if (sum2 < sum)
            {
                foreach (Vertex v in path2)
                {
                    Console.WriteLine(v.data);
                    if (v.data.Equals("A"))
                    {
                        break;
                    }
                }

                Console.WriteLine(" ");
                foreach (Vertex v in final2)
                {
                    foreach (Edge e in v.edges)
                    {
                        if (final2.Contains(e.from) && final2.Contains(e.to))
                        {
                            Console.WriteLine(e.from.data + "-> " + e.fee + " <-" + e.to.data);
                        }

                    }
                }
                Console.WriteLine(" ");
                Console.WriteLine(sum2);
            }


            if (sum == sum2)
            {
                Console.WriteLine(sum + " " + sum2);
            }

        }
    }
}