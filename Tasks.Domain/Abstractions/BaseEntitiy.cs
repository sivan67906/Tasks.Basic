namespace Tasks.Domain.Abstractions;

public abstract class BaseEntitiy
{
    protected BaseEntitiy(Guid id)
    {
        Id = id;
    }
    public Guid Id { get; set; }
}