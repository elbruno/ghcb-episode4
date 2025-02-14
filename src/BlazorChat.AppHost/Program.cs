var builder = DistributedApplication.CreateBuilder(args);

var appInsights = builder.AddAzureApplicationInsights("appInsights");

builder.AddProject<Projects.BlazorChat_ChatApp>("chatapp")
    .WithReference(appInsights)
    .WithExternalHttpEndpoints();

builder.Build().Run();