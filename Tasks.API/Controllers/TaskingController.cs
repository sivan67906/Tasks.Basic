using MediatR;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Mvc;
using Tasks.Application.Tasking.Commands.CreateTasks;
using Tasks.Application.Tasking.Commands.DeleteTasks;
using Tasks.Application.Tasking.Commands.UpdateTasks;
using Tasks.Application.Tasking.Queries.GetTasksById;

namespace Tasks.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class TaskingController : ControllerBase
{
    //[HttpGet]
    //public async Task<IActionResult> GetAll()
    //{
    //    var taskList = await Mediator.Send(new GetTasksQuery());
    //    return Ok(taskList);
    //}

    //[HttpPost]
    //public async Task<IActionResult> Create(CreateTasksCommand entity)
    //{
    //    var newTask = await Mediator.Send(entity);

    //    return CreatedAtAction(nameof(GetById), new { id = newTask.Id }, newTask);
    //}
    //[HttpGet("{id}")]
    //public async Task<IActionResult> GetById(int id)
    //{
    //    var tasks = await Mediator.Send(new GetTasksByIdQuery() { Id = id });

    //    return Ok(tasks);
    //}

    //[HttpPut("{id}")]
    //public async Task<IActionResult> Update(int id, UpdateTasksCommand entity)
    //{
    //    if (id != entity.Id)
    //        return BadRequest();

    //    var upTasks = await Mediator.Send(entity);

    //    return NoContent();
    //}

    //[HttpDelete("{id}")]
    //public async Task<IActionResult> Delete(int id)
    //{
    //    var delTasks = await Mediator.Send(new DeleteTasksCommand() { Id = id });

    //    return NoContent();
    //}
}
