using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using ProjAPIBanco.Data;
using ProjAPIBanco.Service;
using ProjAPIBanco.Utils;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<ProjAPIBancoContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("ProjAPIBancoContext") ?? throw new InvalidOperationException("Connection string 'ProjAPIBancoContext' not found.")));

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.Configure<BancoSettings>(builder.Configuration.GetSection(nameof(BancoSettings)));
builder.Services.AddSingleton<IBancoSettings>(b => b.GetService<IOptions<BancoSettings>>().Value);

builder.Services.AddSingleton<BancoService>();

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
