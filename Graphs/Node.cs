using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graphs
{
    internal class Node
    {
        public int data;
        List<Node> connectedNodes = new List<Node>();

        public Node(int x)
        {
            data = x;
        }

        public void connect(Node data)
        {
            connectedNodes.Add(data);
        }
    }
}
