namespace library
{
    partial class loginForm
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
            userBox = new TextBox();
            passBox = new TextBox();
            loginBtn = new Button();
            registerBtn = new Button();
            label3 = new Label();
            label4 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // userBox
            // 
            userBox.BackColor = SystemColors.ControlDarkDark;
            userBox.ForeColor = SystemColors.ScrollBar;
            userBox.Location = new Point(369, 199);
            userBox.Margin = new Padding(3, 4, 3, 4);
            userBox.Name = "userBox";
            userBox.Size = new Size(201, 31);
            userBox.TabIndex = 0;
            // 
            // passBox
            // 
            passBox.BackColor = SystemColors.ControlDarkDark;
            passBox.ForeColor = SystemColors.ScrollBar;
            passBox.Location = new Point(369, 242);
            passBox.Margin = new Padding(3, 4, 3, 4);
            passBox.Name = "passBox";
            passBox.Size = new Size(201, 31);
            passBox.TabIndex = 1;
            // 
            // loginBtn
            // 
            loginBtn.BackColor = SystemColors.ControlDarkDark;
            loginBtn.Font = new Font("Vazirmatn Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            loginBtn.ForeColor = SystemColors.ScrollBar;
            loginBtn.Location = new Point(411, 285);
            loginBtn.Margin = new Padding(3, 4, 3, 4);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(106, 40);
            loginBtn.TabIndex = 2;
            loginBtn.Text = "ورود";
            loginBtn.UseVisualStyleBackColor = false;
            loginBtn.Click += loginBtn_Click;
            // 
            // registerBtn
            // 
            registerBtn.BackColor = SystemColors.ControlDarkDark;
            registerBtn.Font = new Font("Vazirmatn Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            registerBtn.ForeColor = SystemColors.ScrollBar;
            registerBtn.Location = new Point(411, 421);
            registerBtn.Margin = new Padding(3, 4, 3, 4);
            registerBtn.Name = "registerBtn";
            registerBtn.Size = new Size(106, 38);
            registerBtn.TabIndex = 4;
            registerBtn.Text = "عضویت";
            registerBtn.UseVisualStyleBackColor = false;
            registerBtn.Click += registerBtn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Vazirmatn Black", 9F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ControlDarkDark;
            label3.Location = new Point(595, 203);
            label3.Name = "label3";
            label3.Size = new Size(72, 26);
            label3.TabIndex = 7;
            label3.Text = "نام کاربری";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Vazirmatn Black", 9F, FontStyle.Bold);
            label4.ForeColor = SystemColors.ControlDarkDark;
            label4.Location = new Point(595, 246);
            label4.Name = "label4";
            label4.Size = new Size(56, 26);
            label4.TabIndex = 8;
            label4.Text = "گذرواژه";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Vazirmatn Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(387, 384);
            label1.Name = "label1";
            label1.Size = new Size(142, 26);
            label1.TabIndex = 9;
            label1.Text = "حساب کاربری ندارید؟";
            // 
            // loginForm
            // 
            AutoScaleDimensions = new SizeF(9F, 26F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            ClientSize = new Size(997, 618);
            Controls.Add(label1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(registerBtn);
            Controls.Add(loginBtn);
            Controls.Add(passBox);
            Controls.Add(userBox);
            Font = new Font("Vazirmatn Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 4, 3, 4);
            Name = "loginForm";
            Text = "ورود";
            Load += loginForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox userBox;
        private TextBox passBox;
        private Button loginBtn;
        private Button registerBtn;
        private Label label3;
        private Label label4;
        private Label label1;
    }
}
