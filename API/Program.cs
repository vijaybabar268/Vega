// Add services to the container.
using API.Persistence;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<VegaDbContext>(opt => 
{
    opt.UseSqlServer(builder.Configuration.GetConnectionString("DefaultCS"));
});
builder.Services.AddAutoMapper();

// Configure the HTTP request pipeline.
var app = builder.Build();
if (app.Environment.IsDevelopment()) { app.UseSwagger(); app.UseSwaggerUI(); }
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();
