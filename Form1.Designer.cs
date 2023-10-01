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
            BChooseDate = new Button();
            label1 = new Label();
            LResultDate = new Label();
            DTP = new DateTimePicker();
            SuspendLayout();
            // 
            // BChooseDate
            // 
            BChooseDate.Font = new Font("Segoe UI", 18F, FontStyle.Italic, GraphicsUnit.Point);
            BChooseDate.Location = new Point(274, 56);
            BChooseDate.Name = "BChooseDate";
            BChooseDate.Size = new Size(190, 63);
            BChooseDate.TabIndex = 0;
            BChooseDate.Text = "Choose the date";
            BChooseDate.UseVisualStyleBackColor = true;
            BChooseDate.MouseClick += OnMouseClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 21.75F, FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(194, 173);
            label1.Name = "label1";
            label1.Size = new Size(178, 40);
            label1.TabIndex = 1;
            label1.Text = "Chosen date:";
            // 
            // LResultDate
            // 
            LResultDate.AutoSize = true;
            LResultDate.Font = new Font("Segoe UI", 21.75F, FontStyle.Italic, GraphicsUnit.Point);
            LResultDate.Location = new Point(368, 173);
            LResultDate.Name = "LResultDate";
            LResultDate.Size = new Size(0, 40);
            LResultDate.TabIndex = 2;
            // 
            // DTP
            // 
            DTP.Location = new Point(274, 255);
            DTP.Name = "DTP";
            DTP.Size = new Size(190, 23);
            DTP.TabIndex = 3;
            DTP.ValueChanged += OnValueChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(DTP);
            Controls.Add(LResultDate);
            Controls.Add(label1);
            Controls.Add(BChooseDate);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateTimePicker1;
        private Button BChooseDate;
        private Label label1;
        private Label LResultDate;
        private DateTimePicker DTP;
    }
}