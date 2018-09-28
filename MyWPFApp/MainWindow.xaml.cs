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
            MessageBox.Show("I'm an Ellipse button");
        }

        private void btnDataContextDemo_Click(object sender, RoutedEventArgs e)
        {
            DataContextDemo dataContextDemo = new DataContextDemo();
            dataContextDemo.Show();
            this.Close();
        }

        private void btnFirstWPFform_Click(object sender, RoutedEventArgs e)
        {
            FirstWPFform firstWPFform = new FirstWPFform();
            firstWPFform.Show();
            this.Close();
        }

        private void btnRoutedEvents_Click(object sender, RoutedEventArgs e)
        {
            MyRoutedEvents myRoutedEvents = new MyRoutedEvents();
            myRoutedEvents.Show();
            this.Close();
        }

        private void btnCustomDepProp_Click(object sender, RoutedEventArgs e)
        {
            CustomDependencyProp customDependencyProp = new CustomDependencyProp();
            customDependencyProp.Show();
            this.Close();
        }
    }
}
