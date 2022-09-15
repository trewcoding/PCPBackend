using API.ServiceExtensions;
using ApiClients.Extensions;
using ServiceLayer.Extemsions;
using DataAccess.Extensions;
using Domain.Extensions;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container
var configuration = builder.Configuration;

builder.Services.AddControllers()
    .AddNewtonsoftJson(options => {
        //options.SerializerSettings.ContractResolver =
        //      new CamelCasePropertyNamesContractResolver();
        options.SerializerSettings.ReferenceLoopHandling =
        Newtonsoft.Json.ReferenceLoopHandling.Ignore;
    });

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddApiClientsMapping();
builder.Services.AddDataAccessModules(configuration);
builder.Services.AddServiceLayerModules(configuration);
builder.Services.AddAPIService();
builder.Services.AddDomainModules();

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
