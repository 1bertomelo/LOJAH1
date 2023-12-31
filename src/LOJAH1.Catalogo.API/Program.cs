using LOJAH1.Catalogo.Application.Interfaces;
using LOJAH1.Catalogo.Application.Services;
using LOJAH1.Catalogo.Data.Repository;
using LOJAH1.Catalogo.Domain.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
//configurando a inje��o de dependencia
builder.Services.AddScoped<IProdutoService, ProdutoService >();
builder.Services.AddScoped<IProdutoRepository, ProdutoRepository >();

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
