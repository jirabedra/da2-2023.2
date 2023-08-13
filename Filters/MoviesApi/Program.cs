using BusinessLogic;
using LogicInterface.Interfaces;
using ServiceFactory;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddServices();

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



app.Use(async (context, next) =>
{
    await context.Response.WriteAsync("Request llegando al primer componente \n");
    await next();
    await context.Response.WriteAsync("Request saliendo del primer componente \n");
});

app.Use(async (context, next) =>
{
    await context.Response.WriteAsync("Request llegando al segundo componente \n");
    await next();
    await context.Response.WriteAsync("Request saliendo del segundo componente \n");
});

app.Run(async (context) =>
{
    await context.Response.WriteAsync("Fin del pipeline \n");
});

app.Run();
