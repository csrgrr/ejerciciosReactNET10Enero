using Ejercicio2.Config;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Services.AddDbContext<DBEmpleadoContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("EmpleadoDataBase"));
}
);

builder.Services.AddCors(options =>
{
    options.AddPolicy("Mi_Politica", app =>
    {
        app.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod();
    });
}
    );

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("Mi_Politica");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
