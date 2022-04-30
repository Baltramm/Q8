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
                DirectoryInfo dirInfo = new DirectoryInfo(@"/" /* Или С:\\ для Windows */ );
                if (dirInfo.Exists)
                {
                    Console.WriteLine(dirInfo.GetDirectories().Length + dirInfo.GetFiles().Length);
                    Console.WriteLine($"Название каталога: {dirInfo.Name}");
                    Console.WriteLine($"Полное название каталога: {dirInfo.FullName}");
                    Console.WriteLine($"Время создания каталога: {dirInfo.CreationTime}");
                    Console.WriteLine($"Корневой каталог: {dirInfo.Root}");
                }

                DirectoryInfo newDirectory = new DirectoryInfo(@"/newDirectory");
                if (!newDirectory.Exists)
                    newDirectory.Create();

                Console.WriteLine(dirInfo.GetDirectories().Length + dirInfo.GetFiles().Length);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);

            }
            try
            {
                DirectoryInfo dirInfo = new DirectoryInfo(@"/newDirectory");
                dirInfo.Delete(true); // Удаление со всем содержимым
                Console.WriteLine("Каталог удален");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
