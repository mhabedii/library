﻿using System;
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

            string fileName = "users-data.txt";
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "path");

            writeTextFile(fileName, path);
        }

        private void writeTextFile(string fileName, string path)
        {
            string fullPath = Path.Combine(path, fileName);

            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            if (!File.Exists(fullPath))
            {
                StreamWriter sw = File.CreateText(fullPath);
            }
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

            if (userBox.Text == "hasan" && passBox.Text == "hasan")
            {
                this.Hide();

                adminPanelForm adminPanelForm = new adminPanelForm();
                adminPanelForm.Show();

                return;
            }

            foreach (Manager m in list)
            {
                if (m.textOfUserName == userBox.Text && m.textOfPassword == passBox.Text)
                {
                    this.Hide();
                    userPanel userPanel = new userPanel();
                    userPanel.Show();


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

