using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace XMLFileHandlings
{


    [XmlRoot(ElementName ="employees")]
    public class Employees
    {
        [XmlElement(ElementName = "employee")]
        public List<Employee> Employee { get; set; }

    }

    [XmlRoot("employee")]
    public class Employee
    {
        [XmlElement(ElementName = "name")]
        public string Name { get; set; }
        [XmlElement(ElementName = "position")]
        public string Position { get; set; }
        [XmlElement(ElementName = "joinyear")]
        public string Joinyear { get; set; }

        [XmlElement(ElementName = "salary")]
        public double Salary { get; set; }

        [XmlAttribute(AttributeName = "category")]
        public string Category { get; set; }

    }

    
    public class IDS
    {
        [XmlAttribute(AttributeName = "id")]
        public string Id { get; set; }

    }
}
