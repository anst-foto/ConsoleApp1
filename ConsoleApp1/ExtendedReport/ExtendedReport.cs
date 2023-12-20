using ConsoleApp1.Abstracts;

namespace ConsoleApp1.ExtendedReport;

public class ExtendedReport : AbstractReport
{
    public required int TotalPages { get; init; }
}