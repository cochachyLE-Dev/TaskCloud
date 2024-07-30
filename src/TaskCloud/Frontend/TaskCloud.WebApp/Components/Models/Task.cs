using TaskCloud.WebApp.Components.Enum;

namespace TaskCloud.WebApp.Components.Models
{
    public class Task
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public Priority Priority { get; set; }
        public DateTime DueDate { get; set; }
        public string? Status { get; set; }
        public int AssignedUserId { get; set; }
        public User? AssignedUser { get; set; }
        public List<Task> SubTasks { get; set; } = new List<Task>();
        public List<Comment> Comments { get; set; } = new List<Comment>();
        public bool IsSelected { get; set; }
    }
}
