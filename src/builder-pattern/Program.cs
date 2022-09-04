// See https://aka.ms/new-console-template for more information
ISystemBuilder computerConfiguration = new DesktopBuilder();
computerConfiguration.AddMemory("16GB")
                        .AddDrive("500GB HDD")
                        .AddkeyBoard("Wired");
                        
Console.WriteLine(computerConfiguration.GetComputer().BuildSystemConfiguration());
