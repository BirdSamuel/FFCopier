using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFCopier.Data
{
    internal class Character
    {
        public string Name { get; set; }
        public string FolderPath { get; set; }

        public string GetFolderName() { return FolderPath.Split('\\').Last(); }

        public Character(string name, string folderPath) 
        {
            this.Name = name;
            this.FolderPath = folderPath;
        }
    }
}
