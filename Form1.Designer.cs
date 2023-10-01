namespace WinFormsHT_2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            LSurname = new Label();
            LName = new Label();
            LFathersName = new Label();
            LDateOfBirth = new Label();
            LFamilyStatus = new Label();
            LAdditionalInfo = new Label();
            BSaveToFile = new Button();
            TBFamilyStatus = new TextBox();
            TBFathersName = new TextBox();
            TBName = new TextBox();
            TBSurname = new TextBox();
            DTPDateOfBirth = new DateTimePicker();
            TBAdditionalInfo = new TextBox();
            SuspendLayout();
            // 
            // LSurname
            // 
            LSurname.AutoSize = true;
            LSurname.Font = new Font("Segoe UI", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            LSurname.Location = new Point(41, 69);
            LSurname.Name = "LSurname";
            LSurname.Size = new Size(85, 25);
            LSurname.TabIndex = 0;
            LSurname.Text = "Surname";
            // 
            // LName
            // 
            LName.AutoSize = true;
            LName.Font = new Font("Segoe UI", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            LName.Location = new Point(41, 112);
            LName.Name = "LName";
            LName.Size = new Size(61, 25);
            LName.TabIndex = 1;
            LName.Text = "Name";
            // 
            // LFathersName
            // 
            LFathersName.AutoSize = true;
            LFathersName.Font = new Font("Segoe UI", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            LFathersName.Location = new Point(41, 157);
            LFathersName.Name = "LFathersName";
            LFathersName.Size = new Size(123, 25);
            LFathersName.TabIndex = 2;
            LFathersName.Text = "Fathers name";
            // 
            // LDateOfBirth
            // 
            LDateOfBirth.AutoSize = true;
            LDateOfBirth.Font = new Font("Segoe UI", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            LDateOfBirth.Location = new Point(41, 201);
            LDateOfBirth.Name = "LDateOfBirth";
            LDateOfBirth.Size = new Size(116, 25);
            LDateOfBirth.TabIndex = 3;
            LDateOfBirth.Text = "Date of birth";
            // 
            // LFamilyStatus
            // 
            LFamilyStatus.AutoSize = true;
            LFamilyStatus.Font = new Font("Segoe UI", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            LFamilyStatus.Location = new Point(41, 242);
            LFamilyStatus.Name = "LFamilyStatus";
            LFamilyStatus.Size = new Size(120, 25);
            LFamilyStatus.TabIndex = 4;
            LFamilyStatus.Text = "Family status";
            // 
            // LAdditionalInfo
            // 
            LAdditionalInfo.AutoSize = true;
            LAdditionalInfo.Font = new Font("Segoe UI", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            LAdditionalInfo.Location = new Point(41, 278);
            LAdditionalInfo.Name = "LAdditionalInfo";
            LAdditionalInfo.Size = new Size(133, 25);
            LAdditionalInfo.TabIndex = 5;
            LAdditionalInfo.Text = "Additional info";
            // 
            // BSaveToFile
            // 
            BSaveToFile.BackColor = Color.DarkRed;
            BSaveToFile.Enabled = false;
            BSaveToFile.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            BSaveToFile.ForeColor = SystemColors.ControlLightLight;
            BSaveToFile.Location = new Point(492, 148);
            BSaveToFile.Name = "BSaveToFile";
            BSaveToFile.Size = new Size(150, 94);
            BSaveToFile.TabIndex = 6;
            BSaveToFile.Text = "SAVE";
            BSaveToFile.UseVisualStyleBackColor = false;
            BSaveToFile.MouseClick += BSaveClick;
            // 
            // TBFamilyStatus
            // 
            TBFamilyStatus.Location = new Point(187, 247);
            TBFamilyStatus.Name = "TBFamilyStatus";
            TBFamilyStatus.Size = new Size(252, 23);
            TBFamilyStatus.TabIndex = 7;
            TBFamilyStatus.TextChanged += TBTextChanged;
            // 
            // TBFathersName
            // 
            TBFathersName.Location = new Point(187, 159);
            TBFathersName.Name = "TBFathersName";
            TBFathersName.Size = new Size(252, 23);
            TBFathersName.TabIndex = 8;
            TBFathersName.TextChanged += TBTextChanged;
            // 
            // TBName
            // 
            TBName.Location = new Point(187, 114);
            TBName.Name = "TBName";
            TBName.Size = new Size(252, 23);
            TBName.TabIndex = 9;
            TBName.TextChanged += TBTextChanged;
            // 
            // TBSurname
            // 
            TBSurname.Location = new Point(187, 71);
            TBSurname.Name = "TBSurname";
            TBSurname.Size = new Size(252, 23);
            TBSurname.TabIndex = 10;
            TBSurname.TextChanged += TBTextChanged;
            // 
            // DTPDateOfBirth
            // 
            DTPDateOfBirth.Location = new Point(187, 203);
            DTPDateOfBirth.Name = "DTPDateOfBirth";
            DTPDateOfBirth.Size = new Size(252, 23);
            DTPDateOfBirth.TabIndex = 11;
            DTPDateOfBirth.ValueChanged += TBTextChanged;
            // 
            // TBAdditionalInfo
            // 
            TBAdditionalInfo.Location = new Point(187, 283);
            TBAdditionalInfo.Name = "TBAdditionalInfo";
            TBAdditionalInfo.Size = new Size(252, 23);
            TBAdditionalInfo.TabIndex = 12;
            TBAdditionalInfo.TextChanged += TBTextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(704, 441);
            Controls.Add(TBAdditionalInfo);
            Controls.Add(DTPDateOfBirth);
            Controls.Add(TBSurname);
            Controls.Add(TBName);
            Controls.Add(TBFathersName);
            Controls.Add(TBFamilyStatus);
            Controls.Add(BSaveToFile);
            Controls.Add(LAdditionalInfo);
            Controls.Add(LFamilyStatus);
            Controls.Add(LDateOfBirth);
            Controls.Add(LFathersName);
            Controls.Add(LName);
            Controls.Add(LSurname);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateTimePicker1;
        private Label LSurname;
        private Label LName;
        private Label LFathersName;
        private Label LDateOfBirth;
        private Label LFamilyStatus;
        private Label LAdditionalInfo;
        private Button BSaveToFile;
        private TextBox TBFamilyStatus;
        private TextBox TBFathersName;
        private TextBox TBName;
        private TextBox TBSurname;
        private DateTimePicker DTPDateOfBirth;
        private TextBox TBAdditionalInfo;
    }
}