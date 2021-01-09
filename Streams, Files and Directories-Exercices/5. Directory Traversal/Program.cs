using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _5._Directory_Traversal
{
    public class File
    {
        public string Name { get; set; }
        public double Size { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var path = @"D:\Diabet";
            var files = Directory.GetFiles(path);
            var directoryFiles = new Dictionary<string, List<File>>();

            foreach (var file in files)
            {
                FileInfo fileInfo = new FileInfo(file);
                string extension = fileInfo.Extension;
                string name = fileInfo.Name;
                double size = fileInfo.Length;

                var currentFile = new File { Name = name, Size = size };
                if (!directoryFiles.ContainsKey(extension))
                {
                    directoryFiles.Add(extension, new List<File>());

                }
                directoryFiles[extension].Add(currentFile);
            }

            foreach (var file in directoryFiles.OrderByDescending(x=>x.Value.Count))
            {
                Console.WriteLine(file.Key);
                foreach (var item in file.Value.OrderBy(x=>x.Name))
                {
                    Console.WriteLine($"--{item.Name} - {item.Size}bytes");
                }
            }
        }
    }
}
