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

// Controller: Kullan�c� isteklerini i�leyen ve uygulama mant���n� ger�ekle�tiren s�n�flard�r. Genellikle bir HTTP iste�ini al�r, gerekli i�lemleri yapar ve uygun bir yan�t d�ner.

// Action: Controller i�indeki metotlard�r. Her bir action, belirli bir HTTP iste�ine yan�t verir ve genellikle bir View d�ner.

// Model: Verileri temsil eden ve i� mant���n� kapsayan s�n�flard�r. Genellikle veritaban� tablolar�n� veya uygulama verilerini temsil eder ve verilerin ge�erli oldu�unu do�rulamak i�in kullan�l�r.

// View: Kullan�c�ya veriyi sunan, HTML i�eri�i olu�turan ve kullan�c� aray�z�n� tan�mlayan �ablonlard�r. Razor motoru kullan�larak olu�turulur ve kullan�c�ya dinamik HTML g�nderir.

// Razor: ASP.NET Core'da dinamik HTML i�eri�i olu�turmak i�in kullan�lan bir �ablon motorudur. Razor, C# kodunu HTML ile birle�tiren bir s�zdizimi sa�lar ve dinamik i�erik �retimi i�in kullan�l�r.

// RazorView: Razor motoru kullan�larak olu�turulan ve HTML i�eri�i �reten view'lerdir. Bir controller'dan d�nen view, Razor �ablonunu kullanarak render edilir.

// wwwroot:  ASP.NET Core uygulamas�n�n k�k dizininde bulunan ve genellikle statik dosyalar�n (CSS, JavaScript, resimler) sakland��� klas�rd�r. Statik dosyalar bu dizinden sunulur ve kullan�c�ya do�rudan eri�im sa�lar.

// builder.Build(): Konfig�re edilmi� servisler ve ayarlar temelinde uygulamay� olu�tur. Bu y�ntem, uygulama kurulumunu tamamlar ve istekleri i�lemek i�in haz�r hale getirir.

// app.Run(): Uygulamay� �al��t�r ve gelen HTTP isteklerini dinlemeye ba�la. Bu y�ntem, web sunucusunu ba�lat�r ve uygulaman�n istemci isteklerini i�leyip yan�t vermesine olanak tan�r.