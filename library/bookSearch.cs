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
    public partial class bookSearch : Form
    {
        public bookSearch()
        {
            InitializeComponent();
            clearLabel3Content();
        }

        private void clearLabel3Content()
        {
            label3.Text = string.Empty;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string filePath = @"path/books-data.txt";

            List<Book> list = new List<Book>();
            BookWriteRead bookWriteRead = new BookWriteRead();
            list = bookWriteRead.Read(filePath);

            foreach (Book b in list)
            {
                if (Convert.ToString(textBox1.Text) == Convert.ToString(b.nameOfBook))
                {
                    label3.Text = "موجود است";
                    break;
                }
                else
                {
                    label3.Text = "موجود نیست";
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            userPanel userpanel = new userPanel();
            userpanel.Show();
        }
    }
}
