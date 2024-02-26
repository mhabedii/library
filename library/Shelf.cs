using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace library
{
    public class Shelf
    {
        public string ?nameOfShelf { get; set; } 
    }
    public class ShelfWriteRead
    {
        public void Write(Shelf shelf, string path) 
        {
            string json = JsonSerializer.Serialize(shelf);
            using (StreamWriter file = new StreamWriter(path, append: true))
            {
                file.WriteLine(json);
            }
            MessageBox.Show("اطلاعات با موفقیت ذخیره شد");
        }
        public List<Shelf> Read(string path)
        {
            List<Shelf> shelfs = new List<Shelf>();
            using (StreamReader file = new StreamReader(path))
            {
                string line;
                while ((line = file.ReadLine()) != null)
                {
                    Shelf manager = JsonSerializer.Deserialize<Shelf>(line);
                    shelfs.Add(manager);
                }
            }
            return shelfs;

        }
    }
}
