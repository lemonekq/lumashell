using System.Diagnostics;
using System.Windows;

namespace lumashell
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            this.Top = 0; this.Left = 0;
            this.Height = SystemParameters.PrimaryScreenHeight;
            this.Width = SystemParameters.PrimaryScreenWidth;

            // process.Kill doesnt kill the tree
            Process.Start("taskkill", "/F /IM explorer.exe");

            taskbarhandler.Width = SystemParameters.PrimaryScreenWidth - 80;
        }
    }
}
