using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace library
{
    public partial class adminPanelForm : Form
    {
        public adminPanelForm()
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
            listOfMembers form1 = new listOfMembers();
            form1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            addBook addbook = new addBook();
            addbook.Show();

            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listOfBooks listOfBooks = new listOfBooks();
            listOfBooks.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            addShelf addshelf = new addShelf();
            addshelf.Show();

            this.Hide();
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            loginForm loginform = new loginForm();
            loginform.Show();
            this.Hide();
        }
    }
}
