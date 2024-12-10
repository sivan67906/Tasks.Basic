using Task.Domain.Abstractions;

namespace Task.Domain.Tasks;

public sealed class TaskCategory(Guid id) : BaseEntitiy(id)
{
    public string? Code { get; set; }
    public string? Name { get; set; }
    public DateTime? CreatedDate { get; set; }
    public DateTime? ModifiedDate { get; set; }
    public int CreatedBy { get; set; }
    public int ModifiedBy { get; set; }
    public bool IsActive { get; set; }

    public ICollection<Tasks>? TasksList { get; set; }
}