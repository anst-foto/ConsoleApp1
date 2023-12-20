using ConsoleApp1.Abstracts;

namespace ConsoleApp1.EasyReport;

public class EasyHeader : AbstractHeader
{
    public override string ToString()
    {
        return Title;
    }
}