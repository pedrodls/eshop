var builder = WebApplication.CreateBuilder(args);

builder.Services
    .AddBasketModule(builder.Configuration)
    .AddCatalogModule(builder.Configuration)
    .AddOrderingModule(builder.Configuration);

var app = builder.Build();

app
    .UseBasketModule()
    .UseCatalogModule()
    .UseOrderingModule();

app.Run();
