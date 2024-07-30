using TaskCloud.WebApp.Components.Enum;
using TaskCloud.WebApp.Components.Models;

using Task = TaskCloud.WebApp.Components.Models.Task;

namespace TaskCloud.WebApp.Components.Seeds
{
    public class Tasks
    {
        public static IEnumerable<Task> GetData()
        {
            var tasks = new List<Task>
            {
                new Task
                {
                    Id = 1,
                    Title = "Initial Setup",
                    Description = "Set up the initial project configuration.",
                    Priority = Priority.Low,
                    DueDate = new DateTime(2024, 8, 5),
                    Status = "Pending",
                    AssignedUserId = 1,
                    AssignedUser = new User
                    {
                        Id = 1,
                        Username = "admin",
                        Email = "admin@example.com",
                        Password = "admin123",
                        Role = "Admin"
                    }
                },
                new Task
                {
                    Id = 2,
                    Title = "API Integration",
                    Description = "Integrate the new API with the application.",
                    Priority = Priority.High,
                    DueDate = new DateTime(2024, 8, 10),
                    Status = "In Progress",
                    AssignedUserId = 2,
                    AssignedUser = new User
                    {
                        Id = 2,
                        Username = "projectmanager1",
                        Email = "pm1@example.com",
                        Password = "pm123",
                        Role = "Project Manager"
                    }
                },
                new Task
                {
                    Id = 3,
                    Title = "UI Design",
                    Description = "Design the user interface for the main screen.",
                    Priority = Priority.Critical,
                    DueDate = new DateTime(2024, 8, 15),
                    Status = "Not Started",
                    AssignedUserId = 3,
                    AssignedUser = new User
                    {
                        Id = 3,
                        Username = "user1",
                        Email = "user1@example.com",
                        Password = "user123",
                        Role = "User"
                    }
                },
                new Task
                {
                    Id = 4,
                    Title = "Database Migration",
                    Description = "Migrate the database to the new schema.",
                    Priority = Priority.Blocker,
                    DueDate = new DateTime(2024, 8, 20),
                    Status = "Pending",
                    AssignedUserId = 4,
                    AssignedUser = new User
                    {
                        Id = 4,
                        Username = "user2",
                        Email = "user2@example.com",
                        Password = "user123",
                        Role = "User"
                    }
                },
                new Task
                {
                    Id = 5,
                    Title = "User Authentication",
                    Description = "Implement user authentication and authorization.",
                    Priority = Priority.Medium,
                    DueDate = new DateTime(2024, 8, 25),
                    Status = "In Progress",
                    AssignedUserId = 5,
                    AssignedUser = new User
                    {
                        Id = 5,
                        Username = "observer1",
                        Email = "observer1@example.com",
                        Password = "observer123",
                        Role = "Observer"

                        }
                },
                new Task
                {
                    Id = 6,
                    Title = "Performance Optimization",
                    Description = "Optimize the performance of the application.",
                    Priority = Priority.High,
                    DueDate = new DateTime(2024, 8, 30),
                    Status = "Not Started",
                    AssignedUserId = 6,
                    AssignedUser = new User
                    {
                        Id = 6,
                        Username = "superuser",
                        Email = "superuser@example.com",
                        Password = "superuser123",
                        Role = "Superuser"
                    }
                },
                new Task
                {
                    Id = 7,
                    Title = "Testing",
                    Description = "Conduct thorough testing of the new features.",
                    Priority = Priority.Critical,
                    DueDate = new DateTime(2024, 9, 5),
                    Status = "Pending",
                    AssignedUserId = 7,
                    AssignedUser = new User
                    {
                        Id = 7,
                        Username = "developer1",
                        Email = "dev1@example.com",
                        Password = "dev123",
                        Role = "Developer"
                    }
                },
                new Task
                {
                    Id = 8,
                    Title = "Documentation",
                    Description = "Write documentation for the API and user guide.",
                    Priority = Priority.Medium,
                    DueDate = new DateTime(2024, 9, 10),
                    Status = "In Progress",
                    AssignedUserId = 8,
                    AssignedUser = new User
                    {
                        Id = 8,
                        Username = "tester1",
                        Email = "tester1@example.com",
                        Password = "tester123",
                        Role = "Tester"
                    }
                },
                new Task
                {
                    Id = 9,
                    Title = "Deployment",
                    Description = "Deploy the application to the production environment.",
                    Priority = Priority.Blocker,
                    DueDate = new DateTime(2024, 9, 15),
                    Status = "Not Started",
                    AssignedUserId = 9,
                    AssignedUser = new User
                    {
                        Id = 9,
                        Username = "client1",
                        Email = "client1@example.com",
                        Password = "client123",
                        Role = "Client"
                    }
                },
                new Task
                {
                    Id = 10,
                    Title = "Client Feedback",
                    Description = "Collect and analyze client feedback for the new release.",
                    Priority = Priority.Low,
                    DueDate = new DateTime(2024, 9, 20),
                    Status = "Pending",
                    AssignedUserId = 10,
                    AssignedUser = new User
                    {
                        Id = 10,
                        Username = "guest1",
                        Email = "guest1@example.com",
                        Password = "guest123",
                        Role = "Guest"
                    }
                }
            };
            return tasks;
        }
    }
}