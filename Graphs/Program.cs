using System;

namespace Graphs
{
    class Program
    {
        static void Main(string[] args)
        {
            Node n1 = new Node(1);
            Node n2 = new Node(2);
            Node n3 = new Node(3);

            n1.connect(n2);
            n1.connect(n3);
            n3.connect(n4);
            n4.connect(n1);
        }
    }
}