using TaskCloud.WebApp.Models.Enum;
using TaskCloud.WebApp.Models;
using Task = TaskCloud.WebApp.Models.Task;

namespace TaskCloud.WebApp.Seeds
{
    public class Tasks
    {
        public static IEnumerable<Task> GetData()
        {
            var users = Users.GetData();
            var tasks = new List<Task>
            {
                new Task
                {
                    Id = 1,
                    Title = "Initial Setup",
                    Description = "Set up the initial project configuration.",
                    Priority = Priority.Low,
                    DueDate = new DateTime(2024, 8, 5),
                    Status = Status.Pending,
                    Progress = 0,
                    AssignedUserId = 1,
                    AssignedUser = users.Single(x => x.Id == 1),
                    SubTasks = new List<Models.Task> {
                        new Task { Id = 1, Title = "Create repository", Description = "Set up a new Git repository.", Priority = Priority.High, DueDate = DateTime.Now.AddDays(1), Status = Status.NotStarted },
                        new Task { Id = 2, Title = "Install dependencies", Description = "Install required dependencies using NuGet.", Priority = Priority.Medium, DueDate = DateTime.Now.AddDays(2), Status = Status.NotStarted },
                        new Task { Id = 3, Title = "Configure IDE", Description = "Configure Visual Studio for the project.", Priority = Priority.Low, DueDate = DateTime.Now.AddDays(3), Status = Status.NotStarted },
                        new Task { Id = 4, Title = "Set up CI/CD", Description = "Configure continuous integration and delivery.", Priority = Priority.Critical, DueDate = DateTime.Now.AddDays(4), Status = Status.NotStarted },
                        new Task { Id = 5, Title = "Create project structure", Description = "Set up the basic project structure.", Priority = Priority.Medium, DueDate = DateTime.Now.AddDays(5), Status = Status.NotStarted },
                        new Task { Id = 6, Title = "Initialize database", Description = "Set up the initial database schema.", Priority = Priority.High, DueDate = DateTime.Now.AddDays(6), Status = Status.NotStarted },
                        new Task { Id = 7, Title = "Configure settings", Description = "Set up application settings and configurations.", Priority = Priority.Medium, DueDate = DateTime.Now.AddDays(7), Status = Status.NotStarted },
                        new Task { Id = 8, Title = "Set up logging", Description = "Implement logging for the application.", Priority = Priority.High, DueDate = DateTime.Now.AddDays(8), Status = Status.NotStarted },
                        new Task { Id = 9, Title = "Create initial documentation", Description = "Write initial project documentation.", Priority = Priority.Low, DueDate = DateTime.Now.AddDays(9), Status = Status.NotStarted },
                        new Task { Id = 10, Title = "Review setup", Description = "Review the initial setup with the team.", Priority = Priority.High, DueDate = DateTime.Now.AddDays(10), Status = Status.NotStarted }
                    }
                },
                new Task
                {
                    Id = 2,
                    Title = "API Integration",
                    Description = "Integrate the new API with the application.",
                    Priority = Priority.High,
                    DueDate = new DateTime(2024, 8, 10),
                    Status = Status.InProgress,
                    Progress = 60,
                    AssignedUserId = 2,
                    AssignedUser = users.Single(x => x.Id == 2),
                    IsProject = true,
                    SubTasks = new List<Models.Task> {
                        new Task { Id = 1, Title = "Review API documentation", Description = "Understand the API endpoints and usage.", Priority = Priority.Medium, DueDate = DateTime.Now.AddDays(1), Status = Status.NotStarted },
                        new Task { Id = 2, Title = "Set up API client", Description = "Configure the API client in the application.", Priority = Priority.High, DueDate = DateTime.Now.AddDays(2), Status = Status.NotStarted },
                        new Task { Id = 3, Title = "Implement authentication", Description = "Handle API authentication.", Priority = Priority.Critical, DueDate = DateTime.Now.AddDays(3), Status = Status.NotStarted },
                        new Task { Id = 4, Title = "Create service layer", Description = "Create a service layer to interact with the API.", Priority = Priority.High, DueDate = DateTime.Now.AddDays(4), Status = Status.NotStarted },
                        new Task { Id = 5, Title = "Map API responses", Description = "Map API responses to application models.", Priority = Priority.Medium, DueDate = DateTime.Now.AddDays(5), Status = Status.NotStarted },
                        new Task { Id = 6, Title = "Handle errors", Description = "Implement error handling for API calls.", Priority = Priority.High, DueDate = DateTime.Now.AddDays(6), Status = Status.NotStarted },
                        new Task { Id = 7, Title = "Write unit tests", Description = "Create unit tests for API integration.", Priority = Priority.Medium, DueDate = DateTime.Now.AddDays(7), Status = Status.NotStarted },
                        new Task { Id = 8, Title = "Document API usage", Description = "Document how the API is integrated in the application.", Priority = Priority.Low, DueDate = DateTime.Now.AddDays(8), Status = Status.NotStarted },
                        new Task { Id = 9, Title = "Review integration", Description = "Review the API integration with the team.", Priority = Priority.High, DueDate = DateTime.Now.AddDays(9), Status = Status.NotStarted },
                        new Task { Id = 10, Title = "Deploy to staging", Description = "Deploy the API integration to the staging environment.", Priority = Priority.Critical, DueDate = DateTime.Now.AddDays(10), Status = Status.NotStarted }
                    }
                },
                new Task
                {
                    Id = 3,
                    Title = "UI Design",
                    Description = "Design the user interface for the main screen.",
                    Priority = Priority.Critical,
                    DueDate = new DateTime(2024, 8, 15),
                    Status = Status.NotStarted,
                    Progress = 45,
                    AssignedUserId = 3,
                    AssignedUser = users.Single(x => x.Id == 3),
                    SubTasks = new List<Models.Task> {
                        new Task { Id = 1, Title = "Create wireframes", Description = "Design wireframes for the main screen.", Priority = Priority.High, DueDate = DateTime.Now.AddDays(1), Status = Status.NotStarted },
                        new Task { Id = 2, Title = "Select color scheme", Description = "Choose a color scheme for the application.", Priority = Priority.Medium, DueDate = DateTime.Now.AddDays(2), Status = Status.NotStarted },
                        new Task { Id = 3, Title = "Design layout", Description = "Design the layout of the main screen.", Priority = Priority.High, DueDate = DateTime.Now.AddDays(3), Status = Status.NotStarted },
                        new Task { Id = 4, Title = "Create UI components", Description = "Design reusable UI components.", Priority = Priority.Critical, DueDate = DateTime.Now.AddDays(4), Status = Status.NotStarted },
                        new Task { Id = 5, Title = "Implement responsive design", Description = "Ensure the UI is responsive.", Priority = Priority.High, DueDate = DateTime.Now.AddDays(5), Status = Status.NotStarted },
                        new Task { Id = 6, Title = "Create design documentation", Description = "Document the UI design decisions.", Priority = Priority.Medium, DueDate = DateTime.Now.AddDays(6), Status = Status.NotStarted },
                        new Task { Id = 7, Title = "Review design with stakeholders", Description = "Get feedback on the design from stakeholders.", Priority = Priority.High, DueDate = DateTime.Now.AddDays(7), Status = Status.NotStarted },
                        new Task { Id = 8, Title = "Adjust design based on feedback", Description = "Incorporate feedback into the UI design.", Priority = Priority.Medium, DueDate = DateTime.Now.AddDays(8), Status = Status.NotStarted },
                        new Task { Id = 9, Title = "Finalize design", Description = "Finalize the design for implementation.", Priority = Priority.High, DueDate = DateTime.Now.AddDays(9), Status = Status.NotStarted },
                        new Task { Id = 10, Title = "Prepare assets", Description = "Prepare design assets for developers.", Priority = Priority.Medium, DueDate = DateTime.Now.AddDays(10), Status = Status.NotStarted }
                    }
                },
                new Task
                {
                    Id = 4,
                    Title = "Database Migration",
                    Description = "Migrate the database to the new schema.",
                    Priority = Priority.Blocker,
                    DueDate = new DateTime(2024, 8, 20),
                    Status = Status.Pending,
                    Progress = 0,
                    AssignedUserId = 4,
                    AssignedUser = users.Single(x => x.Id == 4),
                    SubTasks = new List<Models.Task> {
                        new Task { Id = 1, Title = "Backup current database", Description = "Create a backup of the current database.", Priority = Priority.Critical, DueDate = DateTime.Now.AddDays(1), Status = Status.NotStarted },
                        new Task { Id = 2, Title = "Review new schema", Description = "Review the new database schema.", Priority = Priority.High, DueDate = DateTime.Now.AddDays(2), Status = Status.NotStarted },
                        new Task { Id = 3, Title = "Plan migration steps", Description = "Create a detailed migration plan.", Priority = Priority.Medium, DueDate = DateTime.Now.AddDays(3), Status = Status.NotStarted },
                        new Task { Id = 4, Title = "Set up migration tools", Description = "Configure tools for the migration.", Priority = Priority.High, DueDate = DateTime.Now.AddDays(4), Status = Status.NotStarted },
                        new Task { Id = 5, Title = "Test migration on staging", Description = "Run a test migration on the staging environment.", Priority = Priority.Critical, DueDate = DateTime.Now.AddDays(5), Status = Status.NotStarted },
                        new Task { Id = 6, Title = "Fix migration issues", Description = "Resolve any issues encountered during testing.", Priority = Priority.High, DueDate = DateTime.Now.AddDays(6), Status = Status.NotStarted },
                        new Task { Id = 7, Title = "Perform migration", Description = "Execute the migration to the new schema.", Priority = Priority.Critical, DueDate = DateTime.Now.AddDays(7), Status = Status.NotStarted },
                        new Task { Id = 8, Title = "Verify data integrity", Description = "Ensure all data was migrated correctly.", Priority = Priority.High, DueDate = DateTime.Now.AddDays(8), Status = Status.NotStarted },
                        new Task { Id = 9, Title = "Optimize database performance", Description = "Optimize the database for performance.", Priority = Priority.Medium, DueDate = DateTime.Now.AddDays(9), Status = Status.NotStarted },
                        new Task { Id = 10, Title = "Update documentation", Description = "Document the migration process.", Priority = Priority.Low, DueDate = DateTime.Now.AddDays(10), Status = Status.NotStarted }
                    }
                },
                new Task
                {
                    Id = 5,
                    Title = "User Authentication",
                    Description = "Implement user authentication and authorization.",
                    Priority = Priority.Medium,
                    DueDate = new DateTime(2024, 8, 25),
                    Status = Status.InProgress,
                    Progress = 25,
                    AssignedUserId = 5,
                    AssignedUser = users.Single(x => x.Id == 5),
                    IsProject = true,
                    SubTasks = new List<Models.Task> {
                        new Task { Id = 1, Title = "Choose authentication method", Description = "Decide on an authentication method (e.g., OAuth, JWT).", Priority = Priority.High, DueDate = DateTime.Now.AddDays(1), Status = Status.NotStarted },
                        new Task { Id = 2, Title = "Set up authentication server", Description = "Configure the authentication server.", Priority = Priority.Critical, DueDate = DateTime.Now.AddDays(2), Status = Status.NotStarted },
                        new Task { Id = 3, Title = "Implement login functionality", Description = "Create the login functionality.", Priority = Priority.High, DueDate = DateTime.Now.AddDays(3), Status = Status.NotStarted },
                        new Task { Id = 4, Title = "Implement registration functionality", Description = "Create the user registration functionality.", Priority = Priority.Medium, DueDate = DateTime.Now.AddDays(4), Status = Status.NotStarted },
                        new Task { Id = 5, Title = "Create user roles", Description = "Set up user roles and permissions.", Priority = Priority.High, DueDate = DateTime.Now.AddDays(5), Status = Status.NotStarted },
                        new Task { Id = 6, Title = "Implement password recovery", Description = "Add password recovery functionality.", Priority = Priority.Medium, DueDate = DateTime.Now.AddDays(6), Status = Status.NotStarted },
                        new Task { Id = 7, Title = "Write authentication tests", Description = "Create tests for authentication flows.", Priority = Priority.Medium, DueDate = DateTime.Now.AddDays(7), Status = Status.NotStarted },
                        new Task { Id = 8, Title = "Integrate with frontend", Description = "Integrate authentication with the frontend.", Priority = Priority.High, DueDate = DateTime.Now.AddDays(8), Status = Status.NotStarted },
                        new Task { Id = 9, Title = "Review security", Description = "Conduct a security review of the authentication system.", Priority = Priority.Critical, DueDate = DateTime.Now.AddDays(9), Status = Status.NotStarted },
                        new Task { Id = 10, Title = "Document authentication process", Description = "Write documentation for the authentication system.", Priority = Priority.Low, DueDate = DateTime.Now.AddDays(10), Status = Status.NotStarted }
                    }
                },
                new Task
                {
                    Id = 6,
                    Title = "Performance Optimization",
                    Description = "Optimize the performance of the application.",
                    Priority = Priority.High,
                    DueDate = new DateTime(2024, 8, 30),
                    Status = Status.NotStarted,
                    Progress = 0,
                    AssignedUserId = 6,
                    AssignedUser = users.Single(x => x.Id == 6),
                    SubTasks = new List<Models.Task> {
                        new Task { Id = 1, Title = "Identify bottlenecks", Description = "Find performance bottlenecks in the application.", Priority = Priority.Critical, DueDate = DateTime.Now.AddDays(1), Status = Status.NotStarted },
                        new Task { Id = 2, Title = "Optimize database queries", Description = "Improve the performance of database queries.", Priority = Priority.High, DueDate = DateTime.Now.AddDays(2), Status = Status.NotStarted },
                        new Task { Id = 3, Title = "Implement caching", Description = "Add caching to improve performance.", Priority = Priority.Medium, DueDate = DateTime.Now.AddDays(3), Status = Status.NotStarted },
                        new Task { Id = 4, Title = "Optimize frontend code", Description = "Improve the performance of frontend code.", Priority = Priority.High, DueDate = DateTime.Now.AddDays(4), Status = Status.NotStarted },
                        new Task { Id = 5, Title = "Optimize backend code", Description = "Improve the performance of backend code.", Priority = Priority.High, DueDate = DateTime.Now.AddDays(5), Status = Status.NotStarted },
                        new Task { Id = 6, Title = "Conduct load testing", Description = "Perform load testing on the application.", Priority = Priority.Critical, DueDate = DateTime.Now.AddDays(6), Status = Status.NotStarted },
                        new Task { Id = 7, Title = "Review and optimize assets", Description = "Optimize images, scripts, and other assets.", Priority = Priority.Medium, DueDate = DateTime.Now.AddDays(7), Status = Status.NotStarted },
                        new Task { Id = 8, Title = "Monitor performance", Description = "Set up performance monitoring tools.", Priority = Priority.High, DueDate = DateTime.Now.AddDays(8), Status = Status.NotStarted },
                        new Task { Id = 9, Title = "Review optimization with team", Description = "Discuss optimization results with the team.", Priority = Priority.Medium, DueDate = DateTime.Now.AddDays(9), Status = Status.NotStarted },
                        new Task { Id = 10, Title = "Document optimization steps", Description = "Write documentation for the optimization steps.", Priority = Priority.Low, DueDate = DateTime.Now.AddDays(10), Status = Status.NotStarted }
                    }
                },
                new Task
                {
                    Id = 7,
                    Title = "Testing",
                    Description = "Conduct thorough testing of the new features.",
                    Priority = Priority.Critical,
                    DueDate = new DateTime(2024, 9, 5),
                    Status = Status.Pending,
                    Progress = 0,
                    AssignedUserId = 7,
                    AssignedUser = users.Single(x => x.Id == 7),
                    SubTasks = new List<Models.Task> {
                        new Task { Id = 1, Title = "Create test plan", Description = "Write a detailed test plan.", Priority = Priority.High, DueDate = DateTime.Now.AddDays(1), Status = Status.NotStarted },
                        new Task { Id = 2, Title = "Write unit tests", Description = "Create unit tests for new features.", Priority = Priority.Critical, DueDate = DateTime.Now.AddDays(2), Status = Status.NotStarted },
                        new Task { Id = 3, Title = "Write integration tests", Description = "Create integration tests for the application.", Priority = Priority.High, DueDate = DateTime.Now.AddDays(3), Status = Status.NotStarted },
                        new Task { Id = 4, Title = "Write UI tests", Description = "Create UI tests for the new interface.", Priority = Priority.Medium, DueDate = DateTime.Now.AddDays(4), Status = Status.NotStarted },
                        new Task { Id = 5, Title = "Perform manual testing", Description = "Conduct manual testing of new features.", Priority = Priority.Medium, DueDate = DateTime.Now.AddDays(5), Status = Status.NotStarted },
                        new Task { Id = 6, Title = "Set up automated testing", Description = "Configure automated testing tools.", Priority = Priority.High, DueDate = DateTime.Now.AddDays(6), Status = Status.NotStarted },
                        new Task { Id = 7, Title = "Execute test cases", Description = "Run the test cases and document results.", Priority = Priority.Critical, DueDate = DateTime.Now.AddDays(7), Status = Status.NotStarted },
                        new Task { Id = 8, Title = "Fix bugs", Description = "Fix any bugs found during testing.", Priority = Priority.High, DueDate = DateTime.Now.AddDays(8), Status = Status.NotStarted },
                        new Task { Id = 9, Title = "Re-test fixed issues", Description = "Re-test issues after they have been fixed.", Priority = Priority.Medium, DueDate = DateTime.Now.AddDays(9), Status = Status.NotStarted },
                        new Task { Id = 10, Title = "Finalize test report", Description = "Write the final test report.", Priority = Priority.Medium, DueDate = DateTime.Now.AddDays(10), Status = Status.NotStarted }
                    }
                },
                new Task
                {
                    Id = 8,
                    Title = "Documentation",
                    Description = "Write documentation for the API and user guide.",
                    Priority = Priority.Medium,
                    DueDate = new DateTime(2024, 9, 10),
                    Status = Status.InProgress,
                    Progress = 2,
                    AssignedUserId = 8,
                    AssignedUser = users.Single(x => x.Id == 8),
                    IsProject = true,
                    SubTasks = new List<Models.Task> {
                        new Task { Id = 1, Title = "API documentation", Description = "Write detailed documentation for the API.", Priority = Priority.High, DueDate = DateTime.Now.AddDays(1), Status = Status.NotStarted },
                        new Task { Id = 2, Title = "User guide", Description = "Create a user guide for the application.", Priority = Priority.Medium, DueDate = DateTime.Now.AddDays(2), Status = Status.NotStarted },
                        new Task { Id = 3, Title = "Installation guide", Description = "Write a guide for installing the application.", Priority = Priority.Medium, DueDate = DateTime.Now.AddDays(3), Status = Status.NotStarted },
                        new Task { Id = 4, Title = "Developer guide", Description = "Write documentation for developers.", Priority = Priority.High, DueDate = DateTime.Now.AddDays(4), Status = Status.NotStarted },
                        new Task { Id = 5, Title = "FAQ section", Description = "Create a FAQ section for common issues.", Priority = Priority.Low, DueDate = DateTime.Now.AddDays(5), Status = Status.NotStarted },
                        new Task { Id = 6, Title = "Review documentation", Description = "Get feedback on the documentation.", Priority = Priority.Medium, DueDate = DateTime.Now.AddDays(6), Status = Status.NotStarted },
                        new Task { Id = 7, Title = "Incorporate feedback", Description = "Update documentation based on feedback.", Priority = Priority.Medium, DueDate = DateTime.Now.AddDays(7), Status = Status.NotStarted },
                        new Task { Id = 8, Title = "Create documentation website", Description = "Set up a website for hosting the documentation.", Priority = Priority.High, DueDate = DateTime.Now.AddDays(8), Status = Status.NotStarted },
                        new Task { Id = 9, Title = "Test documentation", Description = "Ensure all documentation is accurate and complete.", Priority = Priority.High, DueDate = DateTime.Now.AddDays(9), Status = Status.NotStarted },
                        new Task { Id = 10, Title = "Finalize documentation", Description = "Finalize and publish the documentation.", Priority = Priority.Medium, DueDate = DateTime.Now.AddDays(10), Status = Status.NotStarted }
                    }
                },
                new Task
                {
                    Id = 9,
                    Title = "Deployment",
                    Description = "Deploy the application to the production environment.",
                    Priority = Priority.Blocker,
                    DueDate = new DateTime(2024, 9, 15),
                    Status = Status.NotStarted,
                    Progress = 0,
                    AssignedUserId = 9,
                    AssignedUser = users.Single(x => x.Id == 9),
                    SubTasks = new List<Models.Task> {
                        new Task { Id = 1, Title = "Prepare deployment plan", Description = "Create a detailed deployment plan.", Priority = Priority.Critical, DueDate = DateTime.Now.AddDays(1), Status = Status.NotStarted },
                        new Task { Id = 2, Title = "Set up production environment", Description = "Configure the production environment.", Priority = Priority.High, DueDate = DateTime.Now.AddDays(2), Status = Status.NotStarted },
                        new Task { Id = 3, Title = "Test deployment on staging", Description = "Perform a test deployment on the staging environment.", Priority = Priority.Critical, DueDate = DateTime.Now.AddDays(3), Status = Status.NotStarted },
                        new Task { Id = 4, Title = "Fix deployment issues", Description = "Resolve any issues encountered during testing.", Priority = Priority.High, DueDate = DateTime.Now.AddDays(4), Status = Status.NotStarted },
                        new Task { Id = 5, Title = "Execute deployment", Description = "Deploy the application to production.", Priority = Priority.Critical, DueDate = DateTime.Now.AddDays(5), Status = Status.NotStarted },
                        new Task { Id = 6, Title = "Verify deployment", Description = "Ensure the application is working correctly in production.", Priority = Priority.High, DueDate = DateTime.Now.AddDays(6), Status = Status.NotStarted },
                        new Task { Id = 7, Title = "Monitor deployment", Description = "Monitor the application post-deployment.", Priority = Priority.Medium, DueDate = DateTime.Now.AddDays(7), Status = Status.NotStarted },
                        new Task { Id = 8, Title = "Document deployment process", Description = "Write documentation for the deployment process.", Priority = Priority.Low, DueDate = DateTime.Now.AddDays(8), Status = Status.NotStarted },
                        new Task { Id = 9, Title = "Get feedback on deployment", Description = "Collect feedback from users post-deployment.", Priority = Priority.Medium, DueDate = DateTime.Now.AddDays(9), Status = Status.NotStarted },
                        new Task { Id = 10, Title = "Finalize deployment", Description = "Finalize and close the deployment process.", Priority = Priority.Medium, DueDate = DateTime.Now.AddDays(10), Status = Status.NotStarted }
                    }
                },
                new Task
                {
                    Id = 10,
                    Title = "Client Feedback",
                    Description = "Collect and analyze client feedback for the new release.",
                    Priority = Priority.Low,
                    DueDate = new DateTime(2024, 9, 20),
                    Status = Status.Pending,
                    Progress = 0,
                    AssignedUserId = 10,
                    AssignedUser = users.Single(x => x.Id == 10),
                    SubTasks = new List<Models.Task> {
                        new Task { Id = 1, Title = "Prepare feedback form", Description = "Create a feedback form for clients.", Priority = Priority.Medium, DueDate = DateTime.Now.AddDays(1), Status = Status.NotStarted },
                        new Task { Id = 2, Title = "Send feedback request", Description = "Send feedback request to clients.", Priority = Priority.High, DueDate = DateTime.Now.AddDays(2), Status = Status.NotStarted },
                        new Task { Id = 3, Title = "Collect feedback", Description = "Collect feedback from clients.", Priority = Priority.Medium, DueDate = DateTime.Now.AddDays(3), Status = Status.NotStarted },
                        new Task { Id = 4, Title = "Analyze feedback", Description = "Analyze the collected feedback.", Priority = Priority.High, DueDate = DateTime.Now.AddDays(4), Status = Status.NotStarted },
                        new Task { Id = 5, Title = "Identify action items", Description = "Identify actionable items from feedback.", Priority = Priority.Critical, DueDate = DateTime.Now.AddDays(5), Status = Status.NotStarted },
                        new Task { Id = 6, Title = "Plan improvements", Description = "Plan improvements based on feedback.", Priority = Priority.High, DueDate = DateTime.Now.AddDays(6), Status = Status.NotStarted },
                        new Task { Id = 7, Title = "Implement improvements", Description = "Implement the planned improvements.", Priority = Priority.Critical, DueDate = DateTime.Now.AddDays(7), Status = Status.NotStarted },
                        new Task { Id = 8, Title = "Review improvements", Description = "Review the implemented improvements.", Priority = Priority.High, DueDate = DateTime.Now.AddDays(8), Status = Status.NotStarted },
                        new Task { Id = 9, Title = "Update clients", Description = "Update clients on the implemented changes.", Priority = Priority.Medium, DueDate = DateTime.Now.AddDays(9), Status = Status.NotStarted },
                        new Task { Id = 10, Title = "Document feedback process", Description = "Document the client feedback process.", Priority = Priority.Low, DueDate = DateTime.Now.AddDays(10), Status = Status.NotStarted }
                    }
                }
            };
            return tasks;
        }
    }
}