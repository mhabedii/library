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
    public partial class listOfBooks : Form
    {
        public listOfBooks()
        {
            InitializeComponent();
            loadFileContent();
        }

        private void loadFileContent()
        {
            string filePath = @"path/books-data.txt";

            List<Book> list = new List<Book>();
            BookWriteRead bookWriteRead = new BookWriteRead();
            list = bookWriteRead.Read(filePath);

            foreach (Book b in list)
            {
                richTextBox1.Text += b.nameOfBook + "      ";
                richTextBox1.Text += b.codeOfBook + "       ";
                richTextBox1.Text += b.authorOfBook + "       ";
                richTextBox1.Text += b.publisherOfBook + "     ";
                richTextBox1.Text += b.categoryOfBook + Environment.NewLine;
            }
        }
    }
}
