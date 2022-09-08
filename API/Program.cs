using API.ServiceExtensions;
using ApiClients.Extensions;
using DataAccess.Extensions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using ServiceLayer.Extemsions;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container
var configuration = builder.Configuration;


builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddApiClientsMapping();
builder.Services.AddDataAccessModules(configuration);
builder.Services.AddServiceLayerModules(configuration);
builder.Services.AddApiModules();
//services.AddMediatR(typeof(HandlerListAllProducts).GetTypeInfo().Assembly);
builder.Services.AddMediatR(typeof(Program));

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
