using TaskCloud.WebApp.Components.Models;

namespace TaskCloud.WebApp.Components.Seeds
{
    public class Comments
    {
        public static IEnumerable<Comment> GetData()
        {
            var comments = new Comment[]
            {
                new Comment
                {
                    Id = 1,
                    Text = "Great work on the initial draft!",
                    CreatedAt = DateTime.Now.AddDays(-5),
                    UserId = 3,
                    TaskId = 1
                },
                new Comment
                {
                    Id = 2,
                    Text = "Please update the design to match the new requirements.",
                    CreatedAt = DateTime.Now.AddDays(-4),
                    UserId = 2,
                    TaskId = 3
                },
                new Comment
                {
                    Id = 3,
                    Text = "Fixed the issue with the login functionality.",
                    CreatedAt = DateTime.Now.AddDays(-3),
                    UserId = 7,
                    TaskId = 2
                },
                new Comment
                {
                    Id = 4,
                    Text = "Can we get feedback from the client before proceeding?",
                    CreatedAt = DateTime.Now.AddDays(-2),
                    UserId = 9,
                    TaskId = 6
                },
                new Comment
                {
                    Id = 5,
                    Text = "Added unit tests for the new module.",
                    CreatedAt = DateTime.Now.AddDays(-1),
                    UserId = 8,
                    TaskId = 5
                },
                new Comment
                {
                    Id = 6,
                    Text = "Please review the updated documentation.",
                    CreatedAt = DateTime.Now,
                    UserId = 4,
                    TaskId = 4
                },
                new Comment
                {
                    Id = 7,
                    Text = "Implemented the requested changes.",
                    CreatedAt = DateTime.Now.AddHours(-12),
                    UserId = 5,
                    TaskId = 7
                },
                new Comment
                {
                    Id = 8,
                    Text = "Meeting scheduled for tomorrow to discuss progress.",
                    CreatedAt = DateTime.Now.AddHours(-6),
                    UserId = 2,
                    TaskId = 8
                },
                new Comment
                {
                    Id = 9,
                    Text = "Waiting for approval from the project manager.",
                    CreatedAt = DateTime.Now.AddHours(-3),
                    UserId = 6,
                    TaskId = 9
                },
                new Comment
                {
                    Id = 10,
                    Text = "All tasks have been completed. Ready for deployment.",
                    CreatedAt = DateTime.Now.AddMinutes(-30),
                    UserId = 1,
                    TaskId = 10
                }
            };
            return comments;
        }
    }
}
