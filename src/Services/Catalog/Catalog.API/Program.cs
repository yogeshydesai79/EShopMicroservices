using Carter;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCarter();
builder.Services.AddMediatR(config => 
{ 
    config.RegisterServicesFromAssemblies(typeof(Program).Assembly); 
});


var app = builder.Build();

//Confiure HTTP request pipeline
app.MapCarter();

app.Run();
