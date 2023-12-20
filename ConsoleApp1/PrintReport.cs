using System.Text.Json;
using ConsoleApp1.Abstracts;

namespace ConsoleApp1;

public static class PrintReport
{
    public static void ToConsole(AbstractReport report)
    {
        ConsoleEx.PrintTextCustomColor(report.Meta.ToString(), ConsoleColor.Gray);
        
        ConsoleEx.PrintInfo("+++ +++ +++ === === === +++ +++ +++");
        ConsoleEx.PrintInfo($"+++ +++ +++ {report.Header} +++ +++ +++");
        ConsoleEx.PrintInfo("+++ +++ +++ === === === +++ +++ +++");
        
        ConsoleEx.PrintInfo("--- --- --- *** *** *** --- --- ---");
        foreach (var section in report.Body.Sections)
        {
            ConsoleEx.PrintInfo($"\t --- {section} ---");
        }
        ConsoleEx.PrintInfo("--- --- --- *** *** *** --- --- ---");
        
        ConsoleEx.PrintInfo("=== === === +++ +++ +++ === === ===");
        ConsoleEx.PrintInfo($"=== === === {report.Footer} === === ===");
        ConsoleEx.PrintInfo("=== === === +++ +++ +++ === === ===");
    }

    public static void ToJson(AbstractReport report, out string json)
    {
        json = JsonSerializer.Serialize(report);
    }
}