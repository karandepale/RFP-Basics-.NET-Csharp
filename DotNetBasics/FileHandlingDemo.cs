using System;
using System.IO;
namespace DotNetBasics
{
    internal class FileHandlingDemo
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("File handling concept");
            
            string path = "C:\\Users\\Karan Depale\\RFC285\\BasicCSharp\\RFP-Basics-.NET-Csharp\\DotNetBasics\\MyTextFileForIOHANDLING.txt";
            if (File.Exists(path))
            {
                Console.WriteLine("File is exist...");
            }
            else
            {
                Console.WriteLine("File is not exist in this location...");
            }
        }
    }
}
