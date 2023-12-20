using ConsoleApp1.Abstracts;

namespace ConsoleApp1.EasyReport;

public class EasyMeta : AbstractMeta
{
    public override string ToString()
    {
        return $"[{CreateDateTime:U}]: {Creator}";
    }
}