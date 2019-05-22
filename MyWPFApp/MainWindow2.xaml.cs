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
    /// Interaction logic for MainWindow2.xaml
    /// </summary>
    public partial class MainWindow2 : Window
    {
        public MainWindow2()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DataTemplateWindow dataTemplateWindow = new DataTemplateWindow();
            dataTemplateWindow.Show();
            this.Close();
        }

        private void BtnIDataErrorInfo_Click(object sender, RoutedEventArgs e)
        {
            IDataErrorInfoWindow dataErrorInfoWindow = new IDataErrorInfoWindow();
            dataErrorInfoWindow.Show();
            this.Close();
        }

        private void BtnComboBoxes_Click(object sender, RoutedEventArgs e)
        {
            ComboBoxesView comboBoxesView = new ComboBoxesView();
            comboBoxesView.Show();
            this.Close();
        }
    }
}
