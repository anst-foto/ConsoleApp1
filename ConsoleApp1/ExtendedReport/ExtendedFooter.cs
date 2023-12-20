using ConsoleApp1.Abstracts;

namespace ConsoleApp1.ExtendedReport;

public class ExtendedFooter : AbstractFooter
{
    public required string Page { get; init; }

    public override string ToString()
    {
        return $"#{Page} \t {Text}";
    }
}