using TaskCloud.WebApp.Models.Enum;

namespace TaskCloud.WebApp.Models
{
    public class Task
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public Priority Priority { get; set; }
        public DateTime DueDate { get; set; }
        public Status Status { get; set; } = Status.Completed;
        public int Progress { get; set; }
        public int AssignedUserId { get; set; }
        public User? AssignedUser { get; set; }
        public List<Task> SubTasks { get; set; } = new List<Task>();
        public List<Comment> Comments { get; set; } = new List<Comment>();
        public bool IsSelected { get; set; }
    }
}
