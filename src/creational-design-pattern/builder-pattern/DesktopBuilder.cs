public class DesktopBuilder : ISystemBuilder
{
    ComputerConfiguration computerConfiguration = new ComputerConfiguration();

    public ISystemBuilder AddMemory(string memory)
    {
        computerConfiguration.Memory = memory;
        return this;
    }
    public ISystemBuilder AddDrive(string size)
    {
        computerConfiguration.size = size;
        return this;
    }
    public ISystemBuilder AddkeyBoard(string type)
    {
        computerConfiguration.KeyboardType = type;
        return this;
    }
    public ComputerConfiguration GetComputer()
    {
        return computerConfiguration;
    }
}