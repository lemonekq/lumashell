using System.Windows.Forms;

namespace lumashell
{
    internal class LocalMemory
    {
        public static Screen[] Screens = Screen.AllScreens;

        public static int[] DesktopParams_Position = { 0, 0 };
        public static int[] DesktopParams_Size = { 0, 0 };
    }
}
