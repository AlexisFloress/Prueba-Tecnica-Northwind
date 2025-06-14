using Microsoft.EntityFrameworkCore;
using NorthWind.Data;
using NorthWind.Mappers;
using NorthWind.Repositorio;
using NorthWind.Repositorio.IRepositorio;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<ApplicationDbContext>(opciones =>
    opciones.UseSqlServer(builder.Configuration.GetConnectionString("ConexionSql"))
);



//Repositorio
builder.Services.AddScoped<IClienteRepositorio, ClienteRepositorio>();
//Agregamos el autoMapper
builder.Services.AddAutoMapper(typeof(NorthWindMappers));

// Habilita CORS
builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(policy =>
    {
        policy
            .AllowAnyOrigin()    // Permite cualquier origen (en desarrollo)
            .AllowAnyHeader()
            .AllowAnyMethod();
    });
});



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

app.UseCors();
app.UseAuthorization();

app.MapControllers();

app.Run();
