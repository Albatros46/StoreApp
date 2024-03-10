using Microsoft.EntityFrameworkCore;
using StoreApp.Data.Abstract;
using StoreApp.Data.Concrete;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews(); //MVC yapisini aktif ediyoruz
builder.Services.AddDbContext<StoreDbContext>(opt => {
    opt.UseSqlite(builder.Configuration["ConnectionStrings:StoreDbConnection"]);
});
//Scopped her talepte calisir. Singelton : sadece bir kere calisacsaktir. asp.net core service live seklinde aranabilir googleden.
builder.Services.AddScoped<IStoreRepository, EFStoreRepository>(); 

var app = builder.Build();

app.UseStaticFiles();//Kullanici  statik dosyalarini aktif ediyoruz
app.MapDefaultControllerRoute();

app.Run();
