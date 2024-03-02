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
            loadDataOnDataGridView1();
            dataGridRtoL();
        }

        private void dataGridRtoL()
        {
            dataGridView1.RightToLeft = RightToLeft.Yes;
        }

        private void loadDataOnDataGridView1()
        {
            string filePath = @"path/books-data.txt";

            List<Book> list = new List<Book>();
            BookWriteRead bookWriteRead = new BookWriteRead();
            list = bookWriteRead.Read(filePath);

            DataGridViewTextBoxColumn nameColumn = new DataGridViewTextBoxColumn();
            nameColumn.HeaderText = "نام کتاب";
            nameColumn.DataPropertyName = "nameOfBook";
            dataGridView1.Columns.Add(nameColumn);

            DataGridViewTextBoxColumn codeColumn = new DataGridViewTextBoxColumn();
            codeColumn.HeaderText = "کد کتاب";
            codeColumn.DataPropertyName = "codeOfBook";
            dataGridView1.Columns.Add(codeColumn);

            DataGridViewTextBoxColumn authorColumn = new DataGridViewTextBoxColumn();
            authorColumn.HeaderText = "نویسنده";
            authorColumn.DataPropertyName = "authorOfBook";
            dataGridView1.Columns.Add(authorColumn);

            DataGridViewTextBoxColumn publisherColumn = new DataGridViewTextBoxColumn();
            publisherColumn.HeaderText = "ناشر";
            publisherColumn.DataPropertyName = "publisherOfBook";
            dataGridView1.Columns.Add(publisherColumn);

            DataGridViewTextBoxColumn categoryColumn = new DataGridViewTextBoxColumn();
            categoryColumn.HeaderText = "دسته‌بندی";
            categoryColumn.DataPropertyName = "categoryOfBook";
            dataGridView1.Columns.Add(categoryColumn);

            DataGridViewCheckBoxColumn isAvailableColumn = new DataGridViewCheckBoxColumn();
            isAvailableColumn.HeaderText = "آیا موجود است؟";
            isAvailableColumn.DataPropertyName = "isAvailable";
            dataGridView1.Columns.Add(isAvailableColumn);

            dataGridView1.DataSource = list;
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "isAvailableColumn")
            {
                if (e.Value != null && e.Value is bool)
                {
                    bool value = (bool)e.Value;
                    e.Value = (value) ? "بله" : "خیر";
                    e.FormattingApplied = true;
                }
            }
        }
    }
}