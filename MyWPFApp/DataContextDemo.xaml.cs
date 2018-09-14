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
    /// Interaction logic for DataContextDemo.xaml
    /// </summary>
    public partial class DataContextDemo : Window
    {
        public DataContextDemo()
        {
            InitializeComponent();

            Person person = new Person
            {
                FirstName = "Mayur",
                LastName = "Banta",
                Age = 34
            };

            this.DataContext = person;
        }

        private void BacktoMainWindow_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }
    }

    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
    }
}
