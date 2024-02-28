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
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string filePath = @"path/books-data.txt";

            List<Book> list = new List<Book>();
            BookWriteRead bookWriteRead = new BookWriteRead();
            list = bookWriteRead.Read(filePath);

            foreach (Book b in list)
            {
                if (textBox1.Text == b.nameOfBook)
                {
                    comboBox1.Items.Clear();
                    comboBox1.Items.Add(b.nameOfBook);
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
