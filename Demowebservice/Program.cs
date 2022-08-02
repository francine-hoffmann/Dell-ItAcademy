var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
//So adicionou o pipeline para controlers , não tem views, porque aqui é negocio não tem interface de usuario
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
// as duas linhas acima geram a documentação da nossa api
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();
//configuração do gerador

app.Run();
