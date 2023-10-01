using System.Drawing;

namespace WinFormsHT_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();  
        }
        private void DTPValueChanged(object sender, EventArgs e)
        {
            if (DTP1.Value > DTP2.Value)
            {
                LResult.Text = Math.Round((DTP1.Value - DTP2.Value).TotalDays, 2).ToString();
            }
            else
            {
                LResult.Text = "0";
            }
        }
    }
}