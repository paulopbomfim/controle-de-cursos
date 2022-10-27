using ControleDeCursos.Data;
using ControleDeCursos.Repositories;

var builder = WebApplication.CreateBuilder(args);

DotNetEnv.Env.Load();

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<ApplicationDataContext>();
builder.Services.AddScoped<IApplicationDataContext, ApplicationDataContext>();
// builder.Services.AddScoped<ICourseRepository, CourseRepository>();
// builder.Services.AddScoped<ILeadRepository, LeadRepository>();

var context = new ApplicationDataContext();
context.Database.EnsureCreated();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    // app.UseExceptionHandler("/Home/Error");
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
