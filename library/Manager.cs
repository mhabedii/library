using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace library
{
    public class Manager
    {
        public string ?textOfFirstName { get; set; }
        public string ?textOfLastName { get; set; }
        public string ?textOfUserName { get; set; }
        public string ?textOfPassword { get; set; }
        public string ?textOfEmail { get; set; }
        public string ?textOfPhoneNumber { get; set; }
        public string ?textOfAge { get; set; }
        public string ?textOfNationalId { get; set; }
        
    }

    public class FileWriteRead
    {
        public void Write(Manager manager, string path) 
        {
            string json = JsonSerializer.Serialize(manager);
            using (StreamWriter file = new StreamWriter(path, append:true))
            {
                file.WriteLine(json);
            }
            MessageBox.Show("اطلاعات با موفقیت ذخیره شد");
        }
        public List<Manager> Read(string path) 
        {
            List<Manager> managers = new List<Manager>();
            using (StreamReader file = new StreamReader(path))
            {
                string line;
                while ((line = file.ReadLine()) != null)
                {
                    Manager manager = JsonSerializer.Deserialize<Manager>(line);
                    managers.Add(manager);
                }
            }
            return managers;

        }
    }
}
