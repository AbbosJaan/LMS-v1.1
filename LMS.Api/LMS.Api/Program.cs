using LMS.Data;
using LMS.Data.Interfaces;
using LMS.Service.Courses;
using LMS.Service.Groups;
using LMS.Service.Interfaces;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnectionString")));


builder.Services.AddScoped<IGroupBaseRepository, GroupBaseRepository>();
builder.Services.AddScoped<IGroupSerivce, GroupService>();

builder.Services.AddScoped<ICourseBaseRepository, CourseBaseRepository>();
builder.Services.AddScoped<ICourseService, CourseService>();

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
