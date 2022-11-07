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
builder.Services.AddCors(opt =>
{
    opt.AddPolicy("CorsPolicy", policy =>
    {
        policy.AllowAnyMethod().AllowAnyHeader().WithOrigins("http://localhost:3000");
    });
});

var app = builder.Build();

app.UseExceptionHandler("/error");

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors("CorsPolicy");

app.UseAuthorization();

app.MapControllers();

app.Run();
