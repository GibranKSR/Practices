using Avalonia.Controls;
using Avalonia.Interactivity;

namespace MyApp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public void exit(object sender, RoutedEventArgs e)
        {
            UI.Close();
        }
        public void iniTree(object sender, RoutedEventArgs e)
        {
            UI1.IsVisible = false;
            UI2.IsVisible = true;
        }

        public void iniGraph(object sender, RoutedEventArgs e)
        {
            UI1.IsVisible = false;
            UI3.IsVisible = true;
        }

        public void addNode(object sender, RoutedEventArgs e)
        {
            UI1.IsVisible = false;
            UI3.IsVisible = true;
        }
        public void addGN(object sender, RoutedEventArgs e)
        {
            UI3.IsVisible = false;
            UI3_2.IsVisible = true;
        }
    }
}