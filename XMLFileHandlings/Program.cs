using System.Diagnostics.Metrics;
using System.Reflection.Metadata;
using System.Runtime.Serialization;
using System.Xml;
using System.Xml.Serialization;

namespace XMLFileHandlings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //To sote the FillePath
                string filePath = "C:\\Users\\sandhata\\source\\repos\\XMLFileHandlings\\XMLFileHandlings\\Employees.xml";
                //Callling The Method with FilePath Parameter
                DeserializeTheXmlToObject(filePath);
            }
            catch(FileNotFoundException Fe) {
                Console.WriteLine(Fe.Message);
            }

        }
        public static void DeserializeTheXmlToObject(string filePath)
        {
            try
            {
                //To do Desirialize we must instantiate Xmlserilizer Object with the type that we want to desirialize
                XmlSerializer xmlSerilaizer = new XmlSerializer(typeof(Employees));

                //Instantiate the StreamReader for reading the Xml file by passing the filePath as arugument for the StreamReader constructor
                var reader = new StreamReader(filePath);

                //Then Deserialize the file to Object by using Deserialize() present in the XmlSerializer Class
                //And convert the XmlSerializer type to Employee Type Reading the Value in Console
                Employees employees = (Employees)xmlSerilaizer.Deserialize(reader);

                //To print values that are present in the Xml file into The Console
                foreach (Employee employee in employees.Employee)
                {
                    Console.WriteLine($"The Name :{employee.Name}," +
                        $"\nThe Position :{employee.Position}" +
                        $"\nThe Salary :{employee.Salary}" +
                        $"\nJoinging year :{employee.Joinyear}" +
                        $"\nDepartment is :{employee.Category}" + "\n");
                }
                Console.WriteLine("De-Serializatio completed successfuly completed");
            } 
            catch(IndexOutOfRangeException ie) {
                Console.WriteLine(ie.Message);
            }
            catch(XmlException xe)
            {
                Console.WriteLine(xe.Message);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Thank you for Working with us");
            }
        }
        
    }

}