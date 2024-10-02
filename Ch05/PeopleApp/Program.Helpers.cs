using System.Globalization;

partial class Program
{
    private static void ConfigureConsole(
        string culture = "en-US",
        bool useComputerCulture = false,
        bool showCulture = true)
        {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        if (!useComputerCulture)
        {
            CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo(culture);
        }

        if (showCulture)
        {
            Console.WriteLine($"Current culture: {CultureInfo.CurrentCulture.DisplayName}.");
        }
        }
}

