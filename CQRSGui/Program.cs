
var builder = WebApplication.CreateBuilder(args);
ReadModel.RegisterHandlersInvenotryItemDetailView();
ReadModel.RegisterHandlersInventoryListView();

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseAuthorization();

app.MapDefaultControllerRoute();

app.Run();
