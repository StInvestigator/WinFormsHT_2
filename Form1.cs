

namespace WinFormsHT_2
{
    using System.Runtime.InteropServices;
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void OnMouseClick(object sender, MouseEventArgs e)
        {
            DTP.Open();
        }

        private void OnValueChanged(object sender, EventArgs e)
        {
            LResultDate.Text = DTP.Text.ToString();
        }
    }
    public static class Extensions
    {
        [DllImport("user32.dll", SetLastError = true)]
        private static extern int SendMessage(IntPtr hWnd, uint Msg, int wParam, int lParam);

        private const uint WM_SYSKEYDOWN = 0x104;

        public static void Open(this DateTimePicker obj)
        {
            SendMessage(obj.Handle, WM_SYSKEYDOWN, (int)Keys.Down, 0);
        }
    }
}