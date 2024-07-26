using TaskCloud.Tasks.Domain.Entities;
using TaskCloud.Tasks.Domain.Models;

using Task = TaskCloud.Tasks.Domain.Entities.Task;

namespace TaskCloud.Tasks.Service.Contract
{
    public interface ITaskService
    {
        Task<Task> CreateTaskAsync(CreateTaskModel model);
        Task<Task> UpdateTaskAsync(int id, UpdateTaskModel model);
        Task<Task> DeleteTaskAsync(int id);
        Task<Task> GetTaskByIdAsync(int id);        
    }
}
