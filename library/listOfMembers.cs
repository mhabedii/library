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
            loadDataOnDataGridView1();
            dataGridRtoL();
        }

        private void dataGridRtoL()
        {
            dataGridView1.RightToLeft = RightToLeft.Yes;
        }

        private void loadDataOnDataGridView1()
        {
            string filePath = @"path/users-data.txt";

            List<Manager> list = new List<Manager>();
            FileWriteRead fileWriteRead = new FileWriteRead();
            list = fileWriteRead.Read(filePath);

            DataGridViewTextBoxColumn firstNameColumn = new DataGridViewTextBoxColumn();
            firstNameColumn.HeaderText = "نام";
            firstNameColumn.DataPropertyName = "textOfFirstName";
            dataGridView1.Columns.Add(firstNameColumn);

            DataGridViewTextBoxColumn textOfLastName = new DataGridViewTextBoxColumn();
            textOfLastName.HeaderText = "نام خانوادگی";
            textOfLastName.DataPropertyName = "textOfLastName";
            dataGridView1.Columns.Add(textOfLastName);

            DataGridViewTextBoxColumn textOfUserName = new DataGridViewTextBoxColumn();
            textOfUserName.HeaderText = "نام کاربری";
            textOfUserName.DataPropertyName = "textOfUserName";
            dataGridView1.Columns.Add(textOfUserName);

            DataGridViewTextBoxColumn textOfPassword = new DataGridViewTextBoxColumn();
            textOfPassword.HeaderText = "گذرواژه";
            textOfPassword.DataPropertyName = "textOfPassword";
            dataGridView1.Columns.Add(textOfPassword);

            DataGridViewTextBoxColumn textOfEmail = new DataGridViewTextBoxColumn();
            textOfEmail.HeaderText = "رایانامه";
            textOfEmail.DataPropertyName = "textOfEmail";
            dataGridView1.Columns.Add(textOfEmail);

            DataGridViewTextBoxColumn textOfPhoneNumber = new DataGridViewTextBoxColumn();
            textOfPhoneNumber.HeaderText = "شمارهٔ تلفن همراه";
            textOfPhoneNumber.DataPropertyName = "textOfPhoneNumber";
            dataGridView1.Columns.Add(textOfPhoneNumber);

            DataGridViewTextBoxColumn textOfAge = new DataGridViewTextBoxColumn();
            textOfAge.HeaderText = "سن";
            textOfAge.DataPropertyName = "textOfAge";
            dataGridView1.Columns.Add(textOfAge);

            DataGridViewTextBoxColumn textOfNationalId = new DataGridViewTextBoxColumn();
            textOfNationalId.HeaderText = "شناسهٔ ملی";
            textOfNationalId.DataPropertyName = "textOfNationalId";
            dataGridView1.Columns.Add(textOfNationalId);

            dataGridView1.DataSource = list;
        }
    }
}
