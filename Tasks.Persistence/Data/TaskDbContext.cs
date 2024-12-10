using Microsoft.EntityFrameworkCore;
using Task.Domain.Tasks;

namespace Task.Persistence.Data;

public class TaskDbContext(DbContextOptions options) : DbContext(options)
{
    public DbSet<Tasks> TaskList { get; set; }
    public DbSet<TaskCategory> TaskCategories { get; set; }
}
