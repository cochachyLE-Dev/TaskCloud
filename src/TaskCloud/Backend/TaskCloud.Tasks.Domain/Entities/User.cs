﻿namespace TaskCloud.Tasks.Domain.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string? Username { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public string? Role { get; set; }
        public List<Task> Tasks { get; set; } = new List<Task>();
    }
}
