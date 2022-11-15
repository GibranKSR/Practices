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
    public class Graph
    {
        public Vertex? root { get; set; }
        public List<Vertex> vertexes = new List<Vertex>();
        public string searchedValue;
        public List<String> BFSL = new List<String>();
        public string BFSLS;
        public List<String> DFSL = new List<String>();
        public string DFSLS;
        public List<String> SPL = new List<String>();
        public string SPLS;
        public List<String> SPL2 = new List<String>();
        public string SPLS2;
        public List<String> VL = new List<String>();
        public string VLS;
        public String[] M1 = new String[7];
        public string M1S;
        public String[] M2 = new String[7];
        public string M2S;
        public String[] M3 = new String[7];
        public string M3S;
        public String[] M4 = new String[7];
        public string M4S;
        public String[] M5 = new String[7];
        public string M5S;
        public String[] M6 = new String[7];
        public string M6S;
        public String[] M7 = new String[7];
        public string M7S;

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
                    searchedValue = v.data;
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
                String temp = "[" + v.data + "]";
                VL.Add(temp);
            }

            VLS = String.Join(",", VL);
        }


        public void matrix()
        {
            M1[0] = "   ";
            for (int i = 1; i <= vertexes.Count(); i++)
            {
                M1[i] = " " + "[" + vertexes[i-1].data + "]";
            }
            for (int i = 0; i < vertexes.Count(); i++)
            {
                if (i == 0)
                {
                    M2[0] = "[" + vertexes[i].data + "]";
                    for (int j = 1; j < vertexes.Count(); j++)
                    {

                        if (vertexes[j].vertexes.Contains(vertexes[i]))
                        {
                            M2[j] = " [1]";
                        }
                        else
                        {
                            M2[j] = " [0]";
                        }
                    }
                }
                if (i == 1)
                {
                    M3[0] = "[" + vertexes[i].data + "]";
                    for (int j = 1; j < vertexes.Count(); j++)
                    {

                        if (vertexes[j].vertexes.Contains(vertexes[i]))
                        {
                            M3[j] = " [1]";
                        }
                        else
                        {
                            M3[j] = " [0]";
                        }
                    }
                }
                if (i == 2)
                {
                    M4[0] = "[" + vertexes[i].data + "]";
                    for (int j = 1; j < vertexes.Count(); j++)
                    {

                        if (vertexes[j].vertexes.Contains(vertexes[i]))
                        {
                            M4[j] = " [1]";
                        }
                        else
                        {
                            M4[j] = " [0]";
                        }
                    }
                }
                if (i == 3)
                {
                    M5[0] = "[" + vertexes[i].data + "]";
                    for (int j = 1; j < vertexes.Count(); j++)
                    {

                        if (vertexes[j].vertexes.Contains(vertexes[i]))
                        {
                            M5[j] = " [1]";
                        }
                        else
                        {
                            M5[j] = " [0]";
                        }
                    }
                }
                if (i == 4)
                {
                    M6[0] = "[" + vertexes[i].data + "]";
                    for (int j = 1; j < vertexes.Count(); j++)
                    {

                        if (vertexes[j].vertexes.Contains(vertexes[i]))
                        {
                            M6[j] = " [1]";
                        }
                        else
                        {
                            M6[j] = " [0]";
                        }
                    }
                }
                if (i == 5)
                {
                    M7[0] = "[" + vertexes[i].data + "]";
                    for (int j = 1; j < vertexes.Count(); j++)
                    {

                        if (vertexes[j].vertexes.Contains(vertexes[i]))
                        {
                            M7[j] = " [1]";
                        }
                        else
                        {
                            M7[j] = " [0]";
                        }
                    }
                }
            }

            M1S = String.Join(" ", M1);
            M2S = String.Join(" ", M2);
            M3S = String.Join(" ", M3);
            M4S = String.Join(" ", M4);
            M5S = String.Join(" ", M5);
            M6S = String.Join(" ", M6);
            M7S = String.Join(" ", M7); 

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
                BFSL.Add(vertex.data);
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

            BFSLS = string.Join(",", BFSL);

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
                DFSL.Add(vertex.data);
                foreach (Vertex v in vertex.vertexes)
                {
                    if (!visited.Contains(v))
                    {
                        visited.Add(v);
                        stack.Push(v);
                    }
                }
            }
            DFSLS = string.Join(",", DFSL);
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

            if (sum < sum2)
            {
                foreach (Vertex v in path)
                {
                    SPL.Add(v.data);
                    if (v.data.Equals("A"))
                    {
                        break;
                    }
                }


                foreach (Vertex v in final)
                {
                    foreach (Edge e in v.edges)
                    {
                        if (final.Contains(e.from) && final.Contains(e.to))
                        {
                            string R = e.from.data + "-> " + e.fee + " <-" + e.to.data;
                            SPL2.Add(R);
                        }

                    }
                }
                SPL.Add(sum.ToString());
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

                foreach (Vertex v in final2)
                {
                    foreach (Edge e in v.edges)
                    {
                        if (final2.Contains(e.from) && final2.Contains(e.to))
                        {
                            string R = e.from.data + "-> " + e.fee + " <-" + e.to.data;
                            SPL2.Add(R);
                        }

                    }
                }
                SPL.Add(sum2.ToString());
            }

            SPLS = string.Join(",", SPL);
            SPLS2 = string.Join(",", SPL2);
        }
    }
}