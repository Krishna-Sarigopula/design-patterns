public interface IComputerFactory
{
    IBrand GetBrand();
    IProcessor GetProcessor();
    ISystemType GetSystemType();

}