using HrApp.Services;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using PXLPRO2023Shoppers24;
using PXLPRO2023Shoppers24.Data;
using PXLPRO2023Shoppers24.Models;
using PXLPRO2023Shoppers24.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddHttpClient(
ApiConstants.StockApiHttpClientName,
c => { c.BaseAddress = new Uri("https://localhost:7144/api/"); });

builder.Services.AddDbContext<AppDbContext>(options =>
options.UseSqlServer(builder.Configuration["ConnectionStrings:DefaultConnection"]));
builder.Services.AddServerSideBlazor();
builder.Services.AddScoped<ILaptopService, LaptopService>();
builder.Services.AddScoped<ISmartphoneService, SmartphoneService>();    
builder.Services.AddScoped<IdentityRepoInterface, IdentityRepository>();
builder.Services.AddScoped<IOrdersService, OrderService>();
builder.Services.AddScoped<IStockApiRepository, StockAPIRespository>();
builder.Services.AddScoped<IStockOrderRepository, StockOrderRepository>();

builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
builder.Services.AddScoped(sc => PXLPRO2023Shoppers24.Data.Cart.ShoppingCart.GetShoppingCart(sc));
builder.Services.AddIdentity<ApplicationUser, IdentityRole>().AddEntityFrameworkStores<AppDbContext>();

builder.Services.Configure<IdentityOptions>(options => {
    options.User.AllowedUserNameCharacters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-._@+ ";
    options.User.RequireUniqueEmail = true;
});

builder.Services.AddMemoryCache();
builder.Services.AddSession();
builder.Services.AddAuthentication(options =>
{
    options.DefaultScheme = CookieAuthenticationDefaults.AuthenticationScheme;
});

builder.Services.AddAuthentication()
.AddFacebook(fbOpts =>
{
    fbOpts.AppId = "165028353076407";
    fbOpts.AppSecret = "bbca0a2a6e98684878319ee91bb6f590";
});
builder.Services.AddAuthentication().AddGoogle(options =>
{
    options.ClientId =
    "903490925605-6dpo2mme8s3iih7mhh3n7a1qdhgejh6d.apps.googleusercontent.com";
    options.ClientSecret = "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";
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
app.UseSession();
app.UseAuthentication();
app.UseAuthorization();
app.UseEndpoints(endpoints =>
{
	endpoints.MapDefaultControllerRoute();
	//Enable attribute based routing for controllers:
	endpoints.MapControllers();
	endpoints.MapBlazorHub();
});

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
AppDbInializer.Seed(app);
AppDbInializer.SeedUsersAndRolesAsync(app).Wait();
app.Run();
