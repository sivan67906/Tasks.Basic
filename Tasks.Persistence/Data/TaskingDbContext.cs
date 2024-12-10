using Microsoft.EntityFrameworkCore;
using Tasks.Domain.Tasking;

namespace Tasks.Persistence.Data;

public class TaskingDbContext(DbContextOptions options) : DbContext(options)
{
    public DbSet<Tasking> TaskList { get; set; }
    public DbSet<TaskingCategory> TaskCategories { get; set; }
}
