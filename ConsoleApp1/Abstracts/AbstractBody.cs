namespace ConsoleApp1.Abstracts;

public abstract class AbstractBody
{
    public virtual required IEnumerable<string> Sections { get; init; }
    
}