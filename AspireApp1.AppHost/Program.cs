IDistributedApplicationBuilder builder = DistributedApplication.CreateBuilder(args);

IResourceBuilder<ProjectResource> apiService = builder.AddProject<Projects.AspireApp1_ApiService>(
    "apiservice"
);

builder.Build().Run();
