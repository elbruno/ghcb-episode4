var builder = DistributedApplication.CreateBuilder(args);

var chatapp = builder.AddProject<Projects.BlazorChat_ChatApp>("chatapp")
    .WithExternalHttpEndpoints();

builder.Build().Run();