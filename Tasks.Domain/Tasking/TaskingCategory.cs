using Tasks.Domain.Abstractions;

namespace Tasks.Domain.Tasking;

public sealed class TaskingCategory(Guid id) : BaseEntitiy(id)
{
    public string? Code { get; set; }
    public string? Name { get; set; }
    public DateTime? CreatedDate { get; set; }
    public DateTime? ModifiedDate { get; set; }
    public int CreatedBy { get; set; }
    public int ModifiedBy { get; set; }
    public bool IsActive { get; set; }

    public ICollection<Tasking>? TasksList { get; set; }
}