using ConsoleApp1.Abstracts;

namespace ConsoleApp1.EasyReport;

public class EasyFooter : AbstractFooter
{
    public override string ToString()
    {
        return Text ?? string.Empty;
    }
}