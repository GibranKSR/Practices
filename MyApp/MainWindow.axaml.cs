using Avalonia.Controls;
using Avalonia.Interactivity;
using BinaryTree;
using Graphs;
using System;

namespace MyApp
{
    public partial class MainWindow : Window
    {
        BinaryTree.BinaryTree binaryTree = new BinaryTree.BinaryTree();
        Vertex V1 = new Vertex();
        Vertex V2 = new Vertex();
        Vertex V3 = new Vertex();
        Vertex V4 = new Vertex();
        Vertex V5 = new Vertex();
        Vertex V6 = new Vertex();
        Vertex V7 = new Vertex();
        Vertex V8 = new Vertex();
        Vertex V9 = new Vertex();
        Graph GE = new Graph();
        public MainWindow()
        {
            InitializeComponent();
        }
        public void iniTree(object sender, RoutedEventArgs e)
        {
            UI1.IsVisible = false;
            UI2.IsVisible = true;
        }
        public void addNode(object sender, RoutedEventArgs e)
        {
            binaryTree.Insert(int.Parse(addNodeNum.Text));
        }
        public void removeNT(object sender, RoutedEventArgs e)
        {
            binaryTree.Remove(int.Parse(remNodeNum.Text));
        }
        public void searchNT(object sender, RoutedEventArgs e)
        {
            RES.IsVisible = true;
            SNT.IsVisible = true;
            defCLose1.IsVisible = false;
            defCLose2.IsVisible = false;
            var node = binaryTree.Find(int.Parse(seaNodeNum.Text));
            if (node != null)
            {
                SNTR.Text ="THE NODE"+ "\n" + node.Data.ToString() + "\n" + "WAS FOUND!!!";
            }
            else
            {
                SNTR.Text = "THIS NODE DOESN'T EXIST";
            }

        }
        public void printTree(object sender, RoutedEventArgs e)
        {
            RES.IsVisible = true;
            PT.IsVisible= true;
            defCLose1.IsVisible = false;
            defCLose2.IsVisible = false;
            PTR1.Text = "TREE (HEIGHT ->" + binaryTree.Height() + "<-)";
            binaryTree.InOrderTraversal();
            PTR2.Text = "In Order Traversal (Left->Root->Right): " + "\n" + binaryTree.combinedString;
            binaryTree.PreorderTraversal();
            PTR3.Text = "Pre Order Traversal (Root->Left->Right): " + "\n" + binaryTree.combinedString2;
            binaryTree.PostorderTraversal();
            PTR4.Text = "Post Order Traversal (Left->Right->Root): " + "\n" + binaryTree.combinedString3;
        }
        public void iniGraph(object sender, RoutedEventArgs e)
        {
            UI1.IsVisible = false;
            UI3.IsVisible = true;
        }
        public void addGN(object sender, RoutedEventArgs e)
        {
            UI3.IsVisible = false;
            UI3_2.IsVisible = true;

            V1.data = GN1.Text;
            V2.data = GN2.Text;
            V3.data = GN3.Text;
            V4.data = GN4.Text;
            V5.data = GN5.Text;
            V6.data = GN6.Text;
            GE.insert(V1, V1, 0);
        }
        public void addEdge(object sender, RoutedEventArgs e)
        {
            if (from.Text == "V1")
            {
                if (to.Text == "V2")
                {
                    GE.insert(V1, V2, int.Parse(fee.Text));
                }
                else if (to.Text == "V3")
                {
                    GE.insert(V1, V3, int.Parse(fee.Text));
                }
                else if (to.Text == "V5")
                {
                    GE.insert(V1, V5, int.Parse(fee.Text));
                }
                else if (to.Text == "V6")
                {
                    GE.insert(V1, V6, int.Parse(fee.Text));
                }
                else if (to.Text == "V4")
                {
                    GE.insert(V1, V4, int.Parse(fee.Text));
                }
            }
            else if (from.Text == "V2")
            {
                if (to.Text == "V1")
                {
                    GE.insert(V2, V1, int.Parse(fee.Text));
                }
                else if (to.Text == "V3")
                {
                    GE.insert(V2, V3, int.Parse(fee.Text));
                }
                else if (to.Text == "V4")
                {
                    GE.insert(V2, V4, int.Parse(fee.Text));
                }
                else if (to.Text == "V5")
                {
                    GE.insert(V2, V5, int.Parse(fee.Text));
                }
                else if (to.Text == "V6")
                {
                    GE.insert(V2, V6, int.Parse(fee.Text));
                }
            }
            else if (from.Text == "V3")
            {
                if (to.Text == "V1")
                {
                    GE.insert(V3, V1, int.Parse(fee.Text));
                }
                else if (to.Text == "V2")
                {
                    GE.insert(V3, V2, int.Parse(fee.Text));
                }
                else if (to.Text == "V4")
                {
                    GE.insert(V3, V4, int.Parse(fee.Text));
                }
                else if (to.Text == "V5")
                {
                    GE.insert(V3, V5, int.Parse(fee.Text));
                }
                else if (to.Text == "V6")
                {
                    GE.insert(V3, V6, int.Parse(fee.Text));
                }
            }
            else if (from.Text == "V4")
            {
                if (to.Text == "V1")
                {
                    GE.insert(V4, V1, int.Parse(fee.Text));
                }
                else if (to.Text == "V3")
                {
                    GE.insert(V4, V3, int.Parse(fee.Text));
                }
                else if (to.Text == "V2")
                {
                    GE.insert(V4, V2, int.Parse(fee.Text));
                }
                else if (to.Text == "V5")
                {
                    GE.insert(V4, V5, int.Parse(fee.Text));
                }
                else if (to.Text == "V6")
                {
                    GE.insert(V4, V6, int.Parse(fee.Text));
                }
            }
            else if (from.Text == "V5")
            {
                if (to.Text == "V1")
                {
                    GE.insert(V5, V1, int.Parse(fee.Text));
                }
                else if (to.Text == "V3")
                {
                    GE.insert(V5, V3, int.Parse(fee.Text));
                }
                else if (to.Text == "V4")
                {
                    GE.insert(V5, V4, int.Parse(fee.Text));
                }
                else if (to.Text == "V2")
                {
                    GE.insert(V5, V2, int.Parse(fee.Text));
                }
                else if (to.Text == "V6")
                {
                    GE.insert(V5, V6, int.Parse(fee.Text));
                }
            }
            else if (from.Text == "V6")
            {
                if (to.Text == "V1")
                {
                    GE.insert(V6, V1, int.Parse(fee.Text));
                }
                else if (to.Text == "V3")
                {
                    GE.insert(V6, V3, int.Parse(fee.Text));
                }
                else if (to.Text == "V4")
                {
                    GE.insert(V6, V4, int.Parse(fee.Text));
                }
                else if (to.Text == "V5")
                {
                    GE.insert(V6, V5, int.Parse(fee.Text));
                }
                else if (to.Text == "V2")
                {
                    GE.insert(V6, V2, int.Parse(fee.Text));
                }
            }
        }
        public void searchGN(object sender, RoutedEventArgs e)
        {
            RES.IsVisible = true;
            defCLose1.IsVisible = false;
            defCLose2.IsVisible = false;
            searchIG.IsVisible= true;
            GE.search(SV.Text);
            if (GE.searchedValue != "")
            {
                SGR.Text = "VALUE FOUND: " + GE.searchedValue;
            }
            else {
                SGR.Text = "THIS VALUE WASN'T FOUND";
            }
        }
        public void bfs_dfs(object sender, RoutedEventArgs e)
        {
            RES.IsVisible = true;
            defCLose1.IsVisible = false;
            defCLose2.IsVisible = false;
            BDR.IsVisible = true;
            GE.bfs(V1);
            GE.dfs(V1);
            BFS.Text = GE.BFSLS;
            DFS.Text = GE.DFSLS;
        }
        public void shortest(object sender, RoutedEventArgs e)
        {
            RES.IsVisible = true;
            defCLose1.IsVisible = false;
            defCLose2.IsVisible = false;
            SPG.IsVisible = true;
            if (fromSP.Text == "V1")
            {
                if (toSP.Text == "V2")
                {
                    GE.shortestPath(V1, V2);
                }
                else if (toSP.Text == "V3")
                {
                    GE.shortestPath(V1, V3);
                }
                else if (toSP.Text == "V4")
                {
                    GE.shortestPath(V1, V4);
                }
                else if (toSP.Text == "V5")
                {
                    GE.shortestPath(V1, V5);
                }
                else if (toSP.Text == "V6")
                {
                    GE.shortestPath(V1, V6);
                }
            }
            else if (fromSP.Text == "V2")
            {
                if (toSP.Text == "V1")
                {
                    GE.shortestPath(V2, V1);
                }
                else if (toSP.Text == "V3")
                {
                    GE.shortestPath(V2, V3);
                }
                else if (toSP.Text == "V4")
                {
                    GE.shortestPath(V2, V4);
                }
                else if (toSP.Text == "V5")
                {
                    GE.shortestPath(V2, V5);
                }
                else if (toSP.Text == "V6")
                {
                    GE.shortestPath(V2, V6);
                }
            }
            else if (fromSP.Text == "V3")
            {
                if (toSP.Text == "V1")
                {
                    GE.shortestPath(V3, V1);
                }
                else if (toSP.Text == "V2")
                {
                    GE.shortestPath(V3, V2);
                }
                else if (toSP.Text == "V4")
                {
                    GE.shortestPath(V3, V4);
                }
                else if (toSP.Text == "V5")
                {
                    GE.shortestPath(V3, V5);
                }
                else if (toSP.Text == "V6")
                {
                    GE.shortestPath(V3, V6);
                }
            }
            else if (fromSP.Text == "V4")
            {
                if (toSP.Text == "V4")
                {
                    GE.shortestPath(V4, V1);
                }
                else if (toSP.Text == "V3")
                {
                    GE.shortestPath(V4, V3);
                }
                else if (toSP.Text == "V2")
                {
                    GE.shortestPath(V4, V2);
                }
                else if (toSP.Text == "V5")
                {
                    GE.shortestPath(V4, V5);
                }
                else if (toSP.Text == "V6")
                {
                    GE.shortestPath(V4, V6);
                }
            }
            else if (fromSP.Text == "V5")
            {
                if (toSP.Text == "V1")
                {
                    GE.shortestPath(V5, V1);
                }
                else if (toSP.Text == "V3")
                {
                    GE.shortestPath(V5, V3);
                }
                else if (toSP.Text == "V4")
                {
                    GE.shortestPath(V5, V4);
                }
                else if (toSP.Text == "V2")
                {
                    GE.shortestPath(V5, V2);
                }
                else if (toSP.Text == "V6")
                {
                    GE.shortestPath(V5, V6);
                }
            }
            else if (fromSP.Text == "V6")
            {
                if (toSP.Text == "V1")
                {
                    GE.shortestPath(V6, V1);
                }
                else if (toSP.Text == "V3")
                {
                    GE.shortestPath(V6, V3);
                }
                else if (toSP.Text == "V4")
                {
                    GE.shortestPath(V6, V4);
                }
                else if (toSP.Text == "V5")
                {
                    GE.shortestPath(V6, V5);
                }
                else if (toSP.Text == "V2")
                {
                    GE.shortestPath(V6, V2);
                }
            }
            SPGR.Text = GE.SPLS;
            SPGR2.Text = GE.SPLS2;
        }
        public void printGraph(object sender, RoutedEventArgs e)
        {
            RES.IsVisible = true;
            defCLose1.IsVisible = false;
            defCLose2.IsVisible = false;
            PG.IsVisible = true;
            GE.printVertexes();
            PGR.Text = GE.VLS;
            GE.matrix();
            M1.Text = GE.M1S;
            M2.Text = GE.M2S;
            M3.Text = GE.M3S;
            M4.Text = GE.M4S;
            M5.Text = GE.M5S;
            M6.Text = GE.M6S;
            M7.Text = GE.M7S;
        }
        public void closeRes(object sender, RoutedEventArgs e)
        {
            RES.IsVisible = false;
            defCLose1.IsVisible = true;
            defCLose2.IsVisible = true;
            SNT.IsVisible = false;
            PT.IsVisible = false;
            searchIG.IsVisible = false;
            PG.IsVisible = false;
            binaryTree.IOT.Clear();
            binaryTree.PT.Clear();
            binaryTree.POT.Clear();
            GE.VL.Clear();
            GE.searchedValue = "";
            GE.BFSL.Clear();
            GE.DFSL.Clear();
            BDR.IsVisible=false;
            SPG.IsVisible= false;
        }
        public void exit(object sender, RoutedEventArgs e)
        {
            UI.Close();
        }
    }
}