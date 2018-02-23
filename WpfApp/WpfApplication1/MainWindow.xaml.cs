using System.Windows;

namespace WpfApplication1
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

        private void HelloBtn_Click(object sender, RoutedEventArgs e)
        {
            textfld.Text = "Hello";
        }

        private void ByeBtn_Click(object sender, RoutedEventArgs e)
        {
            textfld.Text = "Bye Bye!";
        }
    }
}
