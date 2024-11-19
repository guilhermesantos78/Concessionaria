using Core;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

InicializadorBd.Inicializar();

//Permitir Requisicao no html
builder.Services.AddCors(options =>
{
    options.AddPolicy("PermitirTudo",
        builder =>
        {
            builder.AllowAnyOrigin()
                   .AllowAnyMethod()
                   .AllowAnyHeader();
        });
});

builder.Services.AddScoped<ICarroService, CarroService>();
builder.Services.AddScoped<ICarroRepository, CarroRepository>();

builder.Services.AddScoped<ICaminhaoService, CaminhaoService>();
builder.Services.AddScoped<ICaminhaoRepository, CaminhaoRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

//Permitir Requisicao no html
app.UseCors("PermitirTudo");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
