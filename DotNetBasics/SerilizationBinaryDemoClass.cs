using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace DotNetBasics
{
    [Serializable]
    internal class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class SerilizationDeserilizationClass
    {
        string path = "C:\\Users\\Karan Depale\\RFC285\\BasicCSharp\\RFP-Basics-.NET-Csharp\\DotNetBasics\\MyTextFileForIOHANDLING.txt";
        
        public void SerilizationMthod()
        {
            
            List<Employee> list = new List<Employee>()
            {
                new Employee {Id=1, Name="Karan"},
                new Employee {Id=2, Name="Khushi"},
                new Employee {Id=3, Name="atul"},
                new Employee {Id=4, Name="ajay"},
            };

            FileStream fs = new FileStream(path, FileMode.Open);
            BinaryFormatter bn = new BinaryFormatter();
            bn.Serialize(fs, list);
            fs.Close();

            Console.WriteLine("Object to binary formatter ready...");
            string binaryData = File.ReadAllText(path);
            Console.WriteLine(binaryData);

        }

        public void DeseRilization()
        {
            FileStream fs = new FileStream(path, FileMode.Open);
            BinaryFormatter bn = new BinaryFormatter();

            List<Employee> data = (List<Employee>)bn.Deserialize(fs);

            foreach(var val in data)
            {
                Console.WriteLine(val.Id);
                Console.WriteLine(val.Name);
            }
        }
    }




}
