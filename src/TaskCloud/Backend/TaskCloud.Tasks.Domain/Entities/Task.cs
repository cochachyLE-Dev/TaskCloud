﻿namespace TaskCloud.Tasks.Domain.Entities
{
    public class Task
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public int Priority { get; set; }
        public DateTime DueDate { get; set; }
        public string? Status { get; set; }
        public int AssignedUserId { get; set; }
        public User? AssignedUser { get; set; }
        public List<Task> SubTasks { get; set; } = new List<Task>();
        public List<Comment> Comments { get; set; } = new List<Comment>();
    }
}
