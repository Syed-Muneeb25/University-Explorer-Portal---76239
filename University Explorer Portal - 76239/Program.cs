using University_Explorer_Portal___76239.Components;
using University_Explorer_Portal___76239.Services;

var builder = WebApplication.CreateBuilder(args);

// Register HttpClient
builder.Services.AddHttpClient();

// Register API services
builder.Services.AddScoped<CountryService>();
builder.Services.AddScoped<UniversityService>();
builder.Services.AddScoped<StudentApplicationService>();

// Add services to the container.
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
app.UseStatusCodePagesWithReExecute("/not-found", createScopeForStatusCodePages: true);
app.UseHttpsRedirection();

app.UseAntiforgery();

app.MapStaticAssets();
app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
