using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Graphs;

namespace Graphs
{
    public class Edge
    {
        public int fee { get; set; }
        public Vertex from = new Vertex();
        public Vertex to = new Vertex();


       
    }
}
