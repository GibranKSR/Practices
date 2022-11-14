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
            //////////////////////////////////////////////////////
            ///////////////////////////////////////////////////
            /////////////////////////////////////////////
            ///////////////////////////////////////
            RES.IsVisible = true;
            PT.IsVisible= true;
            defCLose1.IsVisible = false;
            defCLose2.IsVisible = false;
            PTR1.Text = "TREE (HEIGHT ->" + binaryTree.Height() + "<-)";
            PTR2.Text = "In Order Traversal (Left->Root->Right): ";
            PTR3.Text = "Pre Order Traversal (Root->Left->Right): ";
            PTR4.Text = "Post Order Traversal (Left->Right->Root): ";

            binaryTree.InOrderTraversal();
            binaryTree.PreorderTraversal();
            binaryTree.PostorderTraversal();
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
            V7.data = GN7.Text;
            V8.data = GN8.Text;
            V9.data = GN9.Text;
            GE.insert(V1, V1, 0);
        }
        public void addEdge(object sender, RoutedEventArgs e)
        {
            ///////////////////////////////////////////////////////
            ///////////////////////////////////////////////////
            /////////////////////////////////////////////
            ///////////////////////////////////////
            Vertex VT = from.Text;
            GE.insert(from.Text, to.Text, int.Parse(fee.Text));
        }
        public void searchGN(object sender, RoutedEventArgs e)
        {
            RES.IsVisible = true;
            defCLose1.IsVisible = false;
            defCLose2.IsVisible = false;
        }
        public void bfs_dfs(object sender, RoutedEventArgs e)
        {
            RES.IsVisible = true;
            defCLose1.IsVisible = false;
            defCLose2.IsVisible = false;
        }
        public void shortest(object sender, RoutedEventArgs e)
        {
            RES.IsVisible = true;
            defCLose1.IsVisible = false;
            defCLose2.IsVisible = false;
        }
        public void printGraph(object sender, RoutedEventArgs e)
        {
            RES.IsVisible = true;
            defCLose1.IsVisible = false;
            defCLose2.IsVisible = false;
            PG.IsVisible = true;
        }
        public void closeRes(object sender, RoutedEventArgs e)
        {
            RES.IsVisible = false;
            defCLose1.IsVisible = true;
            defCLose2.IsVisible = true;
            SNT.IsVisible = false;
            PT.IsVisible = false;
            PG.IsVisible = false;
        }
        public void exit(object sender, RoutedEventArgs e)
        {
            UI.Close();
        }
    }
}