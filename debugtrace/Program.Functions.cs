using System.Diagnostics; // importds Trace class
using System.Runtime.CompilerServices; // imports [Caller_] attributes

partial class Program
{
    public static void LogSourceDetails(
        bool condition,
        [CallerMemberName] string member = "",
        [CallerFilePath] string filepath = "",
        [CallerLineNumber] int line = 0,
        [CallerArgumentExpression(nameof(condition))]  string expression = ""
    )
    {
        Trace.WriteLine($"[{filepath}]\n {member} on line {line}. Expression: {expression}");
    }
}