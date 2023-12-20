namespace ConsoleApp1.Abstracts;

public abstract class AbstractReport
{
    public virtual required AbstractMeta Meta { get; init; }
    public virtual required AbstractHeader Header { get; init; }
    public virtual required AbstractBody Body { get; init; }
    public virtual required AbstractFooter Footer { get; init; }
}