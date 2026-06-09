using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Todo_Backend.Data;
using Todo_Backend.Models;

namespace Todo_Backend.Controllers;

[ApiController]
[Route("api/tasks")]
[Authorize]
public class TasksController : ControllerBase
{
    private readonly ApplicationDbContext _context;

    public TasksController(ApplicationDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<IActionResult> GetTasks()
    {
        return Ok();
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetTask(int id)
    {
        return Ok();
    }

    [HttpPost]
    public async Task<IActionResult> CreateTask(CreateTaskDto dto)
    {
        return Ok();
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateTask(
        int id,
        UpdateTaskDto dto)
    {
        return Ok();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteTask(int id)
    {
        return Ok();
    }
}