using ConsoleApp1.Abstracts;

namespace ConsoleApp1.ExtendedReport;

public class ExtendedMeta : AbstractMeta
{
    public required string Description { get; init; }

    public override string ToString() => $"{Creator} \t [{CreateDateTime:U}] \t {Description}";
}