using Microsoft.EntityFrameworkCore;
using OP_beContext.EFContext;
using OP_beContext.Repositories;
using OP_beContext.Services;
using OP_beModel.Repositories;
using OP_beModel.Services;

var builder = WebApplication.CreateBuilder(args);
var connectionString = "Server = 173.249.39.182; User Id=SA; Password=9EFD8a1744@; Database = OP";

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<OPbeContext>(x => x.UseSqlServer(connectionString));
builder.Services.AddScoped<IUserRepository, EFUserRepository>();
builder.Services.AddScoped<IPeopleService, EFPeopleService>();
builder.Services.AddScoped<IAdminRepository, EFAdminRepository>();
builder.Services.AddScoped<ITokenRepository, EFTokenRepository>();
builder.Services.AddCors(c => c.AddPolicy("alloworigin", options => options.AllowAnyOrigin()
                                                                            .AllowAnyHeader()
                                                                            .AllowAnyMethod()));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
