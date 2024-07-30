using TaskCloud.WebApp.Components.Enum;
using TaskCloud.WebApp.Components.Models;

namespace TaskCloud.WebApp.Components.Seeds
{
    public class Projects
    {
        public static IEnumerable<Project> GetData()
        {
            var projects = new Project[]
            {
            new Project
            {
                Id = 1,
                Title = "Website Redesign",
                Description = "Complete overhaul of the company website",
                StartDate = new DateTime(2024, 7, 1),
                EndDate = new DateTime(2024, 12, 1),
                Priority = Priority.Low,
                Status = Status.InProgress,
                UserId = 3,
                User = new User
                {
                    Id = 3,
                    Username = "user1",
                    Email = "user1@example.com",
                    Password = "user123",
                    Role = "User"
                }
            },
            new Project
            {
                Id = 2,
                Title = "Mobile App Development",
                Description = "Develop a new mobile app for e-commerce",
                StartDate = new DateTime(2024, 6, 15),
                EndDate = new DateTime(2025, 1, 15),
                Priority = Priority.Medium,
                Status = Status.InProgress,
                UserId = 4,
                User = new User
                {
                    Id = 4,
                    Username = "user2",
                    Email = "user2@example.com",
                    Password = "user123",
                    Role = "User"
                }
            },
            new Project
            {
                Id = 3,
                Title = "Marketing Campaign",
                Description = "Launch a marketing campaign for the new product",
                StartDate = new DateTime(2024, 7, 20),
                EndDate = new DateTime(2024, 10, 20),
                Priority = Priority.Medium,
                Status = Status.Completed,
                UserId = 3,
                User = new User
                {
                    Id = 3,
                    Username = "user1",
                    Email = "user1@example.com",
                    Password = "user123",
                    Role = "User"
                }
            },
            new Project
            {
                Id = 4,
                Title = "Cloud Migration",
                Description = "Migrate all services to the cloud",
                StartDate = new DateTime(2024, 8, 1),
                EndDate = null,
                Priority = Priority.Blocker,
                Status = Status.InProgress,
                UserId = 2,
                User = new User
                {
                    Id = 2,
                    Username = "projectmanager1",
                    Email = "pm1@example.com",
                    Password = "pm123",
                    Role = "Project Manager"
                }
            },
            new Project
            {
                Id = 5,
                Title = "Customer Feedback System",
                Description = "Implement a system to gather customer feedback",
                StartDate = new DateTime(2024, 7, 5),
                EndDate = new DateTime(2024, 9, 5),
                Priority = Priority.Blocker,
                Status = Status.Completed,
                UserId = 4,
                User = new User
                {
                    Id = 4,
                    Username = "user2",
                    Email = "user2@example.com",
                    Password = "user123",
                    Role = "User"
                }
            },
            new Project
            {
                Id = 6,
                Title = "Security Audit",
                Description = "Conduct a thorough security audit of the IT infrastructure",
                StartDate = new DateTime(2024, 9, 1),
                EndDate = new DateTime(2024, 11, 1),
                Priority = Priority.Low,
                Status = Status.InProgress,
                UserId = 2,
                User = new User
                {
                    Id = 2,
                    Username = "projectmanager1",
                    Email = "pm1@example.com",
                    Password = "pm123",
                    Role = "Project Manager"
                }
            },
            new Project
            {
                Id = 7,
                Title = "New Feature Development",
                Description = "Develop and integrate new features into the existing product",
                StartDate = new DateTime(2024, 6, 1),
                EndDate = null,
                Priority = Priority.Medium,
                Status = Status.InProgress,
                UserId = 3,
                User = new User
                {
                    Id = 3,
                    Username = "user1",
                    Email = "user1@example.com",
                    Password = "user123",
                    Role = "User"
                }
            },
            new Project
            {
                Id = 8,
                Title = "Employee Training Program",
                Description = "Organize a training program for new employees",
                StartDate = new DateTime(2024, 8, 15),
                EndDate = new DateTime(2024, 9, 15),
                Priority = Priority.High,
                Status = Status.Completed,
                UserId = 3,
                User = new User
                {
                    Id = 3,
                    Username = "user1",
                    Email = "user1@example.com",
                    Password = "user123",
                    Role = "User"
                }
            },
            new Project
            {
                Id = 9,
                Title = "Data Analysis Project",
                Description = "Analyze customer data to gain insights",
                StartDate = new DateTime(2024, 7, 10),
                EndDate = new DateTime(2024, 10, 10),
                Priority = Priority.Medium,
                Status = Status.Cancelled,
                UserId = 2,
                User = new User
            {
                Id = 2,
                Username = "projectmanager1",
                Email = "pm1@example.com",
                Password = "pm123",
                Role = "Project Manager"
            }
            },
            new Project
            {
                Id = 10,
                Title = "Product Launch Event",
                Description = "Plan and execute the launch event for the new product",
                StartDate = new DateTime(2024, 8, 5),
                EndDate = new DateTime(2024, 9, 5),
                Priority = Priority.Low,
                Status = Status.InProgress,
                UserId = 4,
                User = new User
                {
                    Id = 4,
                    Username = "user2",
                    Email = "user2@example.com",
                    Password = "user123",
                    Role = "User"
                }
            }
            };
        return projects;
        }
    }
}
