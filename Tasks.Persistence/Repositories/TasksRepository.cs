using Task.Domain.Interfaces;
using Task.Domain.Tasks;
using Task.Persistence.Data;

namespace Task.Persistence.Repositories;

public class TasksRepository(TaskDbContext taskDbContext) : ITasks
{
    //{
    //    var result = taskDbContext.TaskList.Add(entity);
    //    await taskDbContext.SaveChangesAsync();
    //    return result.Entity;
    //}
    //public async Task<int> DeleteAsync(int id)
    //{
    //    var result = await taskDbContext.TaskList.Where(i => i.Id == id).ExecuteDeleteAsync();
    //    return result;
    //}
    //public async Task<List<Tasks>> GetAllTasksAsync()
    //{
    //    List<Tasks> result = await taskDbContext.TaskList.ToListAsync();
    //    return result;
    //}
    //public async Task<Tasks> GettasksByIdAsync(int id)
    //{
    //    var result = await taskDbContext.TaskList.Where(emp => emp.Id == id).FirstOrDefaultAsync();
    //    return result;
    //}
    //public async Task<int> UpdateAsync(int id, Tasks entity)
    //{
    //    var result = await taskDbContext.TaskList.Where(i => i.Id == id)
    //        .ExecuteUpdateAsync(b => b
    //        .SetProperty(b => b.Name, entity.Name)
    //        .SetProperty(b => b.Description, entity.Description)
    //        .SetProperty(b => b.Author, entity.Author)
    //        );
    //    return result;
    //}
}
