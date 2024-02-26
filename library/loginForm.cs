using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace library
{
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string userNameInput = userBox.Text;
            string userPassInput = passBox.Text;
            /*MessageBox.Show(userPassInput);*/

            string filePath = "path/users-data.txt";

            string[] lines = File.ReadAllLines(filePath);

            /*bool userFound;*/
            FileWriteRead fileread = new FileWriteRead();
            List<Manager> list = fileread.Read(filePath);

            bool userFound = true;

            if (userBox.Text == "hesamtabesh" && passBox.Text == "1234")
            {
                adminPanelForm adminPanelForm = new adminPanelForm();
                adminPanelForm.Show();

                this.Hide();
                return;
            }

            foreach (Manager m in list)
            {
                if (m.textOfUserName == userBox.Text && m.textOfPassword == passBox.Text)
                {
                    userPanel userPanel = new userPanel();
                    userPanel.Show();

                    this.Hide();
                    return;
                }
                else
                {
                    userFound = false;
                }
            }

            if (userFound == false)
            {
                MessageBox.Show("نام کاربری یا گذرواژه اشتباه است");
            }


        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            registerForm form2 = new registerForm();
            form2.Show();

            this.Hide();
        }

        private void loginForm_Load(object sender, EventArgs e)
        {

        }
    }
}

