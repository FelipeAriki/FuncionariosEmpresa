using FuncionariosEmpresa.Application.Interfaces;
using FuncionariosEmpresa.Application.Services;
using FuncionariosEmpresa.Data.Repositories;
using FuncionariosEmpresa.Domain.Interfaces;
using Npgsql;
using System.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var configuration = new ConfigurationBuilder()
    .AddJsonFile("appsettings.json")
    .Build();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IEntrevistaFuncionariosEmpresaRepository, EntrevistaFuncionariosEmpresaRepository>();
builder.Services.AddScoped<IEntrevistaFuncionariosEmpresaService, EntrevistaFuncionariosEmpresaService>();

builder.Services.AddScoped<IFuncionariosEmpresaRepository, FuncionariosEmpresaRepository>();
builder.Services.AddScoped<IFuncionariosEmpresaService, FuncionariosEmpresaService>();

builder.Services.AddScoped<IEnderecoFuncionariosEmpresaRepository, EnderecoFuncionariosEmpresaRepository>();
builder.Services.AddScoped<IEnderecoFuncionariosEmpresaService, EnderecoFuncionariosEmpresaService>();

//Realiza��o a inje��o de depend�ncia do nosso BD
var connectionString = configuration.GetValue<string>("ConnectionStringPostgres");
builder.Services.AddScoped<IDbConnection>((connection) => new NpgsqlConnection(connectionString));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
