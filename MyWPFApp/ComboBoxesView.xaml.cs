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
    /// Interaction logic for ComboBoxesView.xaml
    /// </summary>
    public partial class ComboBoxesView : Window
    {
        public ComboBoxesView()
        {
            InitializeComponent();

            //ComboBoxesViewModel vm = new ComboBoxesViewModel();
            //this.DataContext = vm;
        }

        private void BtnMainwindow_Click(object sender, RoutedEventArgs e)
        {
            MainWindow2 mainWindow2 = new MainWindow2();
            mainWindow2.Show();
            this.Close();
        }
    }
}
