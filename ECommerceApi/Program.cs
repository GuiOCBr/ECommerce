using ECommerceApi.Repositories;

var builder = WebApplication.CreateBuilder(args);

#region ConfigureService()
// Aqui fica os servi�os que a aplica��o vai usar
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IUserRepository, UserRepository>();
#endregion
var app = builder.Build();

#region Configure()
// Aonde fica o pipeline de execu��o, fluxo 
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