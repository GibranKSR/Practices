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
    }
}