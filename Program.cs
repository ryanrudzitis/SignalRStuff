using SignalrChat.hubs;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

builder.Services.AddSignalR();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.UseEndpoints(
    endpoints =>
    {
        endpoints.MapHub<ChatHub>("/chatHub");
        endpoints.MapHub<DrawDotHub>("/drawDotHub");
    }
);

app.MapRazorPages();

app.Run();
