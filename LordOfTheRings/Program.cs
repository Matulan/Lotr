using LordOfTheRings.Components;
using LordOfTheRings.Interfaces;
using LordOfTheRings.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddHttpClient<ICharacterApiService, CharacterApiService>(client =>
{
    client.BaseAddress = new Uri("https://lotrapi.co/");
});

builder.Services.AddHttpClient<IBookApiService, BookApiService>(client =>
{
    client.BaseAddress = new Uri("https://lotrapi.co/");
});

builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();