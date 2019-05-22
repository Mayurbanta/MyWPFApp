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
    /// Interaction logic for IDataErrorInfoWindow.xaml
    /// </summary>
    public partial class IDataErrorInfoWindow : Window
    {
        public IDataErrorInfoWindow()
        {
            InitializeComponent();
        }

        private void BtnMainWindow_Click(object sender, RoutedEventArgs e)
        {
            MainWindow2 mainWindow2 = new MainWindow2();
            mainWindow2.Show();
        }
    }
}
