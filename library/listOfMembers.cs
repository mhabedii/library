using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace library
{
    public partial class listOfMembers : Form
    {
        public listOfMembers()
        {
            InitializeComponent();
            LoadFileContent();
        }

        private void LoadFileContent()
        {
            string filePath = @"path/users-data.txt";

            List<Manager> list = new List<Manager>();
            FileWriteRead fileWriteRead = new FileWriteRead();
            list = fileWriteRead.Read(filePath);

            foreach (Manager m in list)
            {
                richTextBox1.Text += m.textOfFirstName + "      ";
                richTextBox1.Text += m.textOfLastName + "       ";
                richTextBox1.Text += m.textOfUserName + "       ";
                richTextBox1.Text += m.textOfEmail + "      ";
                richTextBox1.Text += m.textOfPhoneNumber + "        ";
                richTextBox1.Text += m.textOfAge + "        ";
                richTextBox1.Text += m.textOfNationalId + "     " + Environment.NewLine;
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
