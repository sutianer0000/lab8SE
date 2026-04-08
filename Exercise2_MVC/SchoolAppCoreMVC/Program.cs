using Microsoft.EntityFrameworkCore;
using SchoolAppCoreMVC.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorPages();

// Register EF Core context and connection string
builder.Services.AddDbContext<SchoolContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("SchoolDB")));

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();
app.MapRazorPages();
app.Run();