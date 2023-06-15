using System;
using System.IO;
namespace DotNetBasics
{
    internal class FileHandlingDemo
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("File handling concept");
            Console.WriteLine("--------------------------");

            Console.WriteLine("Checking file is present or not...");
            string path = "C:\\Users\\Karan Depale\\RFC285\\BasicCSharp\\RFP-Basics-.NET-Csharp\\DotNetBasics\\MyTextFileForIOHANDLING.txt";
            if (File.Exists(path))
            {
                Console.WriteLine("File is exist:- ");
            }
            else
            {
                Console.WriteLine("File is not exist in this location...");
            }


            Console.WriteLine();
            Console.WriteLine("--------------------------");
            Console.WriteLine();

            Console.WriteLine("Reading data in Textfile:-");
            string path1 = "C:\\Users\\Karan Depale\\RFC285\\BasicCSharp\\RFP-Basics-.NET-Csharp\\DotNetBasics\\MyTextFileForIOHANDLING.txt";
            if (File.Exists(path1))
            {
                string fileData = File.ReadAllText(path1);
                Console.WriteLine(fileData);
            }
            else
            {
                Console.Write("File not found...");
            }


            Console.WriteLine();
            Console.WriteLine("--------------------------");
            Console.WriteLine();

            Console.WriteLine("Creating and entering new dataa text into file using FileStream");
            string myPath = "C:\\Users\\Karan Depale\\RFC285\\BasicCSharp\\RFP-Basics-.NET-Csharp\\DotNetBasics\\NewFileUsingFileStream.txt";
            using (FileStream file = new FileStream(myPath, FileMode.Create))
            {
                Console.WriteLine("File cerated...");
                StreamWriter objWrite = new StreamWriter(file);
                objWrite.Write("Entering new data using StraemWriter class..");
                Console.WriteLine("Writing new data successfully....");
                objWrite.Close();
            }

            Console.WriteLine();
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine();

            Console.WriteLine("Reading existing data using StreamReader :-");

            string myPath1 = "C:\\Users\\Karan Depale\\RFC285\\BasicCSharp\\RFP-Basics-.NET-Csharp\\DotNetBasics\\MyTextFileForIOHANDLING.txt";
            using (FileStream fs = new FileStream(myPath1 , FileMode.Open , FileAccess.Read))
            {
                StreamReader objReader = new StreamReader(fs);
                string data = "";
                while((data = objReader.ReadLine()) != null)
                {
                    Console.WriteLine(data);
                }
                Console.WriteLine(data);
                objReader.Close();
                
            }
                





        }
    }
}
