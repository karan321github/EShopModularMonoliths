var builder = WebApplication.CreateBuilder(args);

//Add services before building the app

var app = builder.Build();

// Configure the HTTP request pipeline.

app.Run();