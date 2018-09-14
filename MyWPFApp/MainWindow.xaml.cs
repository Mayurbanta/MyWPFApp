using System.Windows;

namespace MyWPFApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window_layoutDemo win2 = new Window_layoutDemo();
            win2.Show();
            this.Close();
        }

        private void btnDataBinding_Click(object sender, RoutedEventArgs e)
        {
            DataBindingDemo dataBindingDemo = new DataBindingDemo();
            dataBindingDemo.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("I am Ellipse button");
        }
    }
}
