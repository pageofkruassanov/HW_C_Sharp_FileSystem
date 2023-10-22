using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Task_2
{
    internal class FileManager
    {
        public void SaveToFile(Path dir, string data)
        {
            if (!Directory.Exists(dir.DirectoryPath)) { Directory.CreateDirectory(dir.DirectoryPath); }

            string jsonData = JsonConvert.SerializeObject(data);
            File.WriteAllText(dir.FilePath, jsonData);
        }

        public string LoadFromFile(Path dir)
        {
            if (File.Exists(dir.FilePath))
            {
                string jsonData = File.ReadAllText(dir.FilePath);
                string data = JsonConvert.DeserializeObject<string>(jsonData);

                return data;
            }
            else { throw new FileNotFoundException("File not found."); }
        }
    }
}
