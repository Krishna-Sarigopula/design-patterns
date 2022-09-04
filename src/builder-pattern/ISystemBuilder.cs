
public interface ISystemBuilder
{
    ISystemBuilder AddMemory(string memory);
    ISystemBuilder AddDrive(string size);
    ISystemBuilder AddkeyBoard(string type);
    ComputerConfiguration GetComputer();
}