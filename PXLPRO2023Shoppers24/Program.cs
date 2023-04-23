using HrApp.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using PXLPRO2023Shoppers24.Data;
using PXLPRO2023Shoppers24.Models;
using PXLPRO2023Shoppers24.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<AppDbContext>(options =>
options.UseSqlServer(builder.Configuration["ConnectionStrings:DefaultConnection"]));

builder.Services.AddScoped<ILaptopService, LaptopService>();
builder.Services.AddScoped<IdentityRepoInterface, IdentityRepository>();
builder.Services.AddIdentity<ApplicationUser, IdentityRole>().AddEntityFrameworkStores<AppDbContext>();

builder.Services.Configure<IdentityOptions>(options => {
    options.User.AllowedUserNameCharacters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-._@+ ";
    options.User.RequireUniqueEmail = true;
});


builder.Services.AddAuthentication()
.AddFacebook(fbOpts =>
{
    fbOpts.AppId = "3414405128815163";
    fbOpts.AppSecret = "34430bf48f3d81e3909cfe7007a2401c";
});
builder.Services.AddAuthentication().AddGoogle(options =>
{
    options.ClientId =
    "840228473399-gencr6or0udsqckg55a1ras8ndf4bbqm.apps.googleusercontent.com";
    options.ClientSecret = "R9MI9BP_yYorCI-xEB4zMivB";
    options.SignInScheme = IdentityConstants.ExternalScheme;
});
builder.Services.AddAuthentication()
.AddCookie("Cookies")
.AddOpenIdConnect("oidc", options =>
{
    options.Authority = "https://localhost:5001";
    options.ClientId = "mvc";
    options.ClientSecret = "secret";
    options.ResponseType = "code";
    options.SaveTokens = true;
    options.Scope.Add("openid");
    options.Scope.Add("profile");
    options.Scope.Add("email");
    options.GetClaimsFromUserInfoEndpoint = true;
});

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
app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
AppDbInializer.SeedUsersAndRolesAsync(app);
AppDbInializer.Seed(app);
app.Run();
