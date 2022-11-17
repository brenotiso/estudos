using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Versioning;
using Microsoft.EntityFrameworkCore;
using TodoApi.Database;
using TodoApi.Extensions;
using TodoApi.Middlewares;
using TodoApi.Repositories;
using TodoApi.Repositories.Interfaces;
using TodoApi.Services;
using TodoApi.Services.Interfaces;
using StackExchange.Redis;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddDbContextPool<TodoContext>(options =>
{
    options.UseNpgsql(builder.Configuration.GetConnectionString("TodoConnection"));
});
builder.Services.AddStackExchangeRedisCache(options =>
{
    options.ConfigurationOptions = new ConfigurationOptions
    {
        EndPoints = { $"{builder.Configuration["urlRedis"]}:{builder.Configuration["portRedis"]}" },
        Password = builder.Configuration["passRedis"]
    };
});

builder.Services.AddScoped(typeof(IRepository<>), typeof(EfRepository<>));

builder.Services.AddScoped<ITodoService, TodoService>();

//builder.Services.AddDistributedMemoryCache();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddApiVersioning(setupAction =>
{
    setupAction.AssumeDefaultVersionWhenUnspecified = true;
    setupAction.DefaultApiVersion = new ApiVersion(1, 0);
    setupAction.ReportApiVersions = true;
    setupAction.ApiVersionReader = ApiVersionReader.Combine(
        new MediaTypeApiVersionReader("ver"));
});
builder.Services.AddVersionedApiExplorer(options =>
{
    options.GroupNameFormat = "'v'VVV";
    options.SubstituteApiVersionInUrl = true;
});
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapControllers();

app.UseMiddleware<ExceptionMiddleware>();

app.MigrateDatabase();

app.Run();
