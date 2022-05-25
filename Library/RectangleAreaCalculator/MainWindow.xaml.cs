using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace RectangleAreaCalculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
    public MainWindow()
        {
            InitializeComponent();
            var colorList = new List<string>() {
                "Black",
                "Red",
                "Green",
                "Blue"
            };
            colors.ItemsSource = colorList;
        }

        private void submitBtn_Click(object sender, RoutedEventArgs e)
        {
            var area = Convert.ToInt32(lenghtA.Text) * Convert.ToInt32(lenghtB.Text);
            result.Text = $"Pole równa się: {area}";
        }

        private void colors_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string selected = (string)this.colors.SelectedItem;
            MessageBox.Show(selected);
        }
    }
}
