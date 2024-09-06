using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

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

// Controller: Kullanýcý isteklerini iþleyen ve uygulama mantýðýný gerçekleþtiren sýnýflardýr. Genellikle bir HTTP isteðini alýr, gerekli iþlemleri yapar ve uygun bir yanýt döner.

// Action: Controller içindeki metotlardýr. Her bir action, belirli bir HTTP isteðine yanýt verir ve genellikle bir View döner.

// Model: Verileri temsil eden ve iþ mantýðýný kapsayan sýnýflardýr. Genellikle veritabaný tablolarýný veya uygulama verilerini temsil eder ve verilerin geçerli olduðunu doðrulamak için kullanýlýr.

// View: Kullanýcýya veriyi sunan, HTML içeriði oluþturan ve kullanýcý arayüzünü tanýmlayan þablonlardýr. Razor motoru kullanýlarak oluþturulur ve kullanýcýya dinamik HTML gönderir.

// Razor: ASP.NET Core'da dinamik HTML içeriði oluþturmak için kullanýlan bir þablon motorudur. Razor, C# kodunu HTML ile birleþtiren bir sözdizimi saðlar ve dinamik içerik üretimi için kullanýlýr.

// RazorView: Razor motoru kullanýlarak oluþturulan ve HTML içeriði üreten view'lerdir. Bir controller'dan dönen view, Razor þablonunu kullanarak render edilir.

// wwwroot:  ASP.NET Core uygulamasýnýn kök dizininde bulunan ve genellikle statik dosyalarýn (CSS, JavaScript, resimler) saklandýðý klasördür. Statik dosyalar bu dizinden sunulur ve kullanýcýya doðrudan eriþim saðlar.

// builder.Build(): Konfigüre edilmiþ servisler ve ayarlar temelinde uygulamayý oluþtur. Bu yöntem, uygulama kurulumunu tamamlar ve istekleri iþlemek için hazýr hale getirir.

// app.Run(): Uygulamayý çalýþtýr ve gelen HTTP isteklerini dinlemeye baþla. Bu yöntem, web sunucusunu baþlatýr ve uygulamanýn istemci isteklerini iþleyip yanýt vermesine olanak tanýr.