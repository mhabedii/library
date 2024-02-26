using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace library
{
    public class Book
    {
        public string ?nameOfBook { get; set; }
        public string ?codeOfBook { get; set; }
        public string ?authorOfBook { get; set; }
        public string ?publisherOfBook { get; set; }
        public bool ?isAvailable { get; set; }
        public string ?categoryOfBook { get; set; }
        
    }
    public class BookWriteRead
    {
        public void bookWrite(Book book, string path)
        {
            string json = JsonSerializer.Serialize(book);
            using (StreamWriter file = new StreamWriter(path, append: true))
            {
                file.WriteLine(json);
            }
            MessageBox.Show("کتاب با موفقیت ذخیره شد");
        }
        public List<Book> Read(string path)
        {
            List<Book> books = new List<Book>();
            using (StreamReader file = new StreamReader(path))
            {
                string line;
                while ((line = file.ReadLine()) != null)
                {
                    Book book = JsonSerializer.Deserialize<Book>(line);
                    books.Add(book);
                }
            }
            return books;

        }
    }
}
