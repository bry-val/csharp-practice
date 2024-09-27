using System.Diagnostics;
using Microsoft.Extensions.Configuration;

string logPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory), "log.txt");

Console.WriteLine($"Writing to {logPath}");

TextWriterTraceListener logFile = new(File.CreateText(logPath));

Trace.Listeners.Add(logFile);

#if DEBUG
Trace.AutoFlush = true;
#endif

Debug.WriteLine("Debugger");
Trace.WriteLine("Tracer");

string settingsFile = "appsettings.json";

string settingsPath = Path.Combine(Directory.GetCurrentDirectory(), settingsFile);

Console.WriteLine($"Processing: {settingsPath}");
Console.WriteLine($"--{settingsFile} contents--");
Console.WriteLine(File.ReadAllText(settingsPath));
Console.WriteLine($"----");

ConfigurationBuilder builder = new();

builder.SetBasePath(Directory.GetCurrentDirectory());


builder.AddJsonFile(settingsFile, optional: false, reloadOnChange: true);

IConfigurationRoot configuration = builder.Build();

TraceSwitch ts = new(
    displayName: "PacktSwitch",
    description: "This switch is set via a JSON config."
);

configuration.GetSection("PacktSwitch").Bind(ts);

Console.WriteLine($"Trace switch value: {ts.Value}");
Console.WriteLine($"Trace switch levl: {ts.Level}");

Trace.WriteLineIf(ts.TraceError, "TraceError");
Trace.WriteLineIf(ts.TraceWarning, "TraceWarning");
Trace.WriteLineIf(ts.TraceInfo, "TraceInfo");
Trace.WriteLineIf(ts.TraceVerbose, "TraceVerbose");

int unitsInStock = 12;
LogSourceDetails(unitsInStock > 10);
Tester.CallLog();

Debug.Close();
Trace.Close();

Console.WriteLine("Press enter: ");
Console.ReadLine();

class Tester
{
    static readonly int agree = 12;
    public static void CallLog()
    {
        Program.LogSourceDetails(Tester.agree == 12);
    }
}