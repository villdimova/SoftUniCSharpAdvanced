using System;
using System.Globalization;
using System.IO;
using System.IO.Compression;

namespace _6._Zip_and_Extract
{
    class Program
    {
        static void Main(string[] args)
        {
            var zipFilePath = @"../../../myZip.zip";
            var filePath = @"../../../copyMe.png";

            using (var archive=ZipFile.Open(zipFilePath,ZipArchiveMode.Create))
            {
                archive.CreateEntryFromFile(filePath, Path.GetFileName(filePath));
            }


        }
    }
}
