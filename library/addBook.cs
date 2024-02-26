using System;
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
    public partial class addBook : Form
    {
        public addBook()
        {
            InitializeComponent();
            contentOfCombobox1();
        }

        private void contentOfCombobox1()
        {
            string filePath = @"path/shelfs.txt";

            List<Shelf> list = new List<Shelf>();
            ShelfWriteRead shelfWriteRead = new ShelfWriteRead();
            list = shelfWriteRead.Read(filePath);

            foreach (Shelf sh in list)
            {
                comboBox1.Items.Add(sh.nameOfShelf);
                /*comboBox1.Text += sh.nameOfShelf + "      ";*/
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string filePath = "path/books-data.txt";

            string textOfName = textBox1.Text;
            string textOfCode = textBox2.Text;
            string textOfAuthor = textBox3.Text;
            string textOfPublisher = textBox4.Text;

            /*string selectedCategory = comboBox1.SelectedItem.ToString();*/

            if (string.IsNullOrEmpty(textOfName) || string.IsNullOrEmpty(textOfCode) || string.IsNullOrEmpty(textOfAuthor) || string.IsNullOrEmpty(textOfPublisher))
            {
                MessageBox.Show("لطفاً همهٔ موارد را پر کنید.");
                return;
            }

            Book book = new Book
            {
                nameOfBook = textBox1.Text,
                codeOfBook = textBox2.Text,
                authorOfBook = textBox3.Text,
                publisherOfBook = textBox4.Text,
                categoryOfBook = comboBox1.SelectedItem.ToString(),
            };
            BookWriteRead bookWriteRead = new BookWriteRead();
            bookWriteRead.bookWrite(book, filePath);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            adminPanelForm adminpanelform = new adminPanelForm();
            adminpanelform.Show();

            this.Hide();
        }
    }
}
