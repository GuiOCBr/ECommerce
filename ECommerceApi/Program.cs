using ECommerceApi.Repositories;

var builder = WebApplication.CreateBuilder(args);

#region ConfigureService()
// Aqui fica os serviços que a aplicação vai usar
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IUserRepository, UserRepository>();
#endregion
var app = builder.Build();

#region Configure()
// Aonde fica o pipeline de execução, fluxo 
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
#endregion