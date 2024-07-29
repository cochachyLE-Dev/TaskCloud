var builder = DistributedApplication.CreateBuilder(args);


var postgres = builder.AddPostgres("postgres")    
    .WithImageTag("latest");

var taskDb = postgres.AddDatabase("taskdb");
var userDb = postgres.AddDatabase("userdb");
var identityDb = postgres.AddDatabase("identitydb");

var launchProfileName = "https";

var identityApi = builder.AddProject<Projects.TaskCloud_Authentication>("taskcloud-authentication", launchProfileName)
    .WithReference(identityDb)
    .WithExternalHttpEndpoints();

var identityEndpoint = identityApi.GetEndpoint(launchProfileName);

builder.AddProject<Projects.TaskCloud_Tasks>("taskcloud-tasks")
    .WithReference(taskDb)
    .WithEnvironment("Identity__Url", identityEndpoint);

builder.AddProject<Projects.TaskCloud_Users>("taskcloud-users")
    .WithReference(userDb)
    .WithEnvironment("Identity__Url", identityEndpoint);

builder.AddProject<Projects.TaskCloud_WebApp>("taskcloud-webapp");

builder.Build().Run();
