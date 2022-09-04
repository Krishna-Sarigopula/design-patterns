using System.Text;
public class ComputerConfiguration
{
    public string? Memory { get; set; }
    public string? size { get; set; }
    public string? KeyboardType { get; set; }


    public string BuildSystemConfiguration()
    {
        StringBuilder stringBuilder = new StringBuilder();
        stringBuilder.AppendFormat("RAM: {0}", Memory);
        stringBuilder.AppendFormat("HardDisk: {0}", size);
        stringBuilder.AppendFormat("Keyboard: {0}", KeyboardType);

        return stringBuilder.ToString();
    }

}