using System.ComponentModel.DataAnnotations.Schema;
using Task.Domain.Abstractions;

namespace Task.Domain.Tasks;

public sealed class Tasks(Guid id) : BaseEntitiy(id)
{
    public string? Code { get; set; }
    [ForeignKey("TaskCategory")]
    public Guid? TaskCategoryId { get; set; }
    public string? Title { get; set; }
    public string? Description { get; set; }
    public string? Priority { get; set; }
    public int HoursLoggedIn { get; set; }
    public string? Status { get; set; }
    public string? AssignedTo { get; set; }
    public DateTime? StartDate { get; set; }
    public DateTime? DueDate { get; set; }
    public DateTime? CompletedOn { get; set; }
    public DateTime? CreatedDate { get; set; }
    public DateTime? ModifiedDate { get; set; }
    public int CreatedBy { get; set; }
    public int ModifiedBy { get; set; }
    public bool IsActive { get; set; }

    public TaskCategory? TaskCategory { get; set; }
}