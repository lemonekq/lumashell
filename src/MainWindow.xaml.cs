using System.Windows;
using System.Windows.Forms;

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
            foreach (Screen DesktopScreen in LocalMemory.Screens)
            {
                Desktop WorkingDesktop = new Desktop();

                LocalMemory.DesktopParams_Position[0] = DesktopScreen.WorkingArea.Left;     //   X
                LocalMemory.DesktopParams_Position[1] = DesktopScreen.WorkingArea.Top;      //   Y

                LocalMemory.DesktopParams_Size[0] = DesktopScreen.Bounds.Height;  //   Height
                LocalMemory.DesktopParams_Size[1] = DesktopScreen.Bounds.Width;   //   Width

                WorkingDesktop.Show();
            }

            this.Hide();
        }
    }
}
