using System.Windows;

namespace lumashell
{
    public partial class Desktop : Window
    {
        public Desktop()
        {
            InitializeComponent();
        }

        private void DesktopConfigure(object sender, RoutedEventArgs e)
        {
            this.Left = LocalMemory.DesktopParams_Position[0];
            this.Top = LocalMemory.DesktopParams_Position[1];
            this.Height = LocalMemory.DesktopParams_Size[0];
            this.Width = LocalMemory.DesktopParams_Size[1];
        }
    }
}
