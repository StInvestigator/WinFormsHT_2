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
            TBDay = new TextBox();
            TBMonth = new TextBox();
            TBYear = new TextBox();
            label1 = new Label();
            label2 = new Label();
            MCResult = new MonthCalendar();
            SuspendLayout();
            // 
            // TBDay
            // 
            TBDay.Location = new Point(78, 45);
            TBDay.Name = "TBDay";
            TBDay.Size = new Size(57, 23);
            TBDay.TabIndex = 0;
            TBDay.TextChanged += OnTextChanged;
            // 
            // TBMonth
            // 
            TBMonth.Location = new Point(177, 45);
            TBMonth.Name = "TBMonth";
            TBMonth.Size = new Size(57, 23);
            TBMonth.TabIndex = 1;
            TBMonth.TextChanged += OnTextChanged;
            // 
            // TBYear
            // 
            TBYear.Location = new Point(276, 45);
            TBYear.Name = "TBYear";
            TBYear.Size = new Size(104, 23);
            TBYear.TabIndex = 2;
            TBYear.TextChanged += OnTextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 27.75F, FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(141, 29);
            label1.Name = "label1";
            label1.Size = new Size(30, 50);
            label1.TabIndex = 3;
            label1.Text = ".";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 27.75F, FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(240, 29);
            label2.Name = "label2";
            label2.Size = new Size(30, 50);
            label2.TabIndex = 4;
            label2.Text = ".";
            // 
            // MCResult
            // 
            MCResult.Location = new Point(424, 18);
            MCResult.Name = "MCResult";
            MCResult.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 300);
            Controls.Add(MCResult);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(TBYear);
            Controls.Add(TBMonth);
            Controls.Add(TBDay);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateTimePicker1;
        private TextBox TBDay;
        private TextBox TBMonth;
        private TextBox TBYear;
        private Label label1;
        private Label label2;
        private MonthCalendar MCResult;
    }
}