namespace ConsoleApp1.Abstracts;

public abstract class AbstractMeta
{
    public virtual required string Creator { get; init; }
    public virtual DateTime CreateDateTime { get; init; } = DateTime.Now;
}