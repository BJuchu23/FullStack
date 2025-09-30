using Scalar.AspNetCore;
using ServerAPI.Data;
using ServerAPI.Domain.Contracts;
using ServerAPI.Service;
using ServerAPI.Extensions;

var builder = WebApplication.CreateBuilder(args);
builder.Services.ConfigureCors(builder.Configuration);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();



builder.Services.AddSingleton<AppDbContext>();
builder.Services.Configure<MongoDBSettings>(builder.Configuration.GetSection
    ("MongoDB"));
builder.Services.AddScoped<IProductService, ProductService>();

var app = builder.Build();
app.UseCors("CorsPolicy");

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.MapScalarApiReference(); //Test API
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
