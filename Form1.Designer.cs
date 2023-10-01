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
            DTP1 = new DateTimePicker();
            DTP2 = new DateTimePicker();
            LResult = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // DTP1
            // 
            DTP1.CalendarFont = new Font("Segoe UI", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            DTP1.Location = new Point(37, 191);
            DTP1.Name = "DTP1";
            DTP1.Size = new Size(139, 23);
            DTP1.TabIndex = 0;
            DTP1.ValueChanged += DTPValueChanged;
            // 
            // DTP2
            // 
            DTP2.CalendarFont = new Font("Segoe UI", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            DTP2.Location = new Point(264, 191);
            DTP2.Name = "DTP2";
            DTP2.Size = new Size(142, 23);
            DTP2.TabIndex = 1;
            DTP2.ValueChanged += DTPValueChanged;
            // 
            // LResult
            // 
            LResult.AutoSize = true;
            LResult.Font = new Font("Segoe UI", 21.75F, FontStyle.Italic, GraphicsUnit.Point);
            LResult.Location = new Point(484, 184);
            LResult.Name = "LResult";
            LResult.Size = new Size(92, 40);
            LResult.TabIndex = 2;
            LResult.Text = "Result";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 27.75F, FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(202, 175);
            label2.Name = "label2";
            label2.Size = new Size(37, 50);
            label2.TabIndex = 3;
            label2.Text = "-";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 26.25F, FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(434, 177);
            label3.Name = "label3";
            label3.Size = new Size(44, 47);
            label3.TabIndex = 4;
            label3.Text = "=";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(568, 215);
            label4.Name = "label4";
            label4.Size = new Size(65, 32);
            label4.TabIndex = 5;
            label4.Text = "Days";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(LResult);
            Controls.Add(DTP2);
            Controls.Add(DTP1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateTimePicker1;
        private DateTimePicker DTP1;
        private DateTimePicker DTP2;
        private Label LResult;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}