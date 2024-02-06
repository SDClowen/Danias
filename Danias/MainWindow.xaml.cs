using Danias.Plugins;
using System.Windows;
using System.Windows.Controls;

namespace Danias
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        PluginManager pluginManager;

        public MainWindow()
        {
            InitializeComponent();

            pluginManager = new();
            pluginManager.LoadAssemblies();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"{pluginManager.Extensions.Count} plugins are loaded in this section!");

            foreach (var item in pluginManager.Extensions)
            {
                var control = item.Value.View as UserControl;
                grid.Children.Add( control );
            }
        }
    }
}