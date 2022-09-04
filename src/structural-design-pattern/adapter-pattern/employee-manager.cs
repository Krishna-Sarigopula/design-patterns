using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

public class EmployeeManager
{
    private List<Employee> employees;
    public EmployeeManager()
    {
        employees = new List<Employee>()
        {
            new Employee(){
                Id = 1,
                Name = "Krishna Sarigopula"
            },
            new Employee(){
                Id = 2,
                Name = "Manasa Sarigopula"
            }
        };
    }
    public virtual string GetAllEmployees()
    {
        using (var stringwriter = new StringWriter())
        {
            var serializer = new XmlSerializer(employees.GetType());
            serializer.Serialize(stringwriter, employees);
            return stringwriter.ToString();
        }
    }
}