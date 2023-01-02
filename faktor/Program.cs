using Bussines.Layer.Invoice.Contracts;
using Bussines.Layer.Invoice.Services;
using DomainEntity.Models;
using Microsoft.EntityFrameworkCore;
using ServiceCollection.Invoice;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();

// Add services to the container.
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.InvoiceService();
builder.Services.AddDbContext<pishroContext>(
    options =>
    options.UseSqlServer(
            builder.Configuration["ConnectionString:pishro"], x => x.MigrationsAssembly("DomainEntity")));
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}





app.MapControllers();

app.Run();
