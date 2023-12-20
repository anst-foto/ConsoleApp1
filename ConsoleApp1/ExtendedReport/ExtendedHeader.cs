using ConsoleApp1.Abstracts;

namespace ConsoleApp1.ExtendedReport;

public class ExtendedHeader : AbstractHeader
{
    public required string User { get; init; }

    public override string ToString()
    {
        return $"{Title} <{User}>";
    }
}