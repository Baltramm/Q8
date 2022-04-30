using System;
using System.Collections.Generic;
using System.IO;

namespace Q8
{
    class Program
    {
        static void Main(string[] args)
        { 
            GetCatalogs();
        }
        static void GetCatalogs()
        {
            try
            {
                DirectoryInfo dirInfo = new DirectoryInfo("С:\\");
                if (dirInfo.Exists)
                {
                    Console.WriteLine(dirInfo.GetDirectories().Length + dirInfo.GetFiles().Length);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
