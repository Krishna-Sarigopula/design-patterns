using Newtonsoft.Json;
public class EmployeeAdapter : EmployeeManager, IEmployee
{
    public override string GetAllEmployees()
    {
        var data = base.GetAllEmployees();
        var xml = new System.Xml.XmlDocument();
        xml.LoadXml(data);
        return JsonConvert.SerializeObject(xml, Newtonsoft.Json.Formatting.Indented);
    }
}