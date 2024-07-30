﻿using TaskCloud.Tasks.Domain.Enum;

namespace TaskCloud.Tasks.Domain.Entities
{
    public class Project
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public Priority Priority { get; set; }
        public Status Status { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public List<Task> Tasks { get; set; } = new List<Task>();
    }    
}