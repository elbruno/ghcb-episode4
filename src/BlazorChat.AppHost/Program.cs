var builder = DistributedApplication.CreateBuilder(args);


builder.AddProject<Projects.BlazorChat_ChatApp>("chatapp")
    .WithExternalHttpEndpoints();

builder.Build().Run();