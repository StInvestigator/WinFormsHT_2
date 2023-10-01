namespace WinFormsHT_2
{
    public partial class Form1 : Form
    {
        int Count = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void TBTextChanged(object sender, EventArgs e)
        {
            if (TBSurname.Text != "" && TBName.Text != "" && TBFathersName.Text != "" && TBFamilyStatus.Text != "" && TBAdditionalInfo.Text != "" && DTPDateOfBirth.Value < DateTime.Today)
            {
                BSaveToFile.Enabled = true;
            }
        }

        private void BSaveClick(object sender, MouseEventArgs e)
        {
            if (TBSurname.Text != "" && TBName.Text != "" && TBFathersName.Text != "" && TBFamilyStatus.Text != "" && TBAdditionalInfo.Text != "" && DTPDateOfBirth.Value < DateTime.Today)
            {
                if (!Directory.Exists("SavedFiles"))
                {
                    Directory.CreateDirectory("SavedFiles");
                }
                FileStream f = new FileStream($"SavedFiles/SavedData{++Count}.txt", FileMode.Create);
                StreamWriter sw = new StreamWriter(f);
                sw.WriteLine($"Surname - {TBSurname.Text}\nName - {TBName.Text}\nFathers name - {TBFathersName.Text}\n" +
                    $"Date of birth - {DTPDateOfBirth.Value.Day}.{DTPDateOfBirth.Value.Month}.{DTPDateOfBirth.Value.Year}\n" +
                    $"Family status - {TBFamilyStatus.Text}\nAdditional information - {TBAdditionalInfo.Text}");
                sw.Close();
                MessageBox.Show("File was created!","Success!",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                BSaveToFile.Enabled = false;
                MessageBox.Show("Some fields are filled in a wrong way!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}