using FluentValidation;
using Infra.Repository.DbContext;
using Infra.Repository.Repositories.AddSeguro;
using SeguroVeiculos.API.Models.AddSeguro;
using SeguroVeiculos.Application.UseCases.AddSeguro;
using SeguroVeiculos.Domain.Contracts.Repositories.AddSeguro;
using SeguroVeiculos.Domain.Contracts.UseCases.AddSeguro;
using System.Globalization;

var builder = WebApplication.CreateBuilder(args);


// Add services to the container.
builder.Services.AddSingleton<IDbContext, DbContext>();
builder.Services.AddSingleton<IAddSeguroRepository, AddSeguroRepository>();
builder.Services.AddScoped<IAddSeguroUseCase, AddSeguroUseCase>();
builder.Services.AddTransient<IValidator<AddSeguroInput>, AddSeguroInputValidator>();


builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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

var cultureInfo = new CultureInfo("pt-BR");
CultureInfo.DefaultThreadCurrentCulture = cultureInfo;
CultureInfo.DefaultThreadCurrentUICulture = cultureInfo;

app.Run();
