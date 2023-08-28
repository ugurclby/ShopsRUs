using Autofac;
using Autofac.Core;
using Autofac.Extensions.DependencyInjection;
using Bogus;
using FluentValidation;
using ShopsRUs.Api.IOC;
using ShopsRUs.Api.Models;
using ShopsRUs.Api.Validation;
using ShopsRUs.Application.Abstract;
using ShopsRUs.Application.Concrete;
using ShopsRUs.Domain.Mapping;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory()).ConfigureContainer<ContainerBuilder>(builder =>
{
    builder.RegisterModule(new AutoFacModule());
});
builder.Services.AddAutoMapper(typeof(Mapping)); 

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
