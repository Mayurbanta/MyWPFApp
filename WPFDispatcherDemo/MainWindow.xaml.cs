using System.Threading;
using System.Windows;

namespace WPFDispatcherDemo
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

        private void myButton_Click(object sender, RoutedEventArgs e)
        {
            Thread t = new Thread(new ThreadStart(SetText));
            t.Start();
        }

        private void SetText()
        {
            this.Dispatcher.Invoke(() => { myTextBlock.Text = "Set by Dispatcher"; });
        }
    }
}
