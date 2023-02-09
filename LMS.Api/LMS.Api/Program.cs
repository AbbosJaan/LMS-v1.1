using LMS.Data;
using LMS.Data.Interfaces;
using LMS.Service;
using LMS.Service.Interfaces;
using LMS.ViewModel;
using LMS.ViewModel.CreationViewModel;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnectionString")));

builder.Services.AddTransient<IGroupBaseRepository, GroupBaseRepository>();
builder.Services.AddTransient<IGroupSerivce, GroupService>();


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

//AppDbInitializer.Seed(app);

app.Run();
