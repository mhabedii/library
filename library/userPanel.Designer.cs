namespace library
{
    partial class userPanel
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            button4 = new Button();
            button1 = new Button();
            tabPage2 = new TabPage();
            button3 = new Button();
            button2 = new Button();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(14, 16);
            tabControl1.Margin = new Padding(3, 4, 3, 4);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(971, 584);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = SystemColors.ScrollBar;
            tabPage1.Controls.Add(button4);
            tabPage1.Controls.Add(button1);
            tabPage1.ForeColor = SystemColors.ScrollBar;
            tabPage1.Location = new Point(4, 35);
            tabPage1.Margin = new Padding(3, 4, 3, 4);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3, 4, 3, 4);
            tabPage1.Size = new Size(963, 545);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "نمایه";
            // 
            // button4
            // 
            button4.BackColor = SystemColors.ControlDarkDark;
            button4.Location = new Point(731, 473);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(201, 38);
            button4.TabIndex = 1;
            button4.Text = "بازگشت به صفحهٔ ورود";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ControlDarkDark;
            button1.Location = new Point(421, 243);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(106, 38);
            button1.TabIndex = 0;
            button1.Text = "ویرایش نمایه";
            button1.UseVisualStyleBackColor = false;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = SystemColors.ScrollBar;
            tabPage2.Controls.Add(button3);
            tabPage2.Controls.Add(button2);
            tabPage2.ForeColor = SystemColors.ScrollBar;
            tabPage2.Location = new Point(4, 35);
            tabPage2.Margin = new Padding(3, 4, 3, 4);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3, 4, 3, 4);
            tabPage2.Size = new Size(963, 545);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "کتاب‌ها";
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ControlDarkDark;
            button3.Location = new Point(375, 264);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(178, 38);
            button3.TabIndex = 1;
            button3.Text = "قرض گرفتن کتاب";
            button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ControlDarkDark;
            button2.Location = new Point(375, 218);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(178, 38);
            button2.TabIndex = 0;
            button2.Text = "جست‌وجو در کتاب‌ها";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // userPanel
            // 
            AutoScaleDimensions = new SizeF(9F, 26F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(998, 615);
            Controls.Add(tabControl1);
            Font = new Font("Vazirmatn", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 4, 3, 4);
            Name = "userPanel";
            Text = "صفحهٔ کاربر";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Button button1;
        private Button button3;
        private Button button2;
        private Button button4;
    }
}