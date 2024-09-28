using static System.Console;

namespace callstackhandlinglib;

public class Processor
{
    public static void Gamma()
    {
        WriteLine("In Gamma");
        Delta();
    }

    private static void Delta()
    {
        WriteLine("In Delta");
        File.OpenText("uasndaskbdkjlasnd");
    }
}
