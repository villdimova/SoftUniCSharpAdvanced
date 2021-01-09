using System;
using System.IO;

namespace _4._Copy_Binary_File
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"../../../file.png";
            string newPath = @"../../../newFile.png";

            using (FileStream file = new FileStream(path, FileMode.Open)) 
            {
                var size = file.Length;
                var buffer = new byte[size];

                
                    using (FileStream coppiedfile = new FileStream(newPath, FileMode.Create))
                    {
                        var byteRead = file.Read(buffer, 0, buffer.Length);
                        coppiedfile.Write(buffer, 0, buffer.Length);
                    }
                

            }
        }
    }
}
