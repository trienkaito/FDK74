using FBK74App.models;
using FBK74App.Service;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Proxies;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddRouting(options =>
{
    options.LowercaseUrls = true;
});
builder.Services.AddSession();
builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"))
            .UseLazyLoadingProxies();
});

// Configure authentication for user
builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = "cookie";
    options.DefaultScheme = "cookie";
})
           .AddCookie("cookie", options =>
           {
               options.LoginPath = "/auth/login";
               options.AccessDeniedPath = "/";
               options.ExpireTimeSpan = TimeSpan.FromDays(7);
               options.Cookie.MaxAge = options.ExpireTimeSpan;
               options.SlidingExpiration = true;
           });


// Configure authentication for admin
builder.Services.AddAuthentication("AdminScheme")
    .AddCookie("AdminScheme", options =>
    {
        options.LoginPath = "/admin/auth/login";
        options.AccessDeniedPath = "/admin/auth/login";
        options.ExpireTimeSpan = TimeSpan.FromDays(7);
        options.Cookie.MaxAge = options.ExpireTimeSpan;
        options.SlidingExpiration = true;
    });

builder.Services.AddScoped<ICookieAuthentication, CookieAuthentication>();
builder.Services.AddScoped<ICookieAdminAuthentication, CookieAdminAuthentication>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseSession();

app.UseAuthentication();
app.UseAuthorization();

app.MapRazorPages();

app.Run();