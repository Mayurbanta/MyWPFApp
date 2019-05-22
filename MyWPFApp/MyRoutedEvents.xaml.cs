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
using System.Windows.Shapes;

namespace MyWPFApp
{
    /// <summary>
    /// Interaction logic for MyRoutedEvents.xaml
    /// </summary>
    public partial class MyRoutedEvents : Window
    {
        public MyRoutedEvents()
        {
            InitializeComponent();
        }

        private void btnClickMe_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("I am outer button!");
        }
        
        private void OuterEllipse_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("I am Green Ellipse!");
        }

        private void InnButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("I am inner button!");
        }

        private void BacktoMainWindow_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }
    }
}
