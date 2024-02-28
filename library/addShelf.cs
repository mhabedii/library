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
    public partial class addShelf : Form
    {
        public addShelf()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nameOfShelf = textBox1.Text;

            string filePath = "path/shelfs.txt";

            if (string.IsNullOrEmpty(nameOfShelf))
            {
                MessageBox.Show("لطفا نام قفسه را بنویسید");
                return;
            }

            Shelf shelf = new Shelf()
            {
                nameOfShelf = textBox1.Text
            };
        
            ShelfWriteRead shelfwriteread = new ShelfWriteRead(); 
            shelfwriteread.Write(shelf, filePath);

            this.Close();
            adminPanelForm adminpanelform = new adminPanelForm();
            adminpanelform.Show();

        }
    }
}
