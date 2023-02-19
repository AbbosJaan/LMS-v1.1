using LMS.Data;
using LMS.Data.Interfaces;
using LMS.Service.Courses;
using LMS.Service.Groups;
using LMS.Service.Interfaces;
using LMS.Service.Topics;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();



builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnectionString")));


builder.Services.AddScoped<IGroupBaseRepository, GroupBaseRepository>();
builder.Services.AddScoped<IGroupSerivce, GroupService>();

builder.Services.AddScoped<ICourseBaseRepository, CourseBaseRepository>();
builder.Services.AddScoped<ICourseService, CourseService>();

builder.Services.AddScoped<ITopicBaseRepository, TopicBaseRepository>();
builder.Services.AddScoped<ITopicService, TopicService>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
