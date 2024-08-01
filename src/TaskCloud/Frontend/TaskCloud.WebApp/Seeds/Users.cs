using TaskCloud.WebApp.Models;

namespace TaskCloud.WebApp.Seeds
{
    public class Users
    {
        public static IEnumerable<User> GetData()
        {
            var users = new User[]
            {
                new User
                {
                    Id = 1,
                    Username = "admin",
                    Email = "admin@example.com",
                    Password = "admin123",
                    Role = "Admin"
                },
                new User
            {
                Id = 2,
                Username = "projectmanager1",
                Email = "pm1@example.com",
                Password = "pm123",
                Role = "Project Manager"
            },
                new User
                {
                    Id = 3,
                    Username = "user1",
                    Email = "user1@example.com",
                    Password = "user123",
                    Role = "User"
                },
                new User
                {
                    Id = 4,
                    Username = "user2",
                    Email = "user2@example.com",
                    Password = "user123",
                    Role = "User"
                },
                new User
            {
                Id = 5,
                Username = "observer1",
                Email = "observer1@example.com",
                Password = "observer123",
                Role = "Observer"
            },
            new User
            {
                Id = 6,
                Username = "superuser",
                Email = "superuser@example.com",
                Password = "superuser123",
                Role = "Superuser"
            },
            new User
            {
                Id = 7,
                Username = "developer1",
                Email = "dev1@example.com",
                Password = "dev123",
                Role = "Developer"
            },
            new User
            {
                Id = 8,
                Username = "tester1",
                Email = "tester1@example.com",
                Password = "tester123",
                Role = "Tester"
            },
            new User
            {
                Id = 9,
                Username = "client1",
                Email = "client1@example.com",
                Password = "client123",
                Role = "Client"
            },
            new User
            {
                Id = 10,
                Username = "guest1",
                Email = "guest1@example.com",
                Password = "guest123",
                Role = "Guest"
            }
            };
            return users;
        }

    }
}