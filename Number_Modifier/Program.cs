using Microsoft.EntityFrameworkCore;
using Number_Modifier.Model;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
#region Database Connection:

string _defaultConnString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddScoped<intllgr_dbms2Context>().AddDbContext<intllgr_dbms2Context>(options =>
      options.UseMySql(_defaultConnString,
          ServerVersion.AutoDetect(_defaultConnString),
          options => options.EnableRetryOnFailure(
              maxRetryCount: 5,
              maxRetryDelay: TimeSpan.FromSeconds(30),
              errorNumbersToAdd: null))
  );



#endregion

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

app.UseAuthorization();

app.MapControllers();

app.Run();
