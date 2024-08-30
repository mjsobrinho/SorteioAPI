using SorteioAPI.Services.MinhaApi.Services;

var builder = WebApplication.CreateBuilder(args);

// Adiciona os serviços ao container
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Registrar o InfoTelaService para injeção de dependência
builder.Services.AddScoped<InfoTelaService>();

var app = builder.Build();

// Configura o pipeline HTTP
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseRouting();

app.UseAuthorization();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
});

app.Run();
