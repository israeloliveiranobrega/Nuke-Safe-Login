using Microsoft.EntityFrameworkCore;
using Nuke_Safe_Login.Domain.Helpers.Extension;
using Nuke_Safe_Login.Domain.Models.Value_Objects.Base;
using System;

var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration.GetConnectionString("SafePlaceConnection");

builder.Services.AddDbContext<DbContext>(options => options.UseNpgsql(connectionString));

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddOpenApi();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

CPF teste = new CPF("12345678909");

var egf = (CPF)"12312312312";

"53y1325y135y".ToCpf();

var egfs = (string)teste;

if (teste != "53grwedfs")
{

}

//services.AddMediatR(cfg =>
//{
//    cfg.RegisterServicesFromAssembly(typeof(Program).Assembly);
//    cfg.AddOpenBehavior(typeof(ValidUserBehavior<,>));
//    cfg.AddOpenBehavior(typeof(SendEmailBehavior<,>));
//    cfg.AddOpenBehavior(typeof(LogBehavior<,>));//ordem de adiçãoo implica na ordem de execução deles
//});

//var command = new CreateUserCommand
//{
//    Name = Console.ReadLine() ?? string.Empty
//};