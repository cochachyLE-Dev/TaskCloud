var builder = DistributedApplication.CreateBuilder(args);

var launchProfileName = "https";

var identityApi = builder.AddProject<Projects.TaskCloud_Authentication>("taskcloud-authentication", launchProfileName)
    .WithExternalHttpEndpoints();

var identityEndpoint = identityApi.GetEndpoint(launchProfileName);

builder.AddProject<Projects.TaskCloud_Tasks>("taskcloud-tasks")
    .WithEnvironment("Identity__Url", identityEndpoint);

builder.AddProject<Projects.TaskCloud_Users>("taskcloud-users")
    .WithEnvironment("Identity__Url", identityEndpoint);

builder.AddProject<Projects.TaskCloud_WebApp>("taskcloud-webapp");

builder.Build().Run();
