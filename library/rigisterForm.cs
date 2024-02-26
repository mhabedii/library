using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace library
{
    public partial class registerForm : Form
    {
        public registerForm()
        {
            InitializeComponent();
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            string textOfFirstName = firstName.Text;
            string textOfLastName = lastName.Text;
            string textOfUserName = userName.Text;
            string textOfPassword = password.Text;
            string textOfEmail = email.Text;
            string textOfPhoneNumber = phoneNumber.Text;
            string textOfAge = age.Text;
            string textOfNationalId = nationalId.Text;

            string filePath = "path/users-data.txt";

            if (string.IsNullOrEmpty(textOfFirstName) || string.IsNullOrEmpty(textOfLastName) || string.IsNullOrEmpty(textOfUserName) || string.IsNullOrEmpty(textOfPassword) || string.IsNullOrEmpty(textOfEmail) || string.IsNullOrEmpty(textOfPhoneNumber) || string.IsNullOrEmpty(textOfAge) || string.IsNullOrEmpty(textOfNationalId))
            {
                MessageBox.Show("لطفاً همهٔ موارد را پر کنید.");
                return;
            }

            Manager manager = new Manager
            {
                textOfFirstName = firstName.Text,
                textOfLastName = lastName.Text,
                textOfUserName = userName.Text,
                textOfPassword = password.Text,
                textOfEmail = email.Text,
                textOfPhoneNumber = phoneNumber.Text,
                textOfAge = age.Text,
                textOfNationalId = nationalId.Text
            };
            FileWriteRead fileWriteRead = new FileWriteRead();
            fileWriteRead.Write(manager, filePath);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loginForm loginform = new loginForm();
            loginform.Show();

            this.Hide();
        }
    }
}
