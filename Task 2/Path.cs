using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    internal class Path
    {
        private string _directoryPath;

        private string _filePath;

        public Path()
        {
            _directoryPath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory);
        }

        public string DirectoryPath
        {
            get { return _directoryPath; }
        }

        public string FilePath
        {
            set { _filePath = System.IO.Path.Combine(_directoryPath, value); }
            get { return _filePath; }
        }
    }
}
