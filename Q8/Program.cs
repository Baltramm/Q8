using System;
using System.Collections.Generic;

namespace Q8
{
    class Program
    {
        static void Main(string[] args)
        {
           
        }
    }
    public class Drive
    {
        public Drive(string name, long totalSpace, long freeSpace)
        {
            Name = name;
            TotalSpace = totalSpace;
            FreeSpace = freeSpace;
        }

        public string Name { get; }
        public long TotalSpace { get; }
        public long FreeSpace { get; }
       
    }
    public class Folder
    {
        public List<string> Files { get; set; } = new List<string>();
        Dictionary<string, Folder> Folders = new Dictionary<string, Folder>();

        public void CreateFolder(string name)
        {
            Folders.Add(name, new Folder());
        }
    }
}
