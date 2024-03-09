var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews(); //MVC yapisini aktif ediyoruz


var app = builder.Build();

app.UseStaticFiles();//Kullanici  statik dosyalarini aktif ediyoruz
app.MapDefaultControllerRoute();

app.Run();
