using System.DirectoryServices.ActiveDirectory;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Toszogatas
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Kirajzol(3);
        }
        void Kirajzol(int darab)
        {
            Grid grid = new Grid();
            double darabSzam = Math.Pow(darab, 2);
            
            grid.VerticalAlignment = VerticalAlignment.Center;
            grid.HorizontalAlignment = HorizontalAlignment.Center;
            this.AddChild(grid);


            for (int i = 0; i < darab; i++)
            {
                grid.ColumnDefinitions.Add(new ColumnDefinition());
            }

            for (int j = 0; j < darab; j++)
            {
                grid.RowDefinitions.Add(new RowDefinition());
            }

            for (int y = 1; y <= darabSzam; y++)
            {
                int id = grid.Children.Add(new Button());
                Button btn = grid.Children[id] as Button;
                btn.SetValue(Grid.RowProperty, y / darab);
                btn.SetValue(Grid.ColumnProperty, y % darab);
                btn.Content = y;
                btn.Name = "btn" + y.ToString();
                btn.Width = 100;
                btn.Height = 100;
                btn.Name = y.ToString();
            }
            grid.Children.RemoveAt(grid.Children.Count - 1);

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

      
    }
}