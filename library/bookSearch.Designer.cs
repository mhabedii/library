namespace library
{
    partial class bookSearch
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox1 = new TextBox();
            label1 = new Label();
            button1 = new Button();
            label2 = new Label();
            button2 = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.ControlDarkDark;
            textBox1.ForeColor = SystemColors.ScrollBar;
            textBox1.Location = new Point(364, 218);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(134, 31);
            textBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(364, 189);
            label1.Name = "label1";
            label1.Size = new Size(134, 26);
            label1.TabIndex = 1;
            label1.Text = "نام کتاب را وارد کنید";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ControlDarkDark;
            button1.ForeColor = SystemColors.ScrollBar;
            button1.Location = new Point(364, 268);
            button1.Name = "button1";
            button1.Size = new Size(134, 29);
            button1.TabIndex = 2;
            button1.Text = "جست‌و‌جو";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ControlDarkDark;
            label2.Location = new Point(407, 349);
            label2.Name = "label2";
            label2.Size = new Size(44, 26);
            label2.TabIndex = 4;
            label2.Text = "نتیجه";
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ControlDarkDark;
            button2.ForeColor = SystemColors.ScrollBar;
            button2.Location = new Point(723, 544);
            button2.Name = "button2";
            button2.Size = new Size(165, 29);
            button2.TabIndex = 5;
            button2.Text = "بازگشت به صفحهٔ کاربر";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ControlDarkDark;
            label3.Location = new Point(390, 386);
            label3.Name = "label3";
            label3.Size = new Size(0, 26);
            label3.TabIndex = 6;
            // 
            // bookSearch
            // 
            AutoScaleDimensions = new SizeF(9F, 26F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            ClientSize = new Size(900, 585);
            Controls.Add(label3);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Font = new Font("Vazirmatn Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 4, 3, 4);
            Name = "bookSearch";
            Text = "جست‌وجوی کتاب";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private Button button1;
        private Label label2;
        private Button button2;
        private Label label3;
    }
}