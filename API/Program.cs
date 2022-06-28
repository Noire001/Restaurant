var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<DataContext>(opt =>
{
    opt.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection"));
});

builder.Host.UseSerilog((context, services, configuration) => configuration
    .ReadFrom.Configuration(context.Configuration)
    .Enrich.FromLogContext());

Log.Information("Starting web host");
var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    try
    {
        var context = scope.ServiceProvider.GetRequiredService<DataContext>();
        await context.Database.MigrateAsync();
    }
    catch (Exception e)
    {
        Log.Error(e, "Error while migrating database");
    }
}

app.MapGet("/", () => "Hello World!");

app.Run();