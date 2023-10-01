namespace WinFormsHT_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void OnTextChanged(object sender, EventArgs e)
        {
            if (TBDay.Text.Length > 2)
            {
                TBDay.Text = "";
                MessageBox.Show("Wrong input!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (TBMonth.Text.Length > 2)
            {
                TBMonth.Text = "";
                MessageBox.Show("Wrong input!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (TBYear.Text.Length > 4)
            {
                TBYear.Text = "";
                MessageBox.Show("Wrong input!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (TBDay.Text.Length != 0 && TBMonth.Text.Length != 0 && TBYear.Text.Length == 4)
            {
                try
                {
                    DateTime d = new DateTime(Convert.ToInt32(TBYear.Text), Convert.ToInt32(TBMonth.Text), Convert.ToInt32(TBDay.Text));
                    MCResult.SelectionStart = d;
                    MCResult.SelectionEnd = d;
                }
                catch
                {
                    TBDay.Text = "";
                    TBMonth.Text = "";
                    TBYear.Text = "";
                    MessageBox.Show("Wrong date!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}