using Microsoft.AspNetCore.Mvc;

using TaskCloud.Tasks.Domain.Models;
using TaskCloud.Tasks.Service.Contract;

namespace TaskCloud.Tasks.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TaskController : ControllerBase
    {
        public readonly ITaskService _taskService;
        public TaskController(ITaskService taskService) {
            _taskService = taskService;
        }

        [HttpPost]
        public async Task<IActionResult> CreateTask([FromBody] CreateTaskModel model)
        {
            var result = await _taskService.CreateTaskAsync(model);
            return Ok(result);
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateTask(int id, [FromBody] UpdateTaskModel model)
        {
            var result = await _taskService.UpdateTaskAsync(id, model);
            return Ok(result);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTask(int id)
        {
            var result = await _taskService.DeleteTaskAsync(id);
            return Ok(result);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetTaskById(int id)
        {
            var result = await _taskService.GetTaskByIdAsync(id);
            return Ok(result);
        }
    }
}
